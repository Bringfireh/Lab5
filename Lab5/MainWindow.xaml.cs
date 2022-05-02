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
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text + "+";
            }

        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text + "-";
            }

        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text + "*";
            }
               
            
            
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text + "/";
            }
            
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            string computation = txtDisplay.Text;
            if (computation.Contains("="))
            {
                MessageBox.Show("Clear screen before you will perform another operation", "Error");
            }
            else
            {

            
                if (computation != "")
                {
                    char[] c = new char[] { '*', '-', '+', '/' };

                    string[] values = computation.Split(c);
                    if (values.Length > 2)
                    {
                        MessageBox.Show("You cannot compute more than two terms. Ensure that you have only two numbers", "Error");
                    }
                    else
                    {
                        if (values[0] != "" && values[1] != "") { 
                            double firstnumber = Convert.ToDouble(values[0]);
                            double secondnumber = Convert.ToDouble(values[1]);
                            string[] symbolbuffer = computation.Split(values, StringSplitOptions.None);
                            string opSign = "";
                            foreach (var symbol in symbolbuffer)
                            {
                                if (symbol != "")
                                {
                                    opSign = symbol;
                                }
                            }
                            Inputs inputs = new Inputs();
                            inputs.firstnumber = firstnumber;
                            inputs.secondnumber = secondnumber;
                            Compute com = new Compute();
                            Calculator cal = new Calculator();
                            if (opSign == "+")
                            {
                                double result = cal.Add(inputs);
                                com.InputA = inputs.firstnumber;
                                com.InputB = inputs.secondnumber;
                                com.Operator = opSign;
                                com.Result = result;
                                cal.InsertData(com);
                                txtDisplay.Text = txtDisplay.Text + "=" + result ;
                            }
                            else if (opSign == "-")
                            {
                                double result = cal.Subtract(inputs);
                                com.InputA = inputs.firstnumber;
                                com.InputB = inputs.secondnumber;
                                com.Operator = opSign;
                                com.Result = result;
                                cal.InsertData(com);
                                txtDisplay.Text = txtDisplay.Text + "=" + result;
                            }
                            else if (opSign == "*")
                            {
                                double result = cal.Multiply(inputs);
                                com.InputA = inputs.firstnumber;
                                com.InputB = inputs.secondnumber;
                                com.Operator = opSign;
                                com.Result = result;
                                cal.InsertData(com);
                                txtDisplay.Text = txtDisplay.Text + "=" + result;

                            }
                            else if (opSign == "/")
                            {
                                double result = cal.Divide(inputs);
                                com.InputA = inputs.firstnumber;
                                com.InputB = inputs.secondnumber;
                                com.Operator = opSign;
                                com.Result = result;
                                cal.InsertData(com);
                                txtDisplay.Text = txtDisplay.Text + "=" + result;
                            }
                        }
                        
                    }
                }

            }
        }

        private void BtnViewCalc_Click(object sender, RoutedEventArgs e)
        {
            View vr = new View();
            vr.Show();
        }
    }
}
