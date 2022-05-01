using CalculatorWebService.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Data;
namespace CalculatorWebService
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(true)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(Description = "This method adds two numbers")]
        public ComputationResult Add(Inputs inputs)
        {
            double result = (inputs.firstnumber + inputs.secondnumber);
            string Operator = "+";
            Compute com = new Compute();
            com.InputA = inputs.firstnumber;
            com.InputB = inputs.secondnumber;
            com.Operator = Operator;
            com.Result = result;
            insertData(com);
            ComputationResult computationResult = new ComputationResult();
            computationResult.Message = "Successfull";
            computationResult.Value = result;
            return computationResult;
        }
        [WebMethod(Description = "This method divides two numbers")]
        public ComputationResult Divide(Inputs inputs)
        {
            double result = (inputs.firstnumber / inputs.secondnumber); 
            string Operator = "/";
            Compute com = new Compute();
            com.InputA = inputs.firstnumber;
            com.InputB = inputs.secondnumber;
            com.Operator = Operator;
            com.Result = result;
            insertData(com);
            ComputationResult computationResult = new ComputationResult();
            computationResult.Message = "Successfull";
            computationResult.Value = result;
            return computationResult;
        }
        [WebMethod(Description = "This method determines the product of two numbers")]
        public ComputationResult Multiply(Inputs inputs)
        {
            double result = (inputs.firstnumber * inputs.secondnumber);
            string Operator = "*";
            Compute com = new Compute();
            com.InputA = inputs.firstnumber;
            com.InputB = inputs.secondnumber;
            com.Operator = Operator;
            com.Result = result;
            insertData(com);
            ComputationResult computationResult = new ComputationResult();
            computationResult.Message = "Successfull";
            computationResult.Value = result;
            return computationResult;
        }
        [WebMethod(Description = "This method determines the difference between two numbers")]
        public ComputationResult Subtract(Inputs inputs)
        {
            double result = (inputs.firstnumber - inputs.secondnumber);
            string Operator = "-";
            Compute com = new Compute();
            com.InputA = inputs.firstnumber;
            com.InputB = inputs.secondnumber;
            com.Operator = Operator;
            com.Result = result;
            insertData(com);
            ComputationResult computationResult = new ComputationResult();
            computationResult.Message = "Successfull";
            computationResult.Value = result;
            return computationResult;
            
        }


        [WebMethod(Description = "Returns the Calculations saved in the database")]
        public List<Calculations> getList()
        {
            //var calcList = get all list;
            
            Db db = new Db();
            db.InitializeDb();
            DataTable dt = db.GetAllCalculations();
            List<Calculations> calResultList = new List<Calculations>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Calculations calculation = new Calculations();
                calculation.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                calculation.RecentCalculations = dt.Rows[i]["RecentCalculations"].ToString();
                calResultList.Add(calculation);
            }
            return calResultList;
        }
        [WebMethod(Description = "This method writes the recent calculation into the DB")]
        public ComputationResult insertData(Compute computationData)
        {
            Db db = new Db();
            db.InitializeDb();
            int id = db.GetAllCalculations().Rows.Count + 1;
            string RecentCalculation = computationData.InputA + computationData.Operator + computationData.InputB + "=" + computationData.Result;
            bool isSuccessful=db.Insert(id, RecentCalculation);
            ComputationResult computationResult = new ComputationResult();
            if (isSuccessful)
            {
               
                computationResult.Message = "Successful";
                computationResult.Value = 00;
            }
            else
            {
                computationResult.Message = "Failure";
                computationResult.Value = 01;
            }
            
            return computationResult;
        }
    }
}
