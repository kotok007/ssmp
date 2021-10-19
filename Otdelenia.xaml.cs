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
using Microsoft.Win32;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для About.xaml
    /// </summary>
    public partial class Otdelenia : Page
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select id As 'Номер', name AS 'Название отделения', kol_koek AS 'Количество коек' from otdelenie";
        DataSet dataSet = new DataSet();
        public Otdelenia()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            adapter.Fill(dataSet, "otdelenie");
            DataGridOtdelenia.ItemsSource = dataSet.Tables["otdelenie"].DefaultView;
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            if (textFind.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели информацию для поиска!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string sql = @"select id As 'Номер', name AS 'Название отделения', kol_koek AS 'Количество коек' from otdelenie where name like '" + textFind.Text + "%'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridOtdelenia.ItemsSource = search;
            }

            if (DataGridOtdelenia.Items.Count == 1)
            {
                string sql = @"select id As 'Номер', name AS 'Название отделения', kol_koek AS 'Количество коек' from otdelenie where kol_koek like '" + textFind.Text + "%'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridOtdelenia.ItemsSource = search;

            }
            if (DataGridOtdelenia.Items.Count == 1)
            {
                MessageBox.Show("Записей не найдено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridOtdelenia.ItemsSource = search;
                textFind.Clear();
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            //string id = Convert.ToString(DataGridOtdelenia.Rows[DataGridOtdelenia.CurrentRow.Index].Cells[0].Value);
            try
            {
                DataRowView rowView = DataGridOtdelenia.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    SQLiteConnection connection = new SQLiteConnection(connectionStr);
                    connection.Open();

                    string sqlDel = "DELETE FROM otdelenie WHERE id=" + id + "";

                    SQLiteCommand command = new SQLiteCommand(sqlDel, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataView search = new DataView(table);
                    DataGridOtdelenia.ItemsSource = search;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для удаления!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textNazvanie.Text.Length == 0 || textKol_koek.Text.Length == 0)
            {
                MessageBox.Show("Вы заполнили не все поля.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                SQLiteConnection connection = new SQLiteConnection(connectionStr);
                connection.Open();

                string sqlAdd = "insert into otdelenie (name, kol_koek) values ('"+textNazvanie.Text+"', '"+textKol_koek.Text+"')";

                SQLiteCommand command = new SQLiteCommand(sqlAdd, connection);
                command.ExecuteNonQuery();
                connection.Close();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridOtdelenia.ItemsSource = search;
            }
        }

        private void ButtonFindCancel_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridOtdelenia.ItemsSource = search;
            textFind.Clear();
        }

        private void ButtonPrint_Click(object sender, RoutedEventArgs e)
        {
            string sql = "select * from otdelenie";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();

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

            var tableRange = Paragraph.Range;

            wordApp.ActiveDocument.Tables.Add(tableRange, rows + 1, colums);

            var myTable = wordApp.ActiveDocument.Tables[wordApp.ActiveDocument.Tables.Count];
            myTable.set_Style("Сетка таблицы");
            myTable.ApplyStyleHeadingRows = true;
            myTable.ApplyStyleLastRow = false;
            myTable.ApplyStyleFirstColumn = true;
            myTable.ApplyStyleLastColumn = false;
            myTable.ApplyStyleRowBands = true;
            myTable.ApplyStyleColumnBands = false;

            myTable.Cell(1, 1).Range.Text = "№";
            myTable.Cell(1, 2).Range.Text = "Название отделения";
            myTable.Cell(1, 3).Range.Text = "Количество коек";

            for (int i = 1; i <= table.Rows.Count; i++)
            {
                myTable.Cell(i + 1, 1).Range.Text = table.Rows[i - 1][0].ToString();
                myTable.Cell(i + 1, 2).Range.Text = table.Rows[i - 1][1].ToString();
                myTable.Cell(i + 1, 3).Range.Text = table.Rows[i - 1][2].ToString();
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

        private void TextKol_koek_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
