using System.ComponentModel.DataAnnotations;

namespace ControleDeCadastro.Models
{
    public class ControleAEModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o id do associado.")]
        public int IdAssociado { get; set; }
        [Required(ErrorMessage = "Informe o id da empresa.")]
        public int IdEmpresa { get; set; }
    }
}
