using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

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
        public delegate void Del(string city, DataGridView gridView, Label valstKods);

        private void HelpAboutMenu_Click(object sender, EventArgs e)
        {
            var logs = new AboutLogs();
            logs.ShowDialog();         
        }

        private void GrafiskiButton_Click(object sender, EventArgs e)
        {
            var logs = new Grafiskais_Logs();
            logs.ShowDialog(); //izmanto dialogShow, lai neļautu izveleties iepriekshejo logu
        }

        private void ApstiprinatButton_Click(object sender, EventArgs e)
        {      
            var city = pilsetaComboBox.SelectedItem.ToString();
            Del funk = Functions.LoadDataGridView;
            nedelasTempGridView.Rows.Clear();
            nedelasTempGridView.Refresh();
            funk(city, nedelasTempGridView, valstsKods);
        }
        
        //pagaidu variants, droši vien tiks izmantota cita pieeja, lai izmantotu enum
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
            Functions.LoadDataGridView(city, nedelasTempGridView, valstsKods);
            RefreshFunction.LoadListBox(cityListBox);
        }

        private void FileExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private const int ItemHeight = 50;
        private void CityListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = ItemHeight;
        }

        private void CityListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var listBox = sender as ListBox;
            var cityAdapter = listBox?.Items[e.Index] as CityAdapter;

            e.DrawBackground();

            cityAdapter?.DrawItem(e.Graphics, e.Bounds, Font, false);
        }

        //open AddCity window
        private void AddButton_Click(object sender, EventArgs e)
        {
            var cityForm = new AddCity();
            cityForm.Show();
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Functions.LoadListBox(cityListBox);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //gets selectedItem from ListBox
            var cityAdapter = cityListBox.SelectedItem as CityAdapter;

            var favCityName = cityAdapter?.CityName;

            var dbConnection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.GetFullPath(@"..\..\..\") +
                                   "FavoriteCities.mdb"
            };
            dbConnection.Open();

            var dbCommand = new OleDbCommand
            {
                Connection = dbConnection,
                CommandText = "DELETE FROM CitiesInfo WHERE cityName ='" + favCityName + "'"
            };

            dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            Functions.LoadListBox(cityListBox);

        }
    }

    internal class RefreshFunction : Functions
    {

    }

}
