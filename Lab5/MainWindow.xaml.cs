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
            Calculator cal = new Calculator();
            
            //dgRecord.DataContext = cal.GetCalculationList();

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 1;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 3;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 4;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 5;
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 7;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 8;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 9;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 0;
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("+") == true )
            {
                MessageBox.Show("You can not Add more than two numbers!","Error");
            }
            else if( txtDisplay.Text == "")
            {
                MessageBox.Show("You can not Add to nothing!", "Error");
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "+";
            }
            
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("-") == true)
            {
                MessageBox.Show("You can not Add more than two numbers!", "Error");
            }
            else if (txtDisplay.Text == "")
            {
                MessageBox.Show("You can not Subtract from nothing!", "Error");
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "-";
            }
           
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("*") == true)
            {
                MessageBox.Show("You can not Multiply more than two numbers!", "Error");
            }
            else if (txtDisplay.Text == "")
            {
                MessageBox.Show("You can not Multiply by nothing!", "Error");
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "*";
            }
            
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("/") == true)
            {
                MessageBox.Show("You can not divide more than two numbers!", "Error");
            }
            else if (txtDisplay.Text == "")
            {
                MessageBox.Show("You can not divide by nothing!", "Error");
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "/";
            }
            
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "=";
        }
    }
}
