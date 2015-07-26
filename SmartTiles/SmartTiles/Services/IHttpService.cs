using System.Threading.Tasks;

namespace SmartTiles.Services
{
    public interface IHttpService
    {
        Task<string> Get(string uri);
    }
}