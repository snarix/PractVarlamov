using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractVarlamov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
            int[] mas = new int[5];
            DataGrid1.ItemsSource = mas.ToDataTable().DefaultView;
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            
        }
    }
}