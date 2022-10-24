using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loluta_Stefana
{
    class Caine : Animal_companie
    {
        string rasa;
        string talie;
        public Caine(string rasa, string talie, int mv, string c)
        {
            this.rasa = rasa;
            this.talie = talie;
            mediu_viata = "pamant";
            medie_varsta = mv;
            comportament = c;
            hrana = "mancare speciala canina";

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
