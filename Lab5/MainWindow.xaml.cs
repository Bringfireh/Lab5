using System;
using System.Collections.Generic;
using System.Data;
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
using Lab5.CalculatorWebService;
namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void testGetList()
        {
           
        }

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            Calculations[] cal = client.getList();
            dgRecord.DataContext = cal.ToList();
            //DataTable dt = new DataTable();
           // dt.Load(cal);
        }
    }
}
