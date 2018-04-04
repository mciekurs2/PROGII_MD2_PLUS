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
            nedelasTempGridView.Rows.Clear();
            nedelasTempGridView.Refresh();
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
                //nedelasTempGridView.DataSource = result.List[0].Weather;
                //Console.WriteLine(result.List[0].Weather);

                WeatherData data = JsonConvert.DeserializeObject<WeatherData>(jsonString);
               //Console.WriteLine("Current Temp: " + data.List[26].Weather[0].Description);

                nedelasTempGridView.RowHeadersWidth = 170;
                DateTime dTime;

                for (var i = 0; i < 38; i++)
                {
                    DataGridViewRow row = (DataGridViewRow) nedelasTempGridView.Rows[i].Clone();
                    dTime = Convert.ToDateTime(data.List[i].Dt_txt);

                    row.HeaderCell.Value = dTime.DayOfWeek.ToString();
                    row.Cells[0].Value = dTime.ToString("HH:mm");
                    row.Cells[1].Value = data.List[i].Main.Temp + " °C";
                    row.Cells[2].Value = data.List[i].Weather[0].Description;
                    row.Cells[3].Value = data.List[i].Main.Humidity;
                    row.Cells[4].Value = data.List[i].Wind.Speed + " m/s";
                    nedelasTempGridView.Rows.Add(row);
                }

                //DateTime dTime = Convert.ToDateTime(data.List[0].Dt_txt);
                //Console.WriteLine(dTime.DayOfWeek);
            }
        }
        
        //pagaidu variants, droši vien tik izmantota cita pieeja, lai izmantotu enum
        public enum pilsetasExample
        {
            Riga = 0,
            London = 1,
            Paris = 2,
            Moscow = 3
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var city = pilsetaComboBox.SelectedItem.ToString();
            GetJsonData(city);
        }
    }
}
