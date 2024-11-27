using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGProject.Model
{
    public class MenuModel
    {
        public int MenuId { get; set; }
        public string Menu_Naam { get; set; }
        public string Menu_Beschrijving { get; set; }
        public string Menu_Type { get; set; }
        public decimal Menu_Prijs { get; set; }
        public bool? Menu_Beschikbaar { get; set; }
    }
}