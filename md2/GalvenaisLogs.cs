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
            /*var url = "http://api.openweathermap.org/data/2.5/weather?q=Cesis&mode=json&units=metric&APPID=02960f011b3cb23776734af3fa9fdf50";
            using (var webClient = new System.Net.WebClient())
            {
                //dabu json as string
                var json = webClient.DownloadString(url);
                //now parse with json.net

                dynamic result = JsonConvert.DeserializeObject<dynamic>(json);
                var temp = result.main.temp;
                var pressure = result.name;


                Console.WriteLine(pressure + " " + temp);

            }*/

            var city = pilsetaTextBox.Text;
            GetJsonData(city);


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

    }
}
