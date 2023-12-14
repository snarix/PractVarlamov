using System.Data;
using System.Security.Claims;
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
        int[] mas = new int[5];

        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
            DataGrid1.ItemsSource = mas.ToDataTable().DefaultView;
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            var selectedRow = DataGrid1.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int count = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(selectedRow.Row.ItemArray[i]);
                    count++;
                }

                Class class1 = new(mas);

                if (class1.Task())
                {
                    MessageBox.Show("Последовательность имеет все простые числа");
                }
                else
                {
                    MessageBox.Show("Последовательность имеет не простые числа");
                }
            }
            else
            {
                MessageBox.Show("Заполните DataGrid");
            }
        }
    }
}