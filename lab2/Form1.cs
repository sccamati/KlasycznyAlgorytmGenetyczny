using lab2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class NBox : Form
    {
        public NBox()
        {
            InitializeComponent();
            wykres.Visible = false;
            zad2Panel.Visible = false;
        }

        List<List<Individual>> generationList = new List<List<Individual>>();
        List<Individual> individuals;
        List<Individual> individualsSelect;

        private void ObliczButton_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            int n = 0;
            double d = 0;
            double precision = 1;
            double pk = 0.0;
            double pm = 0.0;
            int t = 0;
            Individual elite = null;



            a = Convert.ToDouble(ABox.Text);
            b = Convert.ToDouble(BBox.Text);
            n = Convert.ToInt32(CountBox.Text);
            d = Convert.ToInt32(DBox.Text);
            pk = Convert.ToDouble(pkBox.Text);
            pm = Convert.ToDouble(pmBox.Text);
            t = Convert.ToInt32(tBox.Text);

            if (a > b)
            {
                throw new Exception();
            }

            double pom = d;
            int round = 0;

            while (pom > 1)
            {
                precision /= 10;
                round++;
                pom *= 0.1;
            }

            int l = (int)Math.Ceiling(Math.Log(((b - a) * d) + 1, 2));
            BitCountBox.Text = l.ToString();
            individuals = new List<Individual>();
            individualsSelect = new List<Individual>();
            Random generator = new Random();

            for (int i = 0; i < n; i++)
            {

                Individual individual = new Individual
                {
                    Id = i,
                    Xreal = generator.Next((int)(a * d), (int)(b * d)) / d
                };

                individual.Xint = (int)Math.Round(((1 / (b - a)) * (individual.Xreal - a) * (Math.Pow(2, l) - 1)));

                string bin = Convert.ToString(individual.Xint, 2);
                for (int k = bin.Length; k < l; k++)
                {
                    bin = "0" + bin;
                }
                individual.Xbit = bin;
                double x = individual.Xreal;
                individual.Fx = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));

                individuals.Add(individual);
            }

            elite = individuals.Find(i => i.Fx == individuals.Max(ind => ind.Fx)).Clone();

            generationList.Add(individuals);

            //petla do pokolen
            for (int j = 0; j < t; j++)
            {

                var fmin = individuals.Min(i => i.Fx);

                foreach (var i in individuals)
                {
                    i.Gx = i.Fx - fmin + precision;
                }

                var SumGx = individuals.Sum(i => i.Gx);

                foreach (var i in individuals)
                {
                    i.Px = i.Gx / SumGx;
                }


                int index = 0;
                foreach (var ind in individuals)
                {
                    for (int i = 0; i <= index; i++)
                    {
                        ind.Qx += individuals[i].Px;
                    }
                    index++;
                    ind.R = generator.NextDouble();
                }




                int it = 0;
                foreach (var i in individuals)
                {
                    it++;
                    foreach (var ind in individuals)
                    {

                        if (i.R <= ind.Qx)
                        {
                            individualsSelect.Add(ind.Clone());
                            break;
                        }
                    }
                }

                foreach (var i in individualsSelect)
                {
                    if (generator.NextDouble() <= pk)
                    {
                        i.Parent = i.Xbit;
                    }
                    else
                    {
                        i.Parent = "--";
                        i.Ppk = i.Xbit;
                    }
                }


                List<Individual> parents = new List<Individual>();

                foreach (var i in individualsSelect)
                {
                    if (!i.Parent.Equals("--"))
                    {
                        parents.Add(i);
                    }

                }

                if (parents.Count > 1)
                {
                    for (int i = 0; i < parents.Count - 1; i = i + 2)
                    {
                        int pc = parents[i].Pc = parents[i + 1].Pc = generator.Next(1, l);
                        parents[i].Ppk = parents[i].ChildXbin = parents[i].Parent.Substring(0, pc) + parents[i + 1].Parent.Substring(pc, l - pc);
                        parents[i + 1].Ppk = parents[i + 1].ChildXbin = parents[i + 1].Parent.Substring(0, pc) + parents[i].Parent.Substring(pc, l - pc);
                    }
                    if (parents.Count % 2 != 0)
                    {
                        int pc = parents[parents.Count - 1].Pc = generator.Next(1, l);
                        parents[parents.Count - 1].Ppk = parents[parents.Count - 1].ChildXbin = String.Concat(parents[parents.Count - 1].Parent.Substring(0, pc) + parents[0].Parent.Substring(pc, l - pc));
                    }
                }
                else
                {
                    foreach (var i in parents)
                    {
                        i.Ppk = i.Parent;
                    }

                }

                StringBuilder strBuilder = new StringBuilder();
                foreach (var ind in individualsSelect)
                {

                    ind.Pm = ind.Ppk;
                    strBuilder = new StringBuilder(ind.Pm); ;
                    for (int i = 0; i < ind.Pm.Length; i++)
                    {
                        if (generator.NextDouble() <= pm)
                        {
                            strBuilder[i] = strBuilder[i].Equals('0') ? '1' : '0';
                            ind.Zg += i + 1 + ",";
                        }

                    }
                    ind.Pm = strBuilder.ToString();
                    ind.Xbit = ind.Pm;
                    ind.Xint = int.Parse(Convert.ToString(Convert.ToInt32(ind.Pm + "", 2), 10));
                    ind.Xreal = Math.Round(a + ((b - a) * ind.Xint) / (Math.Pow(2, l) - 1), round);
                    double x = ind.Xreal;
                    ind.Fx = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));
                }

                if (individualsSelect.All(ind => ind.Fx != elite.Fx))
                {
                    int randomId = generator.Next(0, individualsSelect.Count);
                    Individual randomInd = individualsSelect[randomId];
                    if (randomInd.Fx < elite.Fx)
                    {
                        individualsSelect[randomId] = elite.Clone();
                    }
                }
                double maxFx = individualsSelect.Max(ind => ind.Fx);
                if (maxFx > elite.Fx)
                {
                    elite = individualsSelect.Find(i => i.Fx == maxFx).Clone();
                }

                List<Individual> genToAdd = individualsSelect.ConvertAll(ind => ind.Clone());
                generationList.Add(genToAdd);
                individuals = individualsSelect.ConvertAll(ind => ind.Clone());
                individualsSelect.Clear();
            }

            List<Individual> individualsToPersent = new List<Individual>();

            int endIndex = 0;
            foreach (var ind in individuals)
            {

                if (!individualsToPersent.Any(i => i.Fx == ind.Fx))
                {
                    double indCount = individuals.Where(i => i.Fx == ind.Fx).Count();
                    double persent = (indCount / individuals.Count) * 100;
                    ind.Persent = persent + "%";
                    ind.Id = endIndex;
                    individualsToPersent.Add(ind);
                    endIndex++;
                }
            }


            Methods.WriteToFile(generationList);
            Methods.WriteToFileFx(generationList);
            MakeChart(generationList);

            var bindingList = new BindingList<Individual>(individualsToPersent);
            var source = new BindingSource(bindingList, null);
            TableView.DataSource = source;
            generationList.Clear();
            individuals.Clear();
            individualsSelect.Clear();


        }

        private void MakeChart(List<List<Individual>> genList)
        {
            var chartMaker = chart.ChartAreas[0];

            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = genList.Count;
            chartMaker.AxisY.Interval = 0.1;
            if (genList.Count > 999)
            {
                chartMaker.AxisX.Interval = 100;
            }
            else if (genList.Count > 500)
            {
                chartMaker.AxisX.Interval = 50;
            }
            else if (genList.Count > 100)
            {
                chartMaker.AxisX.Interval = 10;
            }
            else if (genList.Count < 100)
            {
                chartMaker.AxisX.Interval = 1;
            }

            chart.Series[0].IsVisibleInLegend = false;

            if (chart.Series.Count == 1)
            {
                chart.Series.Add("fmax");
                chart.Series.Add("fave");
                chart.Series.Add("fmin");
            }
            else
            {
                chart.Series["fmax"].Points.Clear();
                chart.Series["fmin"].Points.Clear();
                chart.Series["fave"].Points.Clear();
            }

            chart.Series["fmax"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["fmax"].Color = Color.Green;
            chart.Series["fave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["fave"].Color = Color.Red;
            chart.Series["fmin"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["fmin"].Color = Color.Blue;


            for (int i = 0; i < genList.Count; i++)
            {
                chart.Series["fmax"].Points.AddXY(i, genList[i].Max(ind => ind.Fx));
                chart.Series["fmin"].Points.AddXY(i, genList[i].Min(ind => ind.Fx));
                chart.Series["fave"].Points.AddXY(i, genList[i].Average(ind => ind.Fx));
            }


        }

        private void ABox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void BBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void CountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '1') && DBox.Text == "")
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '0') && DBox.Text != "")
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BitCountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void pmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            if (wykres.Visible)
            {
                wykres.Visible = false;
            }
            else
            {
                wykres.Visible = true;
            }

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void zad2_Click(object sender, EventArgs e)
        {
            zad2Panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zad2Panel.Visible = false;
        }

        private void generateZad2_Click(object sender, EventArgs e)
        {
            List<List<Individual>> generationList = new List<List<Individual>>();
            List<Individual> individuals;
            List<Individual> individualsSelect;
            List<double> pkTest = new List<double>
        {
            0.5, 0.55, 0.60, 0.65, 0.70, 0.75, 0.80, 0.85, 0.90
        };
            List<double> pmTest = new List<double>
        {
            0.0001, 0.0005, 0.0015, 0.005, 0.002, 0.0025, 0.003, 0.0035, 0.004, 0.01
        };
            List<Generation> listTest = new List<Generation>();

            double a = 0;
            double b = 0;
            int n = 0;
            double d = 0;
            double precision = 1;
            double pk = 0.0;
            double pm = 0.0;
            int t = 0;
            Individual elite = null;


            
            a = Convert.ToDouble(ABox.Text);
            b = Convert.ToDouble(BBox.Text);
            d = Convert.ToInt32(DBox.Text);


            if (a > b)
            {
                throw new Exception();
            }

            double pom = d;
            int round = 0;

            while (pom > 1)
            {
                precision /= 10;
                round++;
                pom *= 0.1;
            }
            int l = (int)Math.Ceiling(Math.Log(((b - a) * d) + 1, 2));
            BitCountBox.Text = l.ToString();
            individuals = new List<Individual>();
            individualsSelect = new List<Individual>();
            Random generator = new Random();

            for (n = 30; n <= 80; n += 5)
            {
                
                foreach (var pmItem in pmTest)
                {
                    pm = pmItem;

                    foreach (var pkItem in pkTest)
                    {
                        pk = pkItem;

                        for (t = 50; t <= 150; t += 10)
                        {

                            for (int i = 0; i < n; i++)
                            {

                                Individual individual = new Individual
                                {
                                    Id = i,
                                    Xreal = generator.Next((int)(a * d), (int)(b * d)) / d
                                };

                                individual.Xint = (int)Math.Round(((1 / (b - a)) * (individual.Xreal - a) * (Math.Pow(2, l) - 1)));

                                string bin = Convert.ToString(individual.Xint, 2);
                                for (int k = bin.Length; k < l; k++)
                                {
                                    bin = "0" + bin;
                                }
                                individual.Xbit = bin;
                                double x = individual.Xreal;
                                individual.Fx = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));

                                individuals.Add(individual);
                            }

                            elite = individuals.Find(i => i.Fx == individuals.Max(ind => ind.Fx)).Clone();

                            generationList.Add(individuals);

                            //petla do pokolen
                            for (int j = 0; j < t; j++)
                            {

                                var fmin = individuals.Min(i => i.Fx);

                                foreach (var i in individuals)
                                {
                                    i.Gx = i.Fx - fmin + precision;
                                }

                                var SumGx = individuals.Sum(i => i.Gx);

                                foreach (var i in individuals)
                                {
                                    i.Px = i.Gx / SumGx;
                                }


                                int index = 0;
                                foreach (var ind in individuals)
                                {
                                    for (int i = 0; i <= index; i++)
                                    {
                                        ind.Qx += individuals[i].Px;
                                    }
                                    index++;
                                    ind.R = generator.NextDouble();
                                }




                                int it = 0;
                                foreach (var i in individuals)
                                {
                                    it++;
                                    foreach (var ind in individuals)
                                    {

                                        if (i.R <= ind.Qx)
                                        {
                                            individualsSelect.Add(ind.Clone());
                                            break;
                                        }
                                    }
                                }

                                foreach (var i in individualsSelect)
                                {
                                    if (generator.NextDouble() <= pk)
                                    {
                                        i.Parent = i.Xbit;
                                    }
                                    else
                                    {
                                        i.Parent = "--";
                                        i.Ppk = i.Xbit;
                                    }
                                }


                                List<Individual> parents = new List<Individual>();

                                foreach (var i in individualsSelect)
                                {
                                    if (!i.Parent.Equals("--"))
                                    {
                                        parents.Add(i);
                                    }

                                }

                                if (parents.Count > 1)
                                {
                                    for (int i = 0; i < parents.Count - 1; i = i + 2)
                                    {
                                        int pc = parents[i].Pc = parents[i + 1].Pc = generator.Next(1, l);
                                        parents[i].Ppk = parents[i].ChildXbin = parents[i].Parent.Substring(0, pc) + parents[i + 1].Parent.Substring(pc, l - pc);
                                        parents[i + 1].Ppk = parents[i + 1].ChildXbin = parents[i + 1].Parent.Substring(0, pc) + parents[i].Parent.Substring(pc, l - pc);
                                    }
                                    if (parents.Count % 2 != 0)
                                    {
                                        int pc = parents[parents.Count - 1].Pc = generator.Next(1, l);
                                        parents[parents.Count - 1].Ppk = parents[parents.Count - 1].ChildXbin = String.Concat(parents[parents.Count - 1].Parent.Substring(0, pc) + parents[0].Parent.Substring(pc, l - pc));
                                    }
                                }
                                else
                                {
                                    foreach (var i in parents)
                                    {
                                        i.Ppk = i.Parent;
                                    }

                                }

                                StringBuilder strBuilder = new StringBuilder();
                                foreach (var ind in individualsSelect)
                                {

                                    ind.Pm = ind.Ppk;
                                    strBuilder = new StringBuilder(ind.Pm); ;
                                    for (int i = 0; i < ind.Pm.Length; i++)
                                    {
                                        if (generator.NextDouble() <= pm)
                                        {
                                            strBuilder[i] = strBuilder[i].Equals('0') ? '1' : '0';
                                            ind.Zg += i + 1 + ",";
                                        }

                                    }
                                    ind.Pm = strBuilder.ToString();
                                    ind.Xbit = ind.Pm;
                                    ind.Xint = int.Parse(Convert.ToString(Convert.ToInt32(ind.Pm + "", 2), 10));
                                    ind.Xreal = Math.Round(a + ((b - a) * ind.Xint) / (Math.Pow(2, l) - 1), round);
                                    double x = ind.Xreal;
                                    ind.Fx = x % 1 * (Math.Cos(20 * Math.PI * x) - Math.Sin(x));
                                }

                                if (individualsSelect.All(ind => ind.Fx != elite.Fx))
                                {
                                    int randomId = generator.Next(0, individualsSelect.Count);
                                    Individual randomInd = individualsSelect[randomId];
                                    if (randomInd.Fx < elite.Fx)
                                    {
                                        individualsSelect[randomId] = elite.Clone();
                                    }
                                }
                                double maxFx = individualsSelect.Max(ind => ind.Fx);
                                if (maxFx > elite.Fx)
                                {
                                    elite = individualsSelect.Find(i => i.Fx == maxFx).Clone();
                                }

                                List<Individual> genToAdd = individualsSelect.ConvertAll(ind => ind.Clone());
                                generationList.Add(genToAdd);
                                individuals = individualsSelect.ConvertAll(ind => ind.Clone());
                                individualsSelect.Clear();
                            }

                            Generation gen = new Generation
                            {
                                T = t,
                                N = n,
                                Pk = pk,
                                Pm = pm,
                                Fmax = elite.Fx
                            };

                            List<double> AvgList = new List<double>();
                            foreach (var genList in generationList)
                            {
                                AvgList.Add(genList.Average(ind => ind.Fx));
                            }

                            gen.Favg = AvgList.Average(avg => avg);
                            

                            listTest.Add(gen);
                            generationList.Clear();
                            individuals.Clear();
                            individualsSelect.Clear();

                        }
                    }
                }
            }
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.Pk.CompareTo(x.Pk);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.Pm.CompareTo(x.Pm);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.T.CompareTo(x.T);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.N.CompareTo(x.N);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.N.CompareTo(x.N);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.Fmax.CompareTo(x.Fmax);
            });
            listTest.Sort(delegate (Generation x, Generation y) {
                return y.Favg.CompareTo(x.Favg);
            });
            var bindingList = new BindingList<Generation>(listTest);
            var source = new BindingSource(bindingList, null);
            zad2Table.DataSource = source;

        }
    }
}
