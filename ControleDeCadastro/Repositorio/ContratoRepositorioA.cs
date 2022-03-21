using ControleDeCadastro.Data;
using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public class ContratoRepositorioA : IContratoRepositorioA
    {
        private readonly BancoContext _bancoContext;
        public ContratoRepositorioA(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ControleAssociadosModel ListarPorId(int id)
        {
            return _bancoContext.Associados.FirstOrDefault(x => x.Id == id);
        }

        public List<ControleAssociadosModel> BuscarTodos()
        {
            return _bancoContext.Associados.ToList();
        }

        public ControleAssociadosModel Adicionar(ControleAssociadosModel contrato)
        {
            _bancoContext.Associados.Add(contrato);
            _bancoContext.SaveChanges();
            return contrato;
        }

        public ControleAssociadosModel Alterar(ControleAssociadosModel contrato)
        {
            ControleAssociadosModel ControleDB = ListarPorId(contrato.Id);

            if (ControleDB == null) throw new System.Exception("Houve um erro na atualização do Associado");
            ControleDB.Nome = contrato.Nome;
            ControleDB.Cpf = contrato.Cpf;
            ControleDB.Dt = contrato.Dt;

            _bancoContext.Associados.Update(ControleDB);
            _bancoContext.SaveChanges();

            return ControleDB;
        }

        public bool Apagar(int id)
        {
            ControleAssociadosModel ControleDB = ListarPorId(id);

            if (ControleDB == null) throw new System.Exception("Houve um erro na deleção do Associado");
            _bancoContext.Associados.Remove(ControleDB);
            _bancoContext.SaveChanges();

            return true;

        }
    }
}
