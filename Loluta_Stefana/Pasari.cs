using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loluta_Stefana
{
    class Pasari : Animal_companie
    {
        string rasa;
        string talie;
        public Pasari(string rasa, int mv)
        {
            this.rasa = rasa;
            this.talie = "-";
            mediu_viata = "aer";
            medie_varsta = mv;
            comportament = "libere";
            hrana = "insecte";
        }

        public string getRasa()
        {
            return rasa;
        }

        public string getTalie()
        {
            return talie;
        }

        public string getMediuViata()
        {
            return mediu_viata;
        }

        public string getMedieVarsta()
        {
            return medie_varsta.ToString();
        }

        public string getComportament()
        {
            return comportament;
        }

        public string getHrana()
        {
            return hrana;
        }
    }
}
