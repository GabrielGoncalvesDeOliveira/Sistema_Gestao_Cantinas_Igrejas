using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SistemaGestaoCantinasIgrejas.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo id do participante é obrigatório")]
        [Display(Name = "Id Participante: ")]
        public int idParticipante { get; set; }

        [Required(ErrorMessage = "Campo id do produto é obrigatório")]
        [Display(Name = "Id Produto: ")]
        public int idProduto { get; set; }

        [Required(ErrorMessage = "Campo quantidade é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Quantidade: ")]
        public float quantidade { get; set; }

        [Required(ErrorMessage = "Campo valor é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Valor: ")]
        public float valor { get; set; }

        [Display(Name = "Data: ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime data { get; set; }
    }
}
