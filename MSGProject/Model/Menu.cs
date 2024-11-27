using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGProject.Model
{
    public class MenuModel
    {
        public int MenuId { get; set; } // Maps to Menu_Id
        public string MenuNaam { get; set; } // Maps to Menu_Naam
        public string MenuBeschrijving { get; set; } // Maps to Menu_Beschrijving
        public string MenuType { get; set; } // Maps to Menu_Type
        public decimal MenuPrijs { get; set; } // Maps to Menu_Prijs
        public bool? MenuBeschikbaar { get; set; } // Maps to Menu_Beschikbaar
    }
}