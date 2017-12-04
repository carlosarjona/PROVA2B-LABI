using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppPB2.Models
{
    public class Patrimonio
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public string NumeroDeTombo { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Descricao { get; set; }

        public Tipo Tipo { get; set; }

    }
}