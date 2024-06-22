using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    public class UplataClass
    {
        public decimal Uplati {  get; set; }

        public UplataClass(decimal uplati)
        {
            Uplati = uplati;
        }

        public override string ToString()
        {
            return $"Uplati:{Uplati} Provizija:{Math.Round(Uplati * 0.114m)} Vkupno:{Uplati + Math.Round(Uplati * 0.114m)}";
        }
    }
}
