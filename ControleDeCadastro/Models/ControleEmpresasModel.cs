using System.ComponentModel.DataAnnotations;

namespace ControleDeCadastro.Models
{
    public class ControleEmpresasModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome da Empresa.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Cnpj da Empresa.")]
        public string Cnpj { get; set; }
    }
}
