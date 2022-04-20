using System;
using System.Text;

namespace BcCreoQueNecesitoUnPrestamo
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta (string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Info cuenta\n");

            sb.AppendLine($"Titular de la cuenta: {GetTitular()}");
            sb.AppendLine($"Cantidad: {cantidad}");

            return sb.ToString();
        }

        public void Ingresar (int monto)
        {
            if(monto>=0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(int monto)
        {
            if (monto >= 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
