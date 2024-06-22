using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    public class StudentClass
    {
        public string Indeks {  get; set; }
        public string Ime { get; set; }
        public List<UplataClass> uplataClasses { get; set; }

        public StudentClass(string indeks, string ime)
        {
            Indeks = indeks;
            Ime = ime;
            uplataClasses = new List<UplataClass>();
        }

       public void dodadiUplata(UplataClass uplata)
        {
            uplataClasses.Add(uplata);
        }
        public override string ToString()
        {
            return $"{Indeks} {Ime}";
        }

        public string Details()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(ToString()).Append("\n");
            for (int i = 0; i < uplataClasses.Count; i++)
            {
                sb.Append(i + 1).Append(uplataClasses[i].ToString()).Append("\n");

            }
            return sb.ToString(); 

        }
    }


   


}
