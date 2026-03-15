using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Extensions
{
    public static class EmployeeExtension
    {
        public static double GetEmployeeAgeInYears(this vw_Employee employee)
        {
            try
            {
                var diff = DateTime.Now.Subtract((DateTime)employee?.HireDate);
                return diff.TotalDays/365;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
