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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Win32;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для Adminka.xaml
    /// </summary>
    public partial class Adminka : Window
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select id as '№', fio As 'ФИО', login AS 'Логин', password AS 'Пароль', dolgnost as 'Должность' from doctors";
        DataSet dataSet = new DataSet();
        public Adminka()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            adapter.Fill(dataSet, "doctors");
            DataGridUsers.ItemsSource = dataSet.Tables["doctors"].DefaultView;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            if (textFind.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели информацию для поиска!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string sql = @"select id as '№', fio As 'ФИО', login AS 'Логин', password AS 'Пароль', dolgnost as 'Должность' from doctors where login like '" + textFind.Text + "%'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridUsers.ItemsSource = search;
            }

          
            if (DataGridUsers.Items.Count == 0)
            {
                MessageBox.Show("Записей не найдено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridUsers.ItemsSource = search;
                textFind.Clear();
            }
        }

        private void ButtonFindCancel_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridUsers.ItemsSource = search;
            textFind.Clear();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textFio.Text.Length == 0 || textLogin.Text.Length == 0 || textPassword.Text.Length == 0 || textDolgnost.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля. Все поля обязательны для заполнения", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlAdd = "insert into doctors (login, password, fio, dolgnost) values ('" + textLogin.Text + "', '" + textPassword.Text + "', '"+textFio.Text+"', '"+textDolgnost.Text+"')";

                SQLiteCommand command = new SQLiteCommand(sqlAdd, connection);
                command.ExecuteNonQuery();
                connection.Close();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridUsers.ItemsSource = search;
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView rowView = DataGridUsers.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    SQLiteConnection connection = new SQLiteConnection(connectionStr);
                    connection.Open();

                    string sqlDel = "DELETE FROM doctors WHERE id=" + id + "";

                    SQLiteCommand command = new SQLiteCommand(sqlDel, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataView search = new DataView(table);
                    DataGridUsers.ItemsSource = search;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для удаления!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
}
    }
}
