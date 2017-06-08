using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows;

namespace ClientWpf
{
    class CreateChart
    {
        private Canvas CanvasChart; // где будем рисовать столбики
        private List<double> Frequencies;//частоты по которым будут расчитываться высоты столбиков
        public CreateChart(Canvas canvas, string frequencies)
        {
            Frequencies = new List<double>();
            CanvasChart = canvas;
            string[] fr = frequencies.Split('|');
            foreach (string f in fr)
            {
                double freq = Convert.ToDouble(f);
                Frequencies.Add(freq);
            }
        }

        public void DrowColumns()
        {
            Random rand = new Random();
            double WidthColumn = CanvasChart.Width / 26;
            int A = (int)'a';
            int Z = (int)'z';
            int J = 0;
            
                for (int i = A; i < Z + 1; i++)
                {
                    Rectangle rec = new Rectangle();
                    TextBlock text = new TextBlock();
                    rec.Width = WidthColumn;
                    text.Width = WidthColumn;
                    text.TextAlignment = System.Windows.TextAlignment.Center;
                    text.FontSize = 18;
                    text.FontWeight = FontWeights.Bold;
                    text.Height = 20;
                    rec.Height = GetHeight(Frequencies[J]);
                    SolidColorBrush color = new SolidColorBrush(Color.FromArgb(255, (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));
                    rec.Fill = color;
                    Canvas.SetTop(text, CanvasChart.Height - text.Height);
                    Canvas.SetLeft(text, J * WidthColumn);
                    Canvas.SetTop(rec, CanvasChart.Height - text.Height - rec.Height);
                    Canvas.SetLeft(rec, J * WidthColumn);
                    text.Text = ((char)i).ToString();
                    rec.ToolTip = Frequencies[J];
                    CanvasChart.Children.Add(rec);//рисуем стольбик
                    CanvasChart.Children.Add(text);//рисуем подпись
                    J++;
                }
           
        }
        private double GetHeight(double freq) // высота столбика как частота умноженное на высоту канваса
        {
                return freq * (CanvasChart.Height - 20);
            
        }
        
    }
}
