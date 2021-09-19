using Receitas.Api.Entities;
using System;
using System.Collections.Generic;

namespace Receitas.Api.Repositories
{
    public class BancoDeDados
    {
        public static List<Receita> Receitas = new List<Receita>
        {
            new Receita
            {
                Nome = "Strogonoff" ,
                Ingredientes = "frango e mostarda",
                ModoPreparo = "picar tudo, misturar e fritar",
                DataCriacao = new DateTime(2021,08,28),
                Id = 1
            },
            new Receita
            {
                Nome = "Bolo de chocolate",
                Ingredientes = "farinha, chocolate, ovos",
                ModoPreparo = "Misturar tudo",
                DataCriacao = new DateTime(2021,01,28),
                Id = 2
            },
            new Receita
            {
                Nome = "Feijão",
                Ingredientes = "feijão, bacon",
                ModoPreparo = "Colocar na pressão 10min",
                DataCriacao = new DateTime(2021,05,25),
                Id = 3
            }
        };
    }
}
