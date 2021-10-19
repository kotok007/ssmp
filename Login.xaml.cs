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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select * from doctors";
        DataSet dataSet = new DataSet();

        public Login()
        {
            InitializeComponent();
        }

        private void VoitiButton_Click(object sender, RoutedEventArgs e)
        {
            string login = textLogin.Text;
            string password = textPassword.Password.ToString();
            if (login == "Администратор" && password == "1111")
            {
                Adminka adminka = new Adminka();
                this.Hide();
                adminka.Show();
            }
            else
            {
                sql = "select * from doctors where login='" + login + "' and password='" + password + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    string id = table.Rows[0][0].ToString();
                    string fio = table.Rows[0][3].ToString();
                    string date = DateTime.Today.ToString("dd MMMM yyyy");
                    string currentLogin = table.Rows[0][1].ToString();
                    MainForm mainForm = new MainForm();
                    mainForm.textCurrentUser.Text = " " + fio + "; ";
                    mainForm.textCurrentLogin.Text = " " + login + "; ";
                    mainForm.textCurrentDate.Text = " " + date + "; ";
                    mainForm.id = id;
                    mainForm.fio = fio;
                    mainForm.login = login;
                    mainForm.Show();
                    this.Hide();
                    adapter.Dispose();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации. Вы ввели неверный логин или пароль.", "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
                    textLogin.Clear();
                    textPassword.Clear();
                    textLogin.Focus();
                }
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }
    }
}
