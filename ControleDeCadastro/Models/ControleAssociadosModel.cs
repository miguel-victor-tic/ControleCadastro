using System.ComponentModel.DataAnnotations;

namespace ControleDeCadastro.Models
{
    public class ControleAssociadosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do Associado.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Cpf do Associado.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Informe a data de nascimento do Associado.")]
        public string Dt { get; set; }
    }
}
