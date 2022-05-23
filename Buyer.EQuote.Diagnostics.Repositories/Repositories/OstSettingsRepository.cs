using Buyer.EQuote.Diagnostics.Entities.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Buyer.EQuote.Diagnostics.Repositories.Repositories
{
    public interface IOstSettingsRepository
    {
        Task<Products> GetProductsAsync(string customerSet);
    }

    public class OstSettingsRepository : IOstSettingsRepository
    {
        public async Task<Products> GetProductsAsync(string rcNumber)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:3001/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("products");

                if (response.IsSuccessStatusCode)
                {  
                    var pto = await response.Content.ReadAsStringAsync();
                    var produto = JsonConvert.DeserializeObject<List<Products>>(pto);
                    var prot = produto.FirstOrDefault(a => a.Id.Equals(int.Parse(rcNumber)));
                    return prot;
                }
                return new Products();

            }
        }
    }
}
