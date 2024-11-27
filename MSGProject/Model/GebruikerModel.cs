using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGProject.Model
{
    public class GebruikerModel
    {
        public int Gebruiker_Id { get; set; }
        public string Gebruiker_Voornaam { get; set; }
        public string Gebruiker_Achternaam { get; set; }
        public string Gebruiker_Email { get; set; }
        public string Gebruiker_Wachtwoord { get; set; }
        public string Gebruiker_Rol { get; set; }
    }
}
