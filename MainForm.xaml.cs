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
using System.IO.Compression;
using System.IO;

namespace MISBolnica
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public string id;
        public string login;
        public string fio;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitUserButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    Pacient framePacient = new Pacient();
                    Frame.Navigate(framePacient);
                    break;
                case 1:
                    Otkazi otkazi = new Otkazi();
                    Frame.Navigate(otkazi);
                    otkazi.user = fio;
                    break;
                case 2:
                    Vipisanie vipisanie = new Vipisanie();
                    Frame.Navigate(vipisanie);
                    vipisanie.user = fio;
                    break;
                case 3:
                    Report report = new Report();
                    Frame.Navigate(report);
                    break;
                case 4:
                    Settings settings = new Settings();
                    Frame.Navigate(settings);
                    break;
                case 5:
                    About frameAbout = new About();
                    Frame.Navigate(frameAbout);
                    break;
                default:
                    break;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Pacient framePacient = new Pacient();
            Frame.Navigate(framePacient);
        }

        private void CopyBase_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите создать резервную копию БД?", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {

                string pathBD = Environment.CurrentDirectory + @"\Base";
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();
                string pathBackUp = Environment.CurrentDirectory + @"\BackUP\" + date + ".zip";

                File.Delete(Environment.CurrentDirectory + @"\\tmp\base.sqlite");
                File.Copy(pathBD + @"\\base.sqlite", Environment.CurrentDirectory + @"\\tmp\base.sqlite");
                if (File.Exists(pathBackUp))
                {
                    if (MessageBox.Show("Файл"+pathBackUp+" уже существует, заменить его?", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        File.Delete(pathBackUp);
                        ZipFile.CreateFromDirectory(Environment.CurrentDirectory + @"\\tmp", pathBackUp);
                        MessageBox.Show("Файл успешно заменен.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        File.Delete(Environment.CurrentDirectory + @"\\tmp\base.sqlite");
                    }
                }
                else
                {
                    ZipFile.CreateFromDirectory(Environment.CurrentDirectory + @"\\tmp", pathBackUp);
                    MessageBox.Show("Файл" + pathBackUp + " успешно создан.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    File.Delete(Environment.CurrentDirectory + @"\\tmp\base.sqlite");
                }
                
            }
 
        }

        private void ButtonMkb_Click(object sender, RoutedEventArgs e)
        {
            Mkb frameMkb = new Mkb();
            Frame.Navigate(frameMkb);
        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void ButtonOtdelenia_Click(object sender, RoutedEventArgs e)
        {
            Otdelenia otdelenia = new Otdelenia();
            Frame.Navigate(otdelenia);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Settings frameSettings = new Settings();
            Frame.Navigate(frameSettings);
        }
    }
}
