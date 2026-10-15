using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroVoti.Program.Classes
{
    public class Voto
    {
        public double Valore { get; private set; }
        public string Tipo { get; private set; }    //es. Scritto, Orale ecc.
        public string Materia { get; private set; }

        public Voto(double valore, string tipo, string materia)
        {
            Valore = valore;
            Tipo = tipo;
            Materia = materia;
        }

        public override string ToString()
        {
            return $"Voto: {Valore}. Tipo: {Tipo}. Materia: {Materia}";
        }
    }
}
