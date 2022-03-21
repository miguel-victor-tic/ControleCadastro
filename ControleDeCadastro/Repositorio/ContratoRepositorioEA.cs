using ControleDeCadastro.Data;
using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public class ContratoRepositorioEA : IContratoRepositorioEA
    {
        private readonly BancoContext _bancoContext;
        public ContratoRepositorioEA(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public ControleAEModel Adicionar(ControleAEModel contrato)
        {
            _bancoContext.Associados_has_Empresas.Add(contrato);
            _bancoContext.SaveChanges();

            return contrato;
        }

        public List<ControleAEModel> BuscarTodos()
        {
            return _bancoContext.Associados_has_Empresas.ToList();

        }
    }
}
