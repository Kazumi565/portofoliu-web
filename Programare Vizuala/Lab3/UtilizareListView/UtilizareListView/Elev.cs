using System.Collections.Generic;

namespace UtilizareListView
{
    public class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Nota { get; set; }

        public static List<Elev> CitesteElevi()
        {
            List<Elev> elevi = new List<Elev>();
            elevi.Add(new Elev() { Nume = "Popescu", Prenume = "Daniel", Nota = 9 });
            elevi.Add(new Elev() { Nume = "Danila", Prenume = "Elena", Nota = 10 });
            elevi.Add(new Elev() { Nume = "Pavel", Prenume = "Dan", Nota = 8 });
            elevi.Add(new Elev() { Nume = "Ciornei", Prenume = "Andrei", Nota = 7 });
            return elevi;
        }
    }
}
