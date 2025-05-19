using System.Text.Json;
using cosmonautica_v2.Dtos;

namespace cosmonautica_v2.Repositoriess;

public interface INoradRepo
{
    public Task<RootNoratDto> GetSatelite(int id);
}

public class NoradRepo : INoradRepo
{
    public async Task<RootNoratDto> GetSatelite(int id)
    {
        try
        {
            var client = new HttpClient();
            var uri =
                $"https://api.n2yo.com/rest/v1/satellite/positions/{id}/19.6577924/-99.2669711,13z/0/2/&apiKey=2F9U7X-7YVQJ4-TEQC99-5HEY";
            Console.WriteLine(uri);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            var a = JsonSerializer.Deserialize<RootNoratDto>(data);
            return a;

        }
        catch (Exception e)
        {
            return null;
        }
    }
}