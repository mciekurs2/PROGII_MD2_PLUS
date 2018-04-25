using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using md2.Properties;

namespace md2
{
    public partial class AddCity : Form
    {
        public AddCity()
        {
            InitializeComponent();
        }

        private void ConfirmButtonFavorite_Click(object sender, EventArgs e)
        {
            //parbauda vai textbox ir tukšs
            if (string.IsNullOrWhiteSpace(texBoxFavorite.Text))
            {
                Messages.ShowError(Messages.ErrorOne);
                return;
            }


            var cityName = texBoxFavorite.Text;
            var timeStamp = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");

            var dbConnection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path.GetFullPath(@"..\..\..\") +
                                   "FavoriteCities.mdb"
            };
            dbConnection.Open();

            var dbCommand = new OleDbCommand
            {
                Connection = dbConnection,
                CommandText = "INSERT INTO CitiesInfo (cityName, addedTime) VALUES (@cityName, @timeStamp)"
            };

            dbCommand.Parameters.AddWithValue("@cityName", OleDbType.Char).Value = cityName;
            dbCommand.Parameters.AddWithValue("@timeStamp", OleDbType.DBTimeStamp).Value = timeStamp;
            dbCommand.ExecuteNonQuery();

            MessageBox.Show(Resources.messageBox_Added);
            dbConnection.Close();

            var mw = new MainWindow();
            Functions.LoadListBox(mw.cityListBox);


        }
    }

    public class Messages : ErrorFunctions
    {
        //new izmanto lai izsauktu paslpēšanu
        new public static string ErrorOne = "Please enter a city name";

    }

}
