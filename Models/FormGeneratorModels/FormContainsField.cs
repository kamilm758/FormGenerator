using FormGenerator.Models.Modele_pomocnicze;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models
{
    public class FormContainsField
    {
        [HiddenInput]
        public int? IdForm { get; set; }
        public IList<IdFieldBool> fields { get; set; } = new List<IdFieldBool>();
    }
}
