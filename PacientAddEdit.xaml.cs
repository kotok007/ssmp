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
    /// Логика взаимодействия для PacientAddEdit.xaml
    /// </summary>
    public partial class PacientAddEdit : Window
    {
        public string text;
        public string id;
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "";
        DataSet dataSet = new DataSet();

        public PacientAddEdit()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CancelAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SavePacient_Click(object sender, RoutedEventArgs e)
        {
            if (textFio.Text.Length == 0 || textBorn.Text.Length == 0 || textMkb.Text.Length == 0 || textOtdelenie.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля, поля помечанные звездочкой обязательные к заполнению!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string date = DateTime.Today.ToString("dd:MM:yyyy");
                string time = DateTime.Now.ToString("HH:mm");
                string otkaz = "0";

                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlAdd = "insert into pacient (fio, number_pasport, date_born, adres, date, time, diagnoz_mkb, " +
                    "diagnoz_postup, sostoyanie, otdelenie, primechanie, vipisan, otkaz) values ('"+textFio.Text+ "', '"+textPasport.Text+ "', '"+textBorn.Text+ "', '"+textAdres.Text+"'," +
                    "'"+date+ "', '"+time+ "', '"+textMkb.Text+ "', '"+textDiagnoz.Text+ "', '"+textSostoyanie.Text+ "', '"+textOtdelenie.Text+ "', '"+textPrimechanie.Text+"'," +
                    "'false', '"+otkaz+"')";

                SQLiteCommand command = new SQLiteCommand(sqlAdd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }   
        }

        private void ButtonAddMkb_Click(object sender, RoutedEventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.sql = "select id As 'Номер', number_mkb AS 'Номер по МКБ', diagnoz AS 'Диагноз по МКБ' from mkb";
            formAdd.textTitle.Text = "СПРАВОЧНИК МКБ";
            formAdd.ShowDialog();
            textMkb.Clear();
            textMkb.Text = formAdd.text;
        }

        private void ButtonAddOtdelenie_Click(object sender, RoutedEventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.sql = "select id As 'Номер', name AS 'Название отделения', kol_koek AS 'Количество коек' from otdelenie";
            formAdd.textTitle.Text = "СПРАВОЧНИК ОТДЕЛЕНИЯ";
            formAdd.ShowDialog();
            textOtdelenie.Clear();
            textOtdelenie.Text = formAdd.text;
        }

        private void EditPacient_Click(object sender, RoutedEventArgs e)
        {
            if (textFio.Text.Length == 0 || textBorn.Text.Length == 0 || textMkb.Text.Length == 0 || textOtdelenie.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля, поля помечанные звездочкой обязательные к заполнению!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string date = DateTime.Today.ToString("dd:MM:yyyy");
                string time = DateTime.Now.ToString("HH:mm");

                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlUpdte = "update pacient set fio = '"+textFio.Text+ "', number_pasport = '"+textPasport.Text+ "', date_born = '"+textBorn.Text+ "', adres = '"+textAdres.Text+"'," +
                    "diagnoz_mkb = '"+textMkb.Text+ "', diagnoz_postup = '"+textDiagnoz.Text+ "', sostoyanie = '"+textSostoyanie.Text+ "', otdelenie = '"+textOtdelenie.Text+"'," +
                    "primechanie = '"+textPrimechanie.Text+"' where id ='"+id+"'";

                SQLiteCommand command = new SQLiteCommand(sqlUpdte, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }

        private void ShowPacient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
