using GraphiQl;
using GraphQL;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using RO_Tools.Filters;
using RO_Tools.Repository;
using RO_Tools.Schema;
using RO_Tools.Schema.Queries;
using RO_Tools.Schema.Types;
using RO_Tools.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IDocumentExecuter, DocumentExecuter>();
//builder.Services.AddTransient<IGraphQLSerializer, GraphQLSerializer>(); TODO: funciona apenas na versão GraphQL V5
builder.Services.AddTransient<IDocumentWriter, DocumentWriter>(); //TODO: funciona apenas na versão GraphQL V4
builder.Services.AddTransient<OstSettingsService>();
builder.Services.AddSingleton<OstSettingsRepository>();
builder.Services.AddTransient<SearchQuery>();
builder.Services.AddTransient<OstSettingsType>();
builder.Services.AddSingleton<ServiceSchema>();

//TODO: Quando migrado para a versão V5 do GraphQL, esta dando erro no IDocumentWriter que só funciona na versão GraphQL V4
builder.Services.AddGraphQL().AddSystemTextJson(cfg => { }, serializerSettings => { }).AddDataLoader().AddGraphTypes(typeof(ServiceSchema));


//builder.Services.AddControllers();
builder.Services.AddControllers(cfg => {
    cfg.Filters.Add(typeof(AppExceptionFilterAttribute));
});

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

app.UseGraphiQl("/graphql", "/api/gql");
app.UseGraphQL<ServiceSchema>("/api/gql");

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
