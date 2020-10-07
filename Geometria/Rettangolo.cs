using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

    public class Rettangolo
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public Rettangolo(double x, double y, double w, double h)
        {
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
        }
        public double CalcolaPerimetro()
        {
            return (width * 2) + (height * 2);
        }
        public double CalcolaArea()
        {
            return width * height;
        }
        public bool Contiene(Rettangolo r)
        {
            if (r.x >= this.x && r.width + r.x <= width + x)
            {
                if (r.y >= this.y && r.height + r.y <= height + y)
                    return true;
                return false;
            }
            else
                return false;
        }

    }

}
