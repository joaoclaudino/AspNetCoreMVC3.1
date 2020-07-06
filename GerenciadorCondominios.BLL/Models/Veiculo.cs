using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos Caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos Caracteres")]
        public string Marca { get; set; }
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos Caracteres")]        
        public string Cor { get; set; }

        public string UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}