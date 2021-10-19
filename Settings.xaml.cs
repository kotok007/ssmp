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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select * from settings";
        DataSet dataSet = new DataSet();

        public Settings()
        {
            InitializeComponent();
        }

        private void ToggleEdit_Checked(object sender, RoutedEventArgs e)
        {
            textAdres.IsReadOnly = false;
            textGlavniy.IsReadOnly = false;
            textNazvanie.IsReadOnly = false;
            textUnp.IsReadOnly = false;
        }

        private void ToggleEdit_Unchecked(object sender, RoutedEventArgs e)
        {
            textAdres.IsReadOnly = true;
            textGlavniy.IsReadOnly = true;
            textNazvanie.IsReadOnly = true;
            textUnp.IsReadOnly = true;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            textNazvanie.Text = table.Rows[0][1].ToString();
            textAdres.Text = table.Rows[0][2].ToString();
            textUnp.Text = table.Rows[0][3].ToString();
            textGlavniy.Text = table.Rows[0][4].ToString();
        }

        private void saveSettings_Click(object sender, RoutedEventArgs e)
        {
            if (textNazvanie.Text == "" || textAdres.Text == "" || textUnp.Text == "" || textGlavniy.Text == "")
            {
                MessageBox.Show("Вы не заполнили все поля. Все поля обязательны для заполнения.", "Информация.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();
                sql = "update settings set organizacia = '"+textNazvanie.Text+ "', adres = '" + textAdres.Text + "', unp = '" + textUnp.Text + "', gl_vrach = '" + textGlavniy.Text + "'";
                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

                textGlavniy.Clear();
                textNazvanie.Clear();
                textAdres.Clear();
                textUnp.Clear();

                sql = "select * from settings";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                textNazvanie.Text = table.Rows[0][1].ToString();
                textAdres.Text = table.Rows[0][2].ToString();
                textUnp.Text = table.Rows[0][3].ToString();
                textGlavniy.Text = table.Rows[0][4].ToString();

                MessageBox.Show("Данные успешно сохранены.", "Информация.", MessageBoxButton.OK, MessageBoxImage.Information);
            }  
        }

        private void cancelSettings_Click(object sender, RoutedEventArgs e)
        {
            textGlavniy.Clear();
            textNazvanie.Clear();
            textAdres.Clear();
            textUnp.Clear();

            sql = "select * from settings";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            textNazvanie.Text = table.Rows[0][1].ToString();
            textAdres.Text = table.Rows[0][2].ToString();
            textUnp.Text = table.Rows[0][3].ToString();
            textGlavniy.Text = table.Rows[0][4].ToString();
        }
    }
}
