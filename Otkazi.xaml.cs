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
//using Microsoft.Office.Interop.Word;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для Pacient.xaml
    /// </summary>
    public partial class Otkazi : Page
    {
        public string user;
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время выписки', date_v AS 'Дата выписки', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='true' and otkaz = '1'";
        DataSet dataSet = new DataSet();

        public Otkazi()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            adapter.Fill(dataSet, "pacient");
            DataGridPacient.ItemsSource = dataSet.Tables["pacient"].DefaultView;
            //DataGridPacient.Columns[0].Width = 50;
            //DataGridPacient.Columns[1].Width = 150;
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            if (textFind.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели информацию для поиска!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                string sql = @"select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', date_v AS 'Дата выписки', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient where fio like '" + textFind.Text + "%'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridPacient.ItemsSource = search;
            }

            if (DataGridPacient.Items.Count == 0)
            {
                string sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', date_v AS 'Дата выписки', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='true' and otkaz = '1'";
                MessageBox.Show("Записей не найдено!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridPacient.ItemsSource = search;
                textFind.Clear();
            }

        }

        private void ButtonFindCancel_Click(object sender, RoutedEventArgs e)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridPacient.ItemsSource = search;
            textFind.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', date_v AS 'Дата выписки', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='true' and otkaz = '1'";
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
                wordApp.ActiveDocument.Tables.Add(tableRange, rows+1, colums);

                var myTable = wordApp.ActiveDocument.Tables[wordApp.ActiveDocument.Tables.Count];
                myTable.set_Style("Сетка таблицы");
                myTable.ApplyStyleHeadingRows = true;
                myTable.ApplyStyleLastRow = false;
                myTable.ApplyStyleFirstColumn = true;
                myTable.ApplyStyleLastColumn = false;
                myTable.ApplyStyleRowBands = true;
                myTable.ApplyStyleColumnBands = false;

                myTable.Cell(1, 1).Range.Text = "№";
                myTable.Cell(1, 2).Range.Text = "ФИО";
                myTable.Cell(1, 3).Range.Text = "Дата поступления";
                myTable.Cell(1, 4).Range.Text = "Время поступления";
                myTable.Cell(1, 5).Range.Text = "Диагноз";
                myTable.Cell(1, 6).Range.Text = "Отделение";

                for (int i = 1; i <= table.Rows.Count; i++)
                {
                    myTable.Cell(i+1, 1).Range.Text = table.Rows[i-1][0].ToString();
                    myTable.Cell(i+1, 2).Range.Text = table.Rows[i-1][1].ToString();
                    myTable.Cell(i+1, 3).Range.Text = table.Rows[i-1][2].ToString();
                    myTable.Cell(i+1, 4).Range.Text = table.Rows[i-1][3].ToString();
                    myTable.Cell(i+1, 5).Range.Text = table.Rows[i-1][4].ToString();
                    myTable.Cell(i+1, 6).Range.Text = table.Rows[i-1][5].ToString();
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

        private void zamena (string zakladka, string text, Word.Document document)
        {
            object bookmarkObj = zakladka;
            Word.Range bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = text;
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    SQLiteConnection connection = new SQLiteConnection(connectionStr);
                    connection.Open();

                    string sqlDel = "DELETE FROM pacient WHERE id=" + id + "";

                    SQLiteCommand command = new SQLiteCommand(sqlDel, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataView search = new DataView(table);
                    DataGridPacient.ItemsSource = search;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для удаления!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }


        private void ButtonEditPacient_Click(object sender, RoutedEventArgs e)
        {
            PacientAddEdit pacientAddEdit = new PacientAddEdit();
            pacientAddEdit.editPacient.Visibility = Visibility.Visible;
            pacientAddEdit.savePacient.Visibility = Visibility.Hidden;
            pacientAddEdit.showPacient.Visibility = Visibility.Hidden;
            pacientAddEdit.textTitle.Text = "Изменение пациента в БГБ СМП";

            SQLiteConnection connection = new SQLiteConnection(connectionStr);
            connection.Open();
            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                sql = "select * from pacient where id = '" + id + "'";

                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(command);
                DataTable tableNew = new DataTable();
                sQLiteDataAdapter.Fill(tableNew);

                pacientAddEdit.textFio.Text = tableNew.Rows[0][1].ToString();
                pacientAddEdit.textPasport.Text = tableNew.Rows[0][2].ToString();
                pacientAddEdit.textBorn.Text = tableNew.Rows[0][3].ToString();
                pacientAddEdit.textAdres.Text = tableNew.Rows[0][4].ToString();
                pacientAddEdit.textMkb.Text = tableNew.Rows[0][7].ToString();
                pacientAddEdit.textDiagnoz.Text = tableNew.Rows[0][8].ToString();
                pacientAddEdit.textSostoyanie.Text = tableNew.Rows[0][9].ToString();
                pacientAddEdit.textOtdelenie.Text = tableNew.Rows[0][10].ToString();
                pacientAddEdit.textPrimechanie.Text = tableNew.Rows[0][11].ToString();
                connection.Close();
                pacientAddEdit.id = id;
                pacientAddEdit.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для изменения!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', date_v AS 'Дата выписки', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='true' and otkaz = '1'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridPacient.ItemsSource = search;
        }

        private void ButtonShoPacient_Click(object sender, RoutedEventArgs e)
        {
            PacientAddEdit pacientAddEdit = new PacientAddEdit();
            pacientAddEdit.editPacient.Visibility = Visibility.Hidden;
            pacientAddEdit.savePacient.Visibility = Visibility.Hidden;
            pacientAddEdit.showPacient.Visibility = Visibility.Visible;
            pacientAddEdit.textTitle.Text = "Информация о пациенте в БГБ СМП";

            SQLiteConnection connection = new SQLiteConnection(connectionStr);
            connection.Open();
            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                sql = "select * from pacient where id = '" + id + "'";

                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(command);
                DataTable tableNew = new DataTable();
                sQLiteDataAdapter.Fill(tableNew);

                pacientAddEdit.textFio.Text = tableNew.Rows[0][1].ToString();
                pacientAddEdit.textPasport.Text = tableNew.Rows[0][2].ToString();
                pacientAddEdit.textBorn.Text = tableNew.Rows[0][3].ToString();
                pacientAddEdit.textAdres.Text = tableNew.Rows[0][4].ToString();
                pacientAddEdit.textMkb.Text = tableNew.Rows[0][7].ToString();
                pacientAddEdit.textDiagnoz.Text = tableNew.Rows[0][8].ToString();
                pacientAddEdit.textSostoyanie.Text = tableNew.Rows[0][9].ToString();
                pacientAddEdit.textOtdelenie.Text = tableNew.Rows[0][10].ToString();
                pacientAddEdit.textPrimechanie.Text = tableNew.Rows[0][11].ToString();

                pacientAddEdit.textFio.IsReadOnly = true;
                pacientAddEdit.textPasport.IsReadOnly = true;
                pacientAddEdit.textBorn.IsReadOnly = true;
                pacientAddEdit.textAdres.IsReadOnly = true;
                pacientAddEdit.textDiagnoz.IsReadOnly = true;
                pacientAddEdit.textMkb.IsReadOnly = true;
                pacientAddEdit.textSostoyanie.IsReadOnly = true;
                pacientAddEdit.textOtdelenie.IsReadOnly = true;
                pacientAddEdit.textPrimechanie.IsReadOnly = true;

                connection.Close();
                pacientAddEdit.id = id;
                pacientAddEdit.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для просмотра!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ButtonPrintEpikriz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();

                string sql = " select * from pacient  where id='" + id + "'";
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
                string nazvanie = tableSetting.Rows[0][1].ToString();
                //string user = tableSetting.Rows[0][1].ToString();
                string glavvrach = tableSetting.Rows[0][4].ToString();

                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDoc = wordApp.Documents.Open(Environment.CurrentDirectory + @"\Template\epikriz.docx");

                try
                {
                    zamena("uz", nazvanie, wordDoc);
                    zamena("id", table.Rows[0][0].ToString(), wordDoc);
                    zamena("fio", table.Rows[0][1].ToString(), wordDoc);
                    zamena("born", table.Rows[0][3].ToString(), wordDoc);
                    zamena("adres", table.Rows[0][4].ToString(), wordDoc);
                    zamena("date", table.Rows[0][5].ToString(), wordDoc);
                    zamena("vipisan", table.Rows[0][14].ToString(), wordDoc);
                    zamena("otdelenie", table.Rows[0][10].ToString(), wordDoc);
                    zamena("mkb", table.Rows[0][7].ToString(), wordDoc);
                    zamena("diagnoz_postup", table.Rows[0][8].ToString(), wordDoc);
                    zamena("primechanie", table.Rows[0][11].ToString(), wordDoc);
                    zamena("lechenie", table.Rows[0][15].ToString(), wordDoc);
                    zamena("glav", glavvrach, wordDoc);
                    zamena("user", user, wordDoc);

                    wordDoc.SaveAs2(Environment.CurrentDirectory + @"\Word\Epikriz.docx");
                    wordApp.Visible = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка открытия файла! Файл шаблона отсутствует или поврежден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    wordDoc.Close();
                    wordApp.Quit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для печати!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}