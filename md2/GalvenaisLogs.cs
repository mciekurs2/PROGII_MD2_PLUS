using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace md2
{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
            pilsetaComboBox.DataSource = Enum.GetValues(typeof(pilsetasExample));

        }

        //delegats
        public delegate void Del(string city);

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
        
            var city = pilsetaComboBox.SelectedItem.ToString();
            Del funk = GetJsonData;
            funk(city);


        }

        private void GetJsonData(string city)
        {
            var url = "http://api.openweathermap.org/data/2.5/forecast?q=" + city +
                      "&mode=json&units=metric&APPID=02960f011b3cb23776734af3fa9fdf50";

            using (var webClient = new System.Net.WebClient())
            {
                var jsonString = webClient.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherData>(jsonString);
                nedelasTempGridView.DataSource = result.List[0].Weather;


            }


        }
        
        public enum pilsetasExample
        {
            Cesis = 0,
            Riga = 1,
            Valmiera = 2,
            Liepaja = 3
        }

    }
}
