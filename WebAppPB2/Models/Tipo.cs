using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppPB2.Models
{
    public enum Tipo
    {
        [Display(Name = "Bens Duraveis")] BensDuraveis = 1,
        [Display(Name = "Bens Nao Duraveis")] BensNaoDuraveis = 2

    }
}