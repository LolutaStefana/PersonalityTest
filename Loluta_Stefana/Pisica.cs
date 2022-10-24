using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loluta_Stefana
{
    class Pisica : Animal_companie
    {
        string rasa;
        string talie;
        public Pisica(string rasa, int mv, string c)
        {
            this.rasa = rasa;
            this.talie = "-";
            mediu_viata = "pamant";
            medie_varsta = mv;
            comportament = c;
            hrana = "mancare pentru pisici";
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
