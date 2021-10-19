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
    /// Логика взаимодействия для FormAdd.xaml
    /// </summary>
    public partial class FormAdd : Window
    {
        public string text;
        public string sql;
        string connectionStr = @"Data Source=Base\base.sqlite;Version=3";
        DataSet dataSet = new DataSet();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridAll.Items.Clear();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connectionStr);
            adapter.Fill(dataSet, "mkb");
            DataGridAll.ItemsSource = dataSet.Tables["mkb"].DefaultView;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void RowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView rowView = DataGridAll.SelectedValue as DataRowView;
            if (this.textTitle.Text == "СПРАВОЧНИК ОТДЕЛЕНИЯ")
            {
                text = rowView[1].ToString();
                PacientAddEdit pacientAddEdit = new PacientAddEdit();
                pacientAddEdit.text = text;
                this.Close();
            }

            if (this.textTitle.Text == "СПРАВОЧНИК МКБ")
            {
                text = rowView[2].ToString();
                PacientAddEdit pacientAddEdit = new PacientAddEdit();
                pacientAddEdit.text = text;
                this.Close();
            }
        }
    }
}
