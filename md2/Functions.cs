using System;
using System.Collections;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace md2
{
    class Functions
    {
        public static void LoadListBox(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.DataSource = List();
        }

        public static void LoadDataGridView(string city, DataGridView gridView, Label valstKods)
        {
            var url = "http://api.openweathermap.org/data/2.5/forecast?q=" + city +
                      "&mode=json&units=metric&APPID=02960f011b3cb23776734af3fa9fdf50";

            using (var webClient = new WebClient())
            {
                var jsonString = webClient.DownloadString(url);
                var data = JsonConvert.DeserializeObject<WeatherDataWeekly>(jsonString);
                gridView.RowHeadersWidth = 120;

                for (var i = 0; i < 38; i++)
                {
                    var row = (DataGridViewRow)gridView.Rows[i].Clone();
                    var dTime = Convert.ToDateTime(data.List[i].Dt_txt);

                    row.HeaderCell.Value = dTime.DayOfWeek.ToString();
                    row.Cells[0].Value = dTime.ToString("HH:mm");
                    row.Cells[1].Value = data.List[i].Main.Temp + " °C";
                    row.Cells[2].Value = data.List[i].Weather[0].Description;
                    row.Cells[3].Value = data.List[i].Main.Humidity;
                    row.Cells[4].Value = data.List[i].Wind.Speed + " m/s";
                    gridView.Rows.Add(row);
                }

                //paraada valsts kodu
                valstKods.Text = data.City.Country;

                //DateTime dTime = Convert.ToDateTime(data.List[0].Dt_txt);
                //Console.WriteLine(dTime.DayOfWeek);
            }
        }

        private static ArrayList List()
        {
            var list = new ArrayList();

            //loadDBData
            var dbCon = new OleDbConnection
            {
                ConnectionString =
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.GetFullPath(@"..\..\..\") + "FavoriteCities.mdb"
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
                double tempCur;
                var webClientIcon = new WebClient();
                MemoryStream ms;

                var url = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName +
                          "&mode=json&units=metric&APPID=02960f011b3cb23776734af3fa9fdf50";
                using (var webClientWeather = new WebClient())
                {
                    String jsonString;

                    try
                    {
                        jsonString = webClientWeather.DownloadString(url);
                    }
                    catch (WebException)
                    {
                        ErrorFunctions.ShowError("Please delete this value from db (temporary solution): ", cityName);
                        continue;

                    }

                    var data = JsonConvert.DeserializeObject<WeatherDataToday>(jsonString);
                    var iconIdCur = data.Weather[0].Icon;
                    tempCur = data.Main.Temp;

                    var bytes = webClientIcon.DownloadData("http://openweathermap.org/img/w/" + iconIdCur + ".png");
                    ms = new MemoryStream(bytes);
                }

                //add data to listBox
                var sample = new CityAdapter(Image.FromStream(ms), cityName, tempCur);
                list.Add(sample);
            }
            dbCon.Close();
            return list;
        }

    }
}
