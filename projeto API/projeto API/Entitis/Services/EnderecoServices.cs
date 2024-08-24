using Newtonsoft.Json;
using projeto_API.enditis;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace projeto_API.Entitis.Services
{
    internal class EnderecoServices
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<Endereco> Integracao(int cep)
        {
            var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var jsonString = await response.Content.ReadAsStringAsync();

            var endereco = JsonConvert.DeserializeObject<Endereco>(jsonString);

            if (endereco != null && !string.IsNullOrWhiteSpace(endereco.Logradouro))
            {
                endereco.Verificacao = false; // se o cep nao for verdadeiro nao vai aparecer na tela 
            }
            else
            {
                endereco = new Endereco
                {
                    Verificacao = true // se o cep for verdadeiro vai aparecer na tela 
                };
            }

            return endereco;
        }
    }

}
