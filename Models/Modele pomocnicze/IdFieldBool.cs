using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormGenerator.Models.Modele_pomocnicze
{
    public class IdFieldBool
    {
        public int IdField { get; set; }
        public string NameField { get; set; }
        public bool? ContainsField { get; set; }
    }
}
//Model pomocniczy służący do przypisywania pól do formularza. jeśli "ContainsField" jest true, wtedy
//pole o "IdField" jest przypisane do fromularza. Model ten jest wykorzystywany w klasie "FormContainsField".