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
        public static void WriteToFile(List<List<Individual>> genList, int n, int t, double pm, double pk, double d)
        {
            StreamWriter file = new StreamWriter("Plik1.txt");
            for (int i = 0; i < genList.Count; i++)
            {
                int lp = 0;
                file.WriteLine($"Parametry N: {n} T: {t} pm: {pm} pk: {pk} d: {d} \n");
                file.WriteLine("Pokolenie " + i + "\n");
                file.WriteLine("lp | Xreal | Xbit | f(x)");
                foreach (var ind in genList[i])
                {
                    file.WriteLine($"{lp}. | {ind.Xreal} | {ind.Xbit} | {ind.Fx}");
                    lp++;
                }
                file.WriteLine("\n");
            }
            file.Close();
        }

        public static void WriteToFileFx(List<List<Individual>> genList, int n, int t, double pm, double pk, double d)
        {
            StreamWriter file = new StreamWriter("Plik2.txt");
            List<string> lines = new List<string>();
            int lp = 0;
            file.WriteLine($"Parametry N: {n} T: {t} pm: {pm} pk: {pk} d: {d} \n");
            for (int i = 0; i < genList.Count; i++)
            {
                file.WriteLine("Pokolenie " + lp + "\n");
                file.WriteLine("lp   | fmin   | fave   | fmax");
                file.WriteLine($"{i}. | {genList[i].Min(ind => ind.Fx)} | {genList[i].Average(ind => ind.Fx)} | {genList[i].Max(ind => ind.Fx)}");
                lp++;
                file.WriteLine("\n");
            }

            file.Close();
        }
    }
}
