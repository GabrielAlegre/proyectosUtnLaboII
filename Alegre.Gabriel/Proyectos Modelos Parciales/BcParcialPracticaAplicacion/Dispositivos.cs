using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaAplicacion
{
    public static class Dispositivos
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivos()
        {
            Dispositivos.appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion apli)
        {
            bool seInstalo = false;
            if(sistemaOperativo==apli.SistemaOperativo && appsInstaladas+apli)
            {
                seInstalo = true;
            }

            return seInstalo;
        }


        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder($"Sistema operativo: {Dispositivos.sistemaOperativo}\n\n");
            foreach (Aplicacion apli in Dispositivos.appsInstaladas)
            {
                sb.AppendLine(apli.ObtenerInformacionApp());
            }

            return sb.ToString();

        }



    }
}
