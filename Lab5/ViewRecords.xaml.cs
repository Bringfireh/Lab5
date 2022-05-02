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
using Lab5.Business;
namespace Lab5
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
        }

        private void BtnViewAllRecords_Click(object sender, RoutedEventArgs e)
        {
            Calculator cal = new Calculator();
            dgRecord.DataContext =cal.GetCalculationList() ;
        }
    }
}
