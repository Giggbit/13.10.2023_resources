using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _13._10._2023_Ресурсы
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void UpdateUI() {
            txt_name.Name = eng.name;
            txt_surname.Name = eng.surname;
            txt_phone.Name = eng.number;
            ok.Content = eng.btn_ok;
            cancel.Content = eng.btn_cancle;
            language.Content = eng.lang;
        }

        public MainWindow() {
            InitializeComponent();
        }

        private void language_Click(object sender, RoutedEventArgs e) {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("eng");
            UpdateUI();
        }
    }
}
