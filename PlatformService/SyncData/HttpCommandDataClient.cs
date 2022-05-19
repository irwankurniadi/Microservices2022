using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncData
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommand(PlatformReadDto platform)   
        {
            var httpContent = new StringContent(JsonSerializer.Serialize(platform),Encoding.UTF8,"application/json");

            var response = await _httpClient.PostAsync("http://localhost:7000/api/Platforms", httpContent);
            if(response.IsSuccessStatusCode){
                Console.WriteLine("--> Sync POST kirim Data Platform ke CommandServices Berhasil");
            }else {
                Console.WriteLine("--> Sync POST kirim Data Platform ke CommandServices gagal");
            }
        }
    }
}