using ControleDeCadastro.Data;
using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public class ContratoRepositorioE : IContratoRepositorioE
    {
        private readonly BancoContext _bancoContext;
        public ContratoRepositorioE(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ControleEmpresasModel ListarPorId(int id)
        {
            return _bancoContext.Empresas.FirstOrDefault(x => x.Id == id);
        }

        public List<ControleEmpresasModel> BuscarTodos()
        {
            return _bancoContext.Empresas.ToList();
        }

        public ControleEmpresasModel Adicionar(ControleEmpresasModel contrato)
        {
            _bancoContext.Empresas.Add(contrato);
            _bancoContext.SaveChanges();
            return contrato;
        }

        public ControleEmpresasModel Alterar(ControleEmpresasModel contrato)
        {

            ControleEmpresasModel ControleDB = ListarPorId(contrato.Id);

            if (ControleDB == null) throw new System.Exception("Houve um erro na atualização da empresa");
            ControleDB.Nome = contrato.Nome;
            ControleDB.Cnpj = contrato.Cnpj;

            _bancoContext.Empresas.Update(ControleDB);
            _bancoContext.SaveChanges();

            return ControleDB;
        }

        public bool Apagar(int id)
        {
            ControleEmpresasModel ControleDB = ListarPorId(id);

            if (ControleDB == null) throw new System.Exception("Houve um erro na deleção da empresa");
            _bancoContext.Empresas.Remove(ControleDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
