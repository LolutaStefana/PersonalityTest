using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loluta_Stefana
{
    class Peste : Animal_companie
    {
        string rasa;
        string talie;

        public Peste(string rasa, int mv)
        {
            this.rasa = rasa;
            this.talie = "-";
            mediu_viata = "apa";
            medie_varsta = mv;
            comportament = "inofensivi";
            hrana = "mancare speciala pesti";
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
