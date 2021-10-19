using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для VipiskaOrOtkaz.xaml
    /// </summary>
    public partial class VipiskaOrOtkaz : Window
    {
        public string id = "";
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql;
        DataSet dataSet = new DataSet();
        public VipiskaOrOtkaz()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (textDate.Text.Length == 0 || textDiagnoz.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля, все поля обязательны к заполнению!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string date = textDate.Text;

                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlUpdte = "update pacient set date_v = '"+date+"', lechorotkaz = '"+textDiagnoz.Text+"', vipisan = 'true' where id = '"+id+"'";

                SQLiteCommand command = new SQLiteCommand(sqlUpdte, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textDate.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void Save1_Click(object sender, RoutedEventArgs e)
        {
            if (textDate.Text.Length == 0 || textDiagnoz.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля, все поля обязательны к заполнению!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string date = textDate.Text;

                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlUpdte = "update pacient set date_v = '" + date + "', lechorotkaz = '" + textDiagnoz.Text + "', vipisan = 'true', otkaz = '1' where id = '" + id + "'";

                SQLiteCommand command = new SQLiteCommand(sqlUpdte, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }
    }
}
