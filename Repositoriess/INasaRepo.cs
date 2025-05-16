using System.Text.Json;
using cosmonautica_v2.Dtos;

namespace cosmonautica_v2.Repositoriess;

public interface INasaRepo
{
    
    public Task<RootDto> getAll(DateTime date);
}

public class NasaRepo : INasaRepo
{
    public async Task<RootDto> getAll(DateTime date)
    {

        try
        {

            String url;
            if (date != null)
            {
                url = $"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date={date.ToString("yyyy-MM-dd")}&api_key=mCzFjpdLui6OqWojNVwKYSrCLvAEezawOGXwsvQe";

            }
            else
            {
                url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=mCzFjpdLui6OqWojNVwKYSrCLvAEezawOGXwsvQe";

            }
            Console.WriteLine(url);
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, 
                url);
        
            var response = await client.SendAsync(request);
            var jsonString = await  response.Content.ReadAsStringAsync();
            var a =  JsonSerializer.Deserialize<RootDto>(jsonString);
        
            return a;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
}

