using System;

namespace projeto_API.enditis
{
    internal class Endereco
    {
        public string Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Localidade { get; set; }
        public string? Uf { get; set; }
        public int Ibge { get; set; }
        public int Gia { get; set; }
        public int Ddd { get; set; }
        public int Siafi { get; set; }

        public bool Verificacao { get; set; } = false; // verifica se o cep foi encontrado 
    }
}
