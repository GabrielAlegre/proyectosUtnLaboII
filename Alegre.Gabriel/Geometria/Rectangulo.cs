using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;
        private float area;
        private float perimetro;


        public Rectangulo (Punto vertice1, Punto vertice3)
        {
            this.vertice3 = vertice3;
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(),vertice1.GetY());
         
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
          
            area = 0;
            perimetro = 0;
        }

        public float GetArea()
        {
            if(this.area==0)
            {
                float baseRec = vertice1.GetX() - vertice3.GetX();
           
                float alturaRec = vertice1.GetY() - vertice3.GetY();
        
                this.area = Math.Abs(baseRec) * Math.Abs(alturaRec);
            }

            return area;
        }

        public float GetPerimetro()
        {

            if (this.perimetro == 0)
            {
                float baseRec = vertice1.GetX() - vertice3.GetX();
               
                float alturaRec = vertice1.GetY() - vertice3.GetY();
                
                this.perimetro = (Math.Abs(baseRec) + Math.Abs(alturaRec))* 2;
            }
            return perimetro;
        }

    }
}
