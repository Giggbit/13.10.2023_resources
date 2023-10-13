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

namespace _13._10._2023_class_work
{

    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void language_Click(object sender, RoutedEventArgs e){
            ResourceDictionary rs = new ResourceDictionary();
            rs.Source = new Uri("Language.xaml", UriKind.Relative);
            Application.Current.Resources.MergedDictionaries[0] = rs;
        }
    }
}
