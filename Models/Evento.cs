using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGestaoCantinasIgrejas.Models
{
    [Table("Evento")]
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [Display(Name = "Descrição: ")]
        public string descricao { get; set; }

        [Display(Name = "Igreja: ")]
        public Igreja igreja { get; set; }
        [Display(Name = "Igreja: ")]
        public int igrejaid { get; set; }

        [Required(ErrorMessage = "Campo endereço é obrigatório")]
        [Display(Name = "Endereço: ")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo horario é obrigatório")]
        [Display(Name = "Horario: ")]
        public string horario { get; set; }
    }
}
