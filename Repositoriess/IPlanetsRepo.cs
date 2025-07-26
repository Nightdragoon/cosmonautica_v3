using System.Text.Json;
using cosmonautica_v2.Dtos;

namespace cosmonautica_v2.Repositoriess;

public interface IPlanetsRepo
{
    public Task<List<Body>> bodies();

}

public class PlanetsRepo : IPlanetsRepo
{
    /// <summary>
    /// nos permite obtener todos los planetas conocidos por el ser humano dentro de nuestro sistema solar
    /// devuelve una lista de planetas
    /// </summary>
    /// <returns></returns>
    public async Task<List<Body>> bodies()
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.le-systeme-solaire.net/rest/bodies");
            var response = await client.SendAsync(request);
            var data = await response.Content.ReadAsStringAsync();
            var allPlanets = JsonSerializer.Deserialize<PlanetaryBodiesDto>(data);
            return allPlanets.bodies;

        }
        catch (Exception ex)
        {
            Console.WriteLine("error");
            return null;
        }
    }
}