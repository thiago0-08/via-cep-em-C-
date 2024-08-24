using projeto_API.enditis;
using projeto_API.Entitis.Services; 

using System;
using System.Threading.Tasks;

namespace projetoApi
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe seu CEP: ");
            int cep = int.Parse(Console.ReadLine());

            EnderecoServices enderecoServices = new EnderecoServices();

            Endereco enderecoEncontrado = await enderecoServices.Integracao(cep);

            if (!enderecoEncontrado.Verificacao)
            {
                Console.WriteLine("Cep encontrado");

                Console.WriteLine("CEP: " + enderecoEncontrado.Cep);
                Console.WriteLine("Bairro: " + enderecoEncontrado.Bairro);
                Console.WriteLine("Cidade: " + enderecoEncontrado.Localidade);
            }
            else
            {
                Console.WriteLine("Cep não encontrado");
            }
        }
    }
}
