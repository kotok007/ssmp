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
using Word = Microsoft.Office.Interop.Word;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select nazvanie as 'Наименование', number as 'Количество'  from otchet";
        DataSet dataSet = new DataSet();
        public Report()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionStr);

            connection.Open();
            string sql = "select count(id) from pacient where vipisan = 'false'";
            SQLiteCommand commandAll = new SQLiteCommand(sql, connection);
            object countAll = commandAll.ExecuteScalar(); 
            connection.Close();

            connection.Open();
            sql = "select count(id) from pacient where vipisan = 'true'";
            SQLiteCommand commandVipisan = new SQLiteCommand(sql, connection);
            object countVipisan = commandVipisan.ExecuteScalar();
            connection.Close();

            connection.Open();
            sql = "select count(id) from pacient where vipisan = 'true' and otkaz = '1'";
            SQLiteCommand commandOtkaz = new SQLiteCommand(sql, connection);
            object countOtkaz = commandOtkaz.ExecuteScalar();
            connection.Close();

            connection.Open();
            sql = "select count(id) from otdelenie";
            SQLiteCommand commandOtdelenie = new SQLiteCommand(sql, connection);
            object countOtdelenie = commandOtdelenie.ExecuteScalar();
            connection.Close();

            connection.Open();
            string sqlUpdte = "update otchet set number = '"+countAll+ "' where nazvanie = 'Текущих пациентов'";
            SQLiteCommand commandUpdate = new SQLiteCommand(sqlUpdte, connection);
            commandUpdate.ExecuteNonQuery();
            sqlUpdte = "update otchet set number = '" + countVipisan + "' where nazvanie = 'Выписаных пациентов'";
            commandUpdate = new SQLiteCommand(sqlUpdte, connection);
            commandUpdate.ExecuteNonQuery();
            sqlUpdte = "update otchet set number = '" + countOtkaz + "' where nazvanie = 'Отказавшихся от госпитализации'";
            commandUpdate = new SQLiteCommand(sqlUpdte, connection);
            commandUpdate.ExecuteNonQuery();
            sqlUpdte = "update otchet set number = '" + countOtdelenie + "' where nazvanie = 'Количество отделений в больнице'";
            commandUpdate = new SQLiteCommand(sqlUpdte, connection);
            commandUpdate.ExecuteNonQuery();
            connection.Close();

            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DataView search = new DataView(table);
            //DataGridPacient.ItemsSource = search;
            sql = "select nazvanie as 'Наименование', number as 'Количество'  from otchet";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataTable.Rows[0][1] = Convert.ToString(countAll);
            dataTable.Rows[1][1] = Convert.ToString(countVipisan);
            dataTable.Rows[2][1] = Convert.ToString(countOtkaz);
            dataTable.Rows[3][1] = Convert.ToString(countOtdelenie);
            adapter.Fill(dataSet, "otchet");
            DataView dataView = new DataView(dataTable);
            DataGridOtchet.ItemsSource = dataView;


        }

        private void ButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            string sql = "select nazvanie as 'Наименование', number as 'Количество'  from otchet";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            int colums = table.Columns.Count;
            int rows = table.Rows.Count;

            sql = "select * from settings";
            SQLiteDataAdapter adapterSetting = new SQLiteDataAdapter(sql, connectionStr);
            DataTable tableSetting = new DataTable();
            tableSetting.Clear();
            adapterSetting.Fill(tableSetting);
            string date = DateTime.Now.ToString();
            string nazvanie = tableSetting.Rows[0][1].ToString();

            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDoc = wordApp.Documents.Open(Environment.CurrentDirectory + @"\Template\template.docx");

            try
            {
                zamena("name", currentTextHeader.Text, wordDoc);
                zamena("uz", nazvanie, wordDoc);
                zamena("date", date, wordDoc);

                //Добавляем параграф в конец документа
                var Paragraph = wordApp.ActiveDocument.Paragraphs.Add();
                //Получаем диапазон
                var tableRange = Paragraph.Range;
                //Добавляем таблицу 2х2 в указаный диапазон
                wordApp.ActiveDocument.Tables.Add(tableRange, rows + 1, colums);

                var myTable = wordApp.ActiveDocument.Tables[wordApp.ActiveDocument.Tables.Count];
                myTable.set_Style("Сетка таблицы");
                myTable.ApplyStyleHeadingRows = true;
                myTable.ApplyStyleLastRow = false;
                myTable.ApplyStyleFirstColumn = true;
                myTable.ApplyStyleLastColumn = false;
                myTable.ApplyStyleRowBands = true;
                myTable.ApplyStyleColumnBands = false;

                myTable.Cell(1, 1).Range.Text = "Наименование";
                myTable.Cell(1, 2).Range.Text = "Количество";

                for (int i = 1; i <= table.Rows.Count; i++)
                {
                    myTable.Cell(i + 1, 1).Range.Text = table.Rows[i - 1][0].ToString();
                    myTable.Cell(i + 1, 2).Range.Text = table.Rows[i - 1][1].ToString();
                }

                wordDoc.SaveAs2(Environment.CurrentDirectory + @"\Word\Report.docx");
                wordApp.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка открытия файла! Файл шаблона отсутствует или поврежден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                wordDoc.Close();
                wordApp.Quit();
            }
        }

        private void zamena(string zakladka, string text, Word.Document document)
        {
            object bookmarkObj = zakladka;
            Word.Range bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = text;
        }
    }
}
