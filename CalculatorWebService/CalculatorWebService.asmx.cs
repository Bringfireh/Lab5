using CalculatorWebService.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
            var ls = new List<Calculations>();
            return ls;
        }
        [WebMethod(Description = "This method writes the recent calculation into the DB")]
        public bool insertData(Compute com)
        {
            return true;
        }
    }
}
