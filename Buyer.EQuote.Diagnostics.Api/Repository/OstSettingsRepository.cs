using Newtonsoft.Json;
using RO_Tools.Models;
using System.Net.Http.Headers;

namespace RO_Tools.Repository
{
    public class OstSettingsRepository
    {
        private readonly List<OstSettings> _OstSettings;
        public OstSettingsRepository()
        {
            _OstSettings = new List<OstSettings>();

            _OstSettings.Add(new OstSettings
            {
                Id = Guid.NewGuid(),
                BuyerTitle = "Authorized Buyer",
                EQuotes = true,
                Expiration = 15,
                OfflineQuotes = false,
                ProductValidation = true,
                Recommendations = true,
                Repricing = true,
                Required = "BillingAddress",
                SaveEQuotes = "ShippingAddress",
                SaveTax = true,
                SendEQuotes = false,
                Upsell = true
            });
        }

        public async Task<Products> RunAsync(string rc)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3001/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("products");
                if (response.IsSuccessStatusCode)
                {  //GET
                    var pto = await response.Content.ReadAsStringAsync();
                    var produto = JsonConvert.DeserializeObject<List<Products>>(pto);
                    var prot = produto.FirstOrDefault(a => a.id.Equals(int.Parse(rc)));
                    return prot;
                }
                return new Products();
                ////POST
                //var cha = new Produto() { Nome = "Chá Verde", Preco = 1.50M, Categoria = "Bebidas" };
                //response = await client.PostAsJsonAsync("api/produtos", cha);
                //Console.WriteLine("Produto cha verde incluído. Tecle algo para atualizar o preço do produto.");
                //Console.ReadKey();
                //if (response.IsSuccessStatusCode)
                //{   //PUT
                //    Uri chaUrl = response.Headers.Location;
                //    cha.Preco = 2.55M;   // atualiza o preco do produto
                //    response = await client.PutAsJsonAsync(chaUrl, cha);
                //    Console.WriteLine("Produto preço do atualizado. Tecle algo para excluir o produto");
                //    Console.ReadKey();
                //    //DELETE
                //    response = await client.DeleteAsync(chaUrl);
                //    Console.WriteLine("Produto deletado");
                //    Console.ReadKey();
                //}
            }
        }

        internal List<OstSettings> OstSettingsAll() => this._OstSettings;

        internal async Task<Products> OstSettingsForRCAsync(string customerSet)
        {
            return await this.RunAsync(customerSet);
            //throw new NotImplementedException();
        }

        internal OstSettings OstSettingsForIDRC(Guid id)
        {
            var stt = _OstSettings.Where(osts => osts.Id.Equals(id)).FirstOrDefault();
            return stt != null ? stt : null;
        }
    }
}
