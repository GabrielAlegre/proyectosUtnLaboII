using System;

namespace BcPruebaGeometrica
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            area = 0;
            perimetro = 0;
        }

        public float GetArea()
        {
            if (this.area == 0)
            {
                float baseRec = vertice1.GetX() - vertice3.GetX();
                Math.Abs(baseRec);
                float alturaRec = vertice1.GetY() - vertice3.GetY();
                Math.Abs(alturaRec);
                this.area = baseRec * alturaRec;
            }

            return area;
        }

        public float GetPerimetro()
        {

            if (this.perimetro == 0)
            {
                float baseRec = vertice1.GetX() - vertice3.GetX();
                Math.Abs(baseRec);
                float alturaRec = vertice1.GetY() - vertice3.GetY();
                Math.Abs(alturaRec);
                this.perimetro = (baseRec + alturaRec) / 2;
            }
            return perimetro;
        }
    }
}
