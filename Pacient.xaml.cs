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
    public partial class Pacient : Page
    {
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        string sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='false'";
        DataSet dataSet = new DataSet();

        public Pacient()
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
                string sql = @"select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient where fio like '" + textFind.Text + "%'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataView search = new DataView(table);
                DataGridPacient.ItemsSource = search;
            }

            if (DataGridPacient.Items.Count == 0)
            {
                string sql1 = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='false'";
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
            string sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient where vipisan='false'";
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

        private void ButtonAddPacient_Click(object sender, RoutedEventArgs e)
        {
                //DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                //string id = rowView[0].ToString();

            PacientAddEdit pacientAddEdit = new PacientAddEdit();
            pacientAddEdit.textTitle.Text = "Добавление нового пациента в БГБ СМП";
            pacientAddEdit.editPacient.Visibility = Visibility.Hidden;
            pacientAddEdit.savePacient.Visibility = Visibility.Visible;
            pacientAddEdit.showPacient.Visibility = Visibility.Hidden;
            pacientAddEdit.ShowDialog();

            sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan = 'false'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridPacient.ItemsSource = search;
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
            sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='false'";
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
                MessageBox.Show("Вы не выбрали запись для изменения!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ButtonVipisat_Click(object sender, RoutedEventArgs e)
        {
            VipiskaOrOtkaz vipiskaOrOtkaz = new VipiskaOrOtkaz();
            vipiskaOrOtkaz.textTitle.Text = "Выписка пациента";
            vipiskaOrOtkaz.blockDate.Text = "Дата выписки";
            vipiskaOrOtkaz.blockAll.Text = "Лечение";
            vipiskaOrOtkaz.save.Visibility = Visibility.Visible;
            vipiskaOrOtkaz.save1.Visibility = Visibility.Hidden;
            
            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();
                vipiskaOrOtkaz.id = id;
                vipiskaOrOtkaz.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для выписки!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='false'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridPacient.ItemsSource = search;
        }

        private void ButtonOtkaz_Click(object sender, RoutedEventArgs e)
        {
            VipiskaOrOtkaz vipiskaOrOtkaz = new VipiskaOrOtkaz();
            vipiskaOrOtkaz.textTitle.Text = "Отказ от госпитализации";
            vipiskaOrOtkaz.blockDate.Text = "Дата отказа";
            vipiskaOrOtkaz.blockAll.Text = "Причина отказа";
            vipiskaOrOtkaz.save.Visibility = Visibility.Hidden;
            vipiskaOrOtkaz.save1.Visibility = Visibility.Visible;

            try
            {
                DataRowView rowView = DataGridPacient.SelectedValue as DataRowView;
                string id = rowView[0].ToString();
                vipiskaOrOtkaz.id = id;
                vipiskaOrOtkaz.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали запись для отказа!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            sql = "select id As '№', fio AS 'ФИО', date AS 'Дата поступления', time AS 'Время поступления', diagnoz_mkb AS 'Диагноз МКБ', otdelenie AS 'Отделение' from pacient  where vipisan='false'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataView search = new DataView(table);
            DataGridPacient.ItemsSource = search;
        }
    }
}