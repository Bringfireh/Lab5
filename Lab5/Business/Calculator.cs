using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.CalculatorWebService;
namespace Lab5.Business
{
    class Calculator
    {
        public double Add(Inputs inputs)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            ComputationResult result = client.Add(inputs);
            return result.Value;
        }
        public double Subtract(Inputs inputs)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            ComputationResult result = client.Subtract(inputs);
            return result.Value;
        }
        public double Multiply(Inputs inputs)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            ComputationResult result = client.Multiply(inputs);
            return result.Value;
        }
        public double Divide(Inputs inputs)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            ComputationResult result = client.Divide(inputs);
            return result.Value;
        }
        public List<Calculation> GetCalculationList()
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            Calculations[] cal = client.getList();
            List<Calculation> lcal = new List<Calculation>();
            foreach (var item in cal)
            {
                Calculation cax = new Calculation();
                cax.Id = item.Id;
                cax.RecentCalculations = item.RecentCalculations;
                lcal.Add(cax);
            }
            return lcal;
        }
        public List<Calculation> InsertData(Compute computationdata)
        {
            CalculatorWebServiceSoapClient client = new CalculatorWebServiceSoapClient();
            Calculations[] cal = client.getList();
            List<Calculation> lcal = new List<Calculation>();
            foreach (var item in cal)
            {
                Calculation cax = new Calculation();
                cax.Id = item.Id;
                cax.RecentCalculations = item.RecentCalculations;
                lcal.Add(cax);
            }
            return lcal;
        }
    }
}
