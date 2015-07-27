namespace SmartTiles.Services
{
    public class SettingsService : ISettingsService
    {
        public string SmartAppUrl
        {
            get
            {
                return "YOUR BASE URL HERE";
            }
        }

        public string AccessToken
        {
            get { return "Bearer YOUR ACCESS TOKEN HERE"; }
        }
    }
}