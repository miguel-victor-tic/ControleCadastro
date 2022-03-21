using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public interface IContratoRepositorioA
    {
        ControleAssociadosModel ListarPorId(int id);
        List<ControleAssociadosModel> BuscarTodos();
        ControleAssociadosModel Adicionar(ControleAssociadosModel contrato);
        ControleAssociadosModel Alterar(ControleAssociadosModel contrato);
        bool Apagar(int id);

    }
}
