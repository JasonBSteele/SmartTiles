namespace SmartTiles.Services
{
    public interface ISettingsService
    {
        string SmartAppUrl { get; }
        string AccessToken { get; }
    }
}
