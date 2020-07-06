using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.BLL.Models
{
    public class Aluguel
    {
        public int AluguelId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0,int.MaxValue,ErrorMessage = "Valor Inválido")]
        public decimal Valor { get; set; }

        public int MesId { get; set; }

        public virtual Mes Mes { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(2020,2030,ErrorMessage = "Valor Inválido")]
        public int Ano { get; set; }

        public virtual ICollection<Pagamento> Pagamentos  { get; set; }
    }
}