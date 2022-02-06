using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp2
{
    internal class Elipse
    {
        int x1;
        int y1;
        int x2;
        int y2;

        public Elipse(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public bool isCirle()
        {
            return x2 == y2;
        }
        public void Draw(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse { Width = x2, Height = y2, Fill = Brushes.Green };
            Canvas.SetTop(ellipse, y1);
            Canvas.SetLeft(ellipse, x1);
            canvas.Children.Add(ellipse);
        }
        public string Info()
        {
            return $"Эллипс с координатами: x1 - {x1}, y1 - {y1}, x2 - {x2}, y2 - {y2}";
        }
    }
}
