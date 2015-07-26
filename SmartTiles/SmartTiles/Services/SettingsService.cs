namespace SmartTiles.Services
{
    public class SettingsService : ISettingsService
    {
        public string SmartAppUrl
        {
            get
            {
                return "https://graph.api.smartthings.com/api/smartapps/installations/cdfce823-576c-46ee-8ba5-d23dbf89c5f0/";
            }
        }

        public string AccessToken
        {
            get { return "Bearer f4f095ab-ff4d-4408-9373-a5bc2cf4e801"; }
        }
    }
}