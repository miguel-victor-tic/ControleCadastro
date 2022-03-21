using System.ComponentModel.DataAnnotations;

namespace ControleDeCadastro.Models
{
    public class ControleIndexModel
    {
        public ControleAssociadosModel Associado { get; set; }
        public ControleEmpresasModel Empresa { get; set; }
        public ControleAEModel AE { get; set; }
    }
}
