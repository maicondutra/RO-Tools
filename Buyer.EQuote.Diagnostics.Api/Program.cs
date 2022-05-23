using Buyer.EQuote.Diagnostics.Api.Schema;
using Buyer.EQuote.Diagnostics.Api.Schema.Queries;
using Buyer.EQuote.Diagnostics.Common;
using Buyer.EQuote.Diagnostics.Common.Exceptions;
using Buyer.EQuote.Diagnostics.Domain;
using GraphiQl;
using GraphQL;
using GraphQL.Server;
using GraphQL.SystemTextJson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IDocumentExecuter, DocumentExecuter>();
//builder.Services.AddTransient<IGraphQLSerializer, GraphQLSerializer>(); TODO: funciona apenas na versão GraphQL V5
builder.Services.AddTransient<IDocumentWriter, DocumentWriter>(); //TODO: funciona apenas na versão GraphQL V4
builder.Services.AddTransient<SearchQuery>();
builder.Services.AddSingleton<ServiceSchema>();


//builder.Services.AddControllers();
builder.Services.AddControllers(cfg => {
    cfg.Filters.Add(typeof(AppFilterAttributeException));
});

builder.Services.ConfigureCommonServices();
builder.Services.ConfigureDomainServices(builder.Environment, builder.Configuration);

//TODO: Quando migrado para a versão V5 do GraphQL, esta dando erro no IDocumentWriter que só funciona na versão GraphQL V4
builder.Services.AddGraphQL().AddSystemTextJson(cfg => { }, serializerSettings => { }).AddDataLoader().AddGraphTypes(typeof(ServiceSchema));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseGraphiQl("/graphql", "/api/diagnostics/gql");
app.UseGraphQL<ServiceSchema>("/api/diagnostics/gql");

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
