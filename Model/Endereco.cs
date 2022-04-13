using Newtonsoft.Json;

namespace ProjAndreAirLinesAPI_V1._0.Model
{
    public class Endereco
    {
        public int Id { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }

        public string Pais { get; set; }

        [JsonProperty("cep")]
        public string CEP { get; set; }

        [JsonProperty("logradouro")]
        public string Rua { get; set; }

        [JsonProperty("uf")]
        public string Estado { get; set; }
        public int Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        public Endereco(string bairro, string cidade, string pais, string cEP, string rua, string estado, int numero, string complemento)
        {
            Bairro = bairro;
            Cidade = cidade;
            Pais = pais;
            CEP = cEP;
            Rua = rua;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
