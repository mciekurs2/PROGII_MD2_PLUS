using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace md2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelpAboutMenu_Click(object sender, EventArgs e)
        {
            AboutLogs logs = new AboutLogs();
            logs.Show();
            

        }

        private void GrafiskiButton_Click(object sender, EventArgs e)
        {
            Grafiskais_Logs logs = new Grafiskais_Logs();
            logs.Show(); //izmanto dialogShow, lai neļautu izveleties iepriekshejo logu
        }

        private void ApstiprinatButton_Click(object sender, EventArgs e)
        {

            //pievienota pagaidu funkcija, lai pievienotu mainigos
            //this.nedelasTempGridView.Rows.Add("viens", "divi");

            var weather = new WeatherData("London");
            weather.CheckWeather();
            Console.WriteLine(weather.Temp);
            Console.WriteLine(weather.TempMax);
            Console.WriteLine(weather.TempMin);
            

        }
    }
}
