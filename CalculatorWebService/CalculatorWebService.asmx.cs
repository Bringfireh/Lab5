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
        public double Add(Inputs inputs)
        {
            return (inputs.firstnumber + inputs.secondnumber);
        }
        [WebMethod(Description = "This method divides two numbers")]
        public double Divide(Inputs inputs)
        {
            return (inputs.firstnumber / inputs.secondnumber);
        }
        [WebMethod(Description = "This method determines the product of two numbers")]
        public double Multiply(Inputs inputs)
        {
            return (inputs.firstnumber * inputs.secondnumber);
        }
        [WebMethod(Description = "This method determines the difference between two numbers")]
        public double Subtract(Inputs inputs)
        {
            return (inputs.firstnumber - inputs.secondnumber);
        }


        [WebMethod(Description = "Returns the Calculations saved in the database")]
        public List<Calculations> getList()
        {
            //var calcList = get all list;
            
            Db db = new Db();
            db.InitializeDb();
            DataTable dt = db.GetAllCalculations();
            List<Calculations> calList = new List<Calculations>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Calculations cal = new Calculations();
                cal.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                cal.RecentCalculations = dt.Rows[i]["RecentCalculations"].ToString();
                calList.Add(cal);
            }
            return calList;
        }
        [WebMethod(Description = "This method writes the recent calculation into the DB")]
        public bool insertData(Compute com)
        {
            Db db = new Db();
            db.InitializeDb();
            int id = db.GetAllCalculations().Rows.Count + 1;
            string RecentCalculation = com.InputA + com.Operator + com.InputB + "=" + com.Result;
            db.Insert(id, RecentCalculation);
            return true;
        }
    }
}
