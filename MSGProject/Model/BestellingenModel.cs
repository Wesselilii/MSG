using System;
using System.Collections.Generic;
using System.Configuration;

namespace MSGProject.Model
{
    public class BestellingenModel
    {
        public int Bestelling_Id { get; set; }
        public int Gebruiker_Id {get; set; }
        public string Gebruiker_Voornaam { get; set; }
        public string Gebruiker_Achternaam { get; set; }
        public int Menu_Id { get; set; }
        public DateTime Bestelling_Datum { get; set; }
        public string Bestelling_Status { get; set; }
    }
}