using System;

namespace Receitas.Api.Entities
{
    public class Receita
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }

        public string Nome { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
    }
}
