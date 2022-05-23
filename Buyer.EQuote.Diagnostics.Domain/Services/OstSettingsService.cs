using Buyer.EQuote.Diagnostics.Entities.Models;
using Buyer.EQuote.Diagnostics.Repositories.Repositories;

namespace Buyer.EQuote.Diagnostics.Domain.Services
{
    public interface IOstSettingsService
    {
        Task<Products> OstSettingsForRCAsync(string customerSet);
    }

    public class OstSettingsService : IOstSettingsService
    {
        private readonly IOstSettingsRepository _ostSettingsRepository;

        public OstSettingsService(IOstSettingsRepository ostSettingsRepository)
        {
            _ostSettingsRepository = ostSettingsRepository;
        }

        public async Task<Products> OstSettingsForRCAsync(string customerSet)
        {
            return await _ostSettingsRepository.GetProductsAsync(customerSet);
        }
    }
}
