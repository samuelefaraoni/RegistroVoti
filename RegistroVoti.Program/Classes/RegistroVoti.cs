using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroVoti.Program.Classes
{
    public class RegistroVoti
    {
        public string Studente { get; private set; }
        public List<Voto> Voti { get; private set; }

        public RegistroVoti(string studente)
        {
            Studente = studente;
            Voti = new List<Voto>();
        }

        public void AggiungiVoto(Voto voto)
        {
            Voti.Add(voto);
        }

        public string ElencoVoti()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Voto voto in Voti)
            {
                sb.Append(voto.ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public string ElencoVotiSufficienti()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Voto voto in Voti)
            {
                if(voto.Valore >= 6.0)
                {
                    sb.Append(voto.ToString());
                    sb.Append("\n");
                }          
            }

            return sb.ToString();
        }

        public string ElencoVotiInsufficienti()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Voto voto in Voti)
            {
                if (voto.Valore < 6.0)
                {
                    sb.Append(voto.ToString());
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }

        public double MediaVoti()
        {
            double sommaVoti = 0.0;
            foreach (Voto voto in Voti)
            {
                sommaVoti += voto.Valore;
            }

            return sommaVoti / Voti.Count();
        }
    }
}
