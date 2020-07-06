using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos Caracteres")]    
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Telefone { get; set; }
        public string Foto { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos Caracteres")]    
        [EmailAddress(ErrorMessage="Email Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos Caracteres")]       
        [DataType(DataType.Password)]    
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos Caracteres")]       
        [DataType(DataType.Password)]           
        [Display(Name="Confirme Sua Senha")]
        [Compare("Senha",ErrorMessage="As senhas não conferem")]
        public string SenhaConfirmada { get; set; }

    }
}