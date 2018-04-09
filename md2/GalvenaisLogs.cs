using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            pilsetaComboBox.DataSource = Enum.GetValues(typeof(PilsetasExample));

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
                //var result = JsonConvert.DeserializeObject<WeatherDataWeekly>(jsonString);
                //nedelasTempGridView.DataSource = result.List[0].Weather;
                //Console.WriteLine(result.List[0].Weather);

                var data = JsonConvert.DeserializeObject<WeatherDataWeekly>(jsonString);
               //Console.WriteLine("Current Temp: " + data.List[26].Weather[0].Description);

                nedelasTempGridView.RowHeadersWidth = 120;

                for (var i = 0; i < 38; i++)
                {
                    DataGridViewRow row = (DataGridViewRow) nedelasTempGridView.Rows[i].Clone();
                    var dTime = Convert.ToDateTime(data.List[i].Dt_txt);

                    row.HeaderCell.Value = dTime.DayOfWeek.ToString();
                    row.Cells[0].Value = dTime.ToString("HH:mm");
                    row.Cells[1].Value = data.List[i].Main.Temp + " °C";
                    row.Cells[2].Value = data.List[i].Weather[0].Description;
                    row.Cells[3].Value = data.List[i].Main.Humidity;
                    row.Cells[4].Value = data.List[i].Wind.Speed + " m/s";
                    nedelasTempGridView.Rows.Add(row);
                }

                //paraada valsts kodu
                valstsKods.Text = data.City.Country;

                //DateTime dTime = Convert.ToDateTime(data.List[0].Dt_txt);
                //Console.WriteLine(dTime.DayOfWeek);
            }
        }
        
        //pagaidu variants, droši vien tik izmantota cita pieeja, lai izmantotu enum
        public enum PilsetasExample
        {
            Riga = 0,
            London = 1,
            Paris = 2,
            Moscow = 3
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //ielade dataGridView elementus (pagaidu variants)
            var city = pilsetaComboBox.SelectedItem.ToString();
            GetJsonData(city);

            //convert url to memoryStream
            //var webClientIcon = new WebClient();
            //var bytes = webClientIcon.DownloadData("http://openweathermap.org/img/w/10d.png");
            //var ms = new MemoryStream(bytes);



            //loadDBData
            var dbCon = new OleDbConnection
            {
                ConnectionString =
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\source\repos\PROGII_MD2_PLUS\FavoriteCities.mdb"
            };
            dbCon.Open();

            var loadCom = new OleDbCommand
            {
                Connection = dbCon,
                CommandText = "SELECT * FROM CitiesInfo WHERE ID > 0"
            };

            var readData = loadCom.ExecuteReader();
            while (readData != null && readData.Read())
            {
                //readItems
                var cityName = readData[1].ToString();

                //getsCurrentDataForCity
                var tempCur = 0.0;
                var webClientIcon = new WebClient();
                MemoryStream ms;

                var url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName +
                          "&mode=json&units=metric&APPID=02960f011b3cb23776734af3fa9fdf50";
                using (var webClientWeather = new System.Net.WebClient())
                {
                    var jsonString = webClientWeather.DownloadString(url);
                    var data = JsonConvert.DeserializeObject<WeatherDataToday>(jsonString);
                    var iconIdCur = data.Weather[0].Icon;
                    tempCur = data.Main.Temp;

                    var bytes = webClientIcon.DownloadData("http://openweathermap.org/img/w/" + iconIdCur + ".png");
                    ms = new MemoryStream(bytes);
                }



                //testReading
                //GetCurrentWeatherData(cityName);

                //add data to listBox
                var sample = new CityAdapter(Image.FromStream(ms), cityName, tempCur);
                cityListBox.Items.Add(sample);
            }

            dbCon.Close();

        }

        private void fileExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private const int ItemHeight = 50;
        private void cityListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = ItemHeight;
        }

        private void cityListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var listBox = sender as ListBox;
            var cityAdapter = listBox.Items[e.Index] as CityAdapter;

            e.DrawBackground();

            cityAdapter.DrawItem(e.Graphics, e.Bounds, this.Font, false);


        }
    }
}
