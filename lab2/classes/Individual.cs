using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.classes
{
    class Individual
    {
        public int Id { get; set; }
        public double Xreal { get; set; }
        public int Xint { get; set; }
        public string Xbit { get; set; }
        public double Fx { get; set; }
        public double Gx { get; set; }
        public double Px { get; set; }
        public double Qx { get; set; }
        public double R { get; set; }
        public string Parent { get; set; }
        public int Pc { get; set; }
        public string ChildXbin { get; set; }
        public string Ppk { get; set; }
        public string Zg { get; set; }
        public string Pm { get; set; }
        public string Persent { get; set; }

        public Individual Clone()
        {
           return (Individual) this.MemberwiseClone();
        }
    }
}
