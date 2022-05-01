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
using Lab5.Business;
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
        

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            Calculations[] cal = client.getList();
            List<Calculation> lcal = new List<Calculation>();
           foreach(var item in cal)
            {
                Calculation cax = new Calculation();
                cax.Id = item.Id;
                cax.RecentCalculations = item.RecentCalculations;
                lcal.Add(cax);
            }
            dgRecord.DataContext = lcal;
            
        }
    }
}
