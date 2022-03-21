using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public interface IContratoRepositorioE
    {
        ControleEmpresasModel ListarPorId(int id);
        List<ControleEmpresasModel> BuscarTodos();
        ControleEmpresasModel Adicionar(ControleEmpresasModel contrato);
        ControleEmpresasModel Alterar(ControleEmpresasModel contrato);
        bool Apagar(int id);

    }
}
