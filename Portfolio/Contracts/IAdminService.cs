using Portfolio.Models;

namespace Portfolio.Contracts
{
    public interface IAdminService
    {
        Task DownloadJsonAsync<T>(string fileName, T data);
        int GetNextId<T>(List<T> items);
    }
}
