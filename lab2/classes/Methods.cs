using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.classes
{
    class Methods
    {
        public static void WriteToFile(List<List<Individual>> genList)
        {

            List<string> lines = new List<string>();
            for (int i = 0; i < genList.Count; i++)
            {
                int lp = 0;
                lines.Add("Pokolenie " + i + "\n");
                lines.Add("lp | Xreal | Xbit | f(x)");
                foreach (var ind in genList[i])
                {
                    lines.Add($"{lp}. | {Convert.ToDecimal(ind.Xreal).ToString()} | {ind.Xbit} | {ind.Fx}");
                    lp++;
                }
                lines.Add("\n");
            }
           
            StreamWriter file = new StreamWriter("Plik1.txt");

            foreach (string line in lines)
            {
                file.WriteLine(line);
            }

            file.Close();
        }
    }
}
