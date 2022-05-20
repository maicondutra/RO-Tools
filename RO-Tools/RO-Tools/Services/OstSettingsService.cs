using RO_Tools.Models;
using RO_Tools.Repository;

namespace RO_Tools.Services
{
    public class OstSettingsService
    {
        private readonly OstSettingsRepository _ostSettingsRepository;
        public OstSettingsService(OstSettingsRepository repository)
        {
            _ostSettingsRepository = repository;
        }

        public OstSettings OstSettingsForRC(string customerSet) => _ostSettingsRepository.OstSettingsForRC(customerSet);
        public OstSettings OstSettingsForIDRC(Guid id) => _ostSettingsRepository.OstSettingsForIDRC(id);

        public List<OstSettings> OstSettingsAll() => _ostSettingsRepository.OstSettingsAll();
    }
}
