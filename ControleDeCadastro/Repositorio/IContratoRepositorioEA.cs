using ControleDeCadastro.Models;

namespace ControleDeCadastro.Repositorio
{
    public interface IContratoRepositorioEA
    {
        ControleAEModel Adicionar(ControleAEModel contrato);

        List<ControleAEModel> BuscarTodos();
    }
}
