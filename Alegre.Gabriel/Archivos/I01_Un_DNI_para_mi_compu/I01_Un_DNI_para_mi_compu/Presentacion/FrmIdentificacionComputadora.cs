using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, EventArgs e)
        {
            this.Text = $"Cumpu de {Environment.UserName}";
            this.ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            lblNombreMaquina.Text = $"Nombre de la maquina: {Environment.MachineName}";
            this.ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores logicos";
            lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            this.ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if(OperatingSystem.IsMacOS())
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;

            }
            else if(OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;

            }
        }
        private void ConfigurarArquitectura()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalEnBytes = 0;
            long espacioDisponibleEnBytes = 0;
    
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalEnBytes += drive.TotalSize;
                espacioDisponibleEnBytes += drive.AvailableFreeSpace;
            }

            //lblEspacioTotal.Text = $"Espacio total: {Math.Round(espacioTotalEnBytes * 9.31 * Math.Pow(10, -10))} Gigabytes";
            //lblEspacioDisponible.Text = $"Espacio disponible: {Math.Round(espacioDisponibleEnBytes * 9.31 * Math.Pow(10, -10))} Gigabytes";
            // O
            
            //1 Byte = 9.31×10-10 Gigabytes

            //1 Gygabyte = 1073741824 Bytes
             
            lblEspacioTotal.Text = $"Espacio total: {Math.Round((Decimal)(espacioTotalEnBytes / 1073741824 ))} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {Math.Round((Decimal)(espacioDisponibleEnBytes / 1073741824))} Gigabytes";
        }









































        /*
        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalEnBytes = 0;
            long espacioDisponibleEnBytes = 0;
            double espacioTotalEnGigabytes = 0;
            double espacioDisponibleEnGigabytes = 0;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalEnBytes += drive.TotalSize;
                espacioDisponibleEnBytes += drive.AvailableFreeSpace;
            }

            espacioTotalEnGigabytes = Math.Round(espacioTotalEnBytes * 9.31 * Math.Pow(10, -10));
            espacioDisponibleEnGigabytes = Math.Round(espacioDisponibleEnBytes * 9.31 * Math.Pow(10, -10));
          

            lblEspacioTotal.Text = $"Espacio total: {espacioTotalEnGigabytes} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponibleEnGigabytes} Gigabytes";
        }*/
    }
}
