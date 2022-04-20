﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCotizadorDesktop
{
    public class Peso
    {
        private static double cotzRespectoDolar;
        private double cantidad;

        static Peso()
        {
            Peso.cotzRespectoDolar = 180;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(double cotz)
        {
            Peso.cotzRespectoDolar = cotz;
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return p == (Peso)d;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
    }
}
