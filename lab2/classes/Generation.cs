using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.classes
{
    class Generation : IComparable<Generation>
    {
        public int N { get; set; }
        public int T { get; set; }
        public double Pk { get; set; }
        public double Pm { get; set; }
        public double Fmax { get; set; }
        public double Favg { get; set; }

        public int CompareTo(Generation other)
        {
            throw new NotImplementedException();
        }
    }
}
