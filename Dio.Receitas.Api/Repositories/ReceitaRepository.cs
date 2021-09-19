using Receitas.Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Receitas.Api.Repositories
{
    public interface IReceitaRepository
    {
        List<Receita> RecuperarTodas();
        Receita RecuperarReceitaPorId(int id);
        void DeletarReceitaPorId(int id);
        void AdicionarReceita(Receita receita);
        void AtualizarReceita(Receita receita);
    }

    public class ReceitaRepository : IReceitaRepository
    {
        public List<Receita> RecuperarTodas()
        {
            return BancoDeDados.Receitas;
        }

        public Receita RecuperarReceitaPorId(int id)
        {
            return BancoDeDados.Receitas.FirstOrDefault(receita => receita.Id == id);
        }

        public void DeletarReceitaPorId(int id)
        {
            BancoDeDados.Receitas.RemoveAll(receita => receita.Id == id);
        }

        public void AdicionarReceita(Receita receita)
        {
            BancoDeDados.Receitas.Add(receita);
        }

        public void AtualizarReceita(Receita receita)
        {
            Receita receitaBancoDados = RecuperarReceitaPorId(receita.Id);

            if (receitaBancoDados != null)
            {
                receitaBancoDados.Ingredientes = receita.Ingredientes;
                receitaBancoDados.ModoPreparo = receita.ModoPreparo;
                receitaBancoDados.Nome = receita.Nome;
                receitaBancoDados.DataCriacao = receita.DataCriacao;
            }
        }
    }
}
