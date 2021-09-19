using Receitas.Api.Entities;
using Receitas.Api.Repositories;
using System.Collections.Generic;

namespace Dio.Receitas.Api.Services
{
    public interface IReceitaService
    {
        List<Receita> RecuperarTodas();
        Receita RecuperarReceitaPorId(int id);
        void DeletarReceitaPorId(int id);
        void AdicionarReceita(Receita receita);
        void AtualizarReceita(Receita receita);
    }

    public class ReceitaService : IReceitaService
    {
        private IReceitaRepository _receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        public void AdicionarReceita(Receita receita)
        {
            _receitaRepository.AdicionarReceita(receita);
        }

        public void AtualizarReceita(Receita receita)
        {
            _receitaRepository.AtualizarReceita(receita);
        }

        public void DeletarReceitaPorId(int id)
        {
            _receitaRepository.DeletarReceitaPorId(id);
        }

        public Receita RecuperarReceitaPorId(int id)
        {
            return _receitaRepository.RecuperarReceitaPorId(id);
        }

        public List<Receita> RecuperarTodas()
        {
            return _receitaRepository.RecuperarTodas();
        }
    }
}
