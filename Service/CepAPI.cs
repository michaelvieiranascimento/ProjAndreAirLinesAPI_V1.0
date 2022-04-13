using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjAndreAirLinesAPI_V1._0.Model;

namespace ProjAndreAirLinesAPI_V1._0.Service
{
    public class CepAPI
    {
        public static async Task<Endereco> JsonViaCEPAsync(string cep)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var end = JsonConvert.DeserializeObject<Endereco>(responseBody);
                    return end;
                }
            }
            catch (HttpRequestException exception)
            {
                throw exception;
            }
        }
    }
}
