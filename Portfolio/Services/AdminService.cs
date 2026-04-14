using Microsoft.JSInterop;
using Portfolio.Contracts;
using Portfolio.Models;
using System.Text.Json;

namespace Portfolio.Services
{
    public class AdminService : IAdminService
    {
        private readonly IJSRuntime _js;

        public AdminService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task DownloadJsonAsync<T>(string fileName, T data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await _js.InvokeVoidAsync("downloadJson", fileName, json);
        }

        public int GetNextId<T>(List<T> items)
        {
            if (items.Count == 0) return 1;

            var maxId = 0;
            foreach (var item in items)
            {
                var idProperty = typeof(T).GetProperty("Id");
                if (idProperty != null)
                {
                    var id = (int)idProperty.GetValue(item)!;
                    if (id > maxId) maxId = id;
                }
            }
            return maxId + 1;
        }
    }
}
