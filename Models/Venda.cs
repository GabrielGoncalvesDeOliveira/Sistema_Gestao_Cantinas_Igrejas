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

        [Required(ErrorMessage = "Campo do participante é obrigatório")]
        [Display(Name = "Participante: ")]
        public Participante participante { get; set; }
        [Display(Name = "Participante: ")]
        public int participanteid { get; set; }

        [Required(ErrorMessage = "Campo do produto é obrigatório")]
        [Display(Name = "Produto: ")]
        public Produto produto { get; set; }
        [Display(Name = "Produto: ")]
        public int produtoid { get; set; }

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
