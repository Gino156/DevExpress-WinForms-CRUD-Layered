using Model;
using System;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeBL
    {
        public static List<vw_Employee> GetEmployees()
        {
            return new FTPAppEntities().vw_Employee
                .ToList();
        }

        public static Employee GetEmployeeById(int employeeId)
        {
            return new FTPAppEntities()
                .Employees.SingleOrDefault(x => x.EmployeeID == employeeId);
        }

        public static vw_Employee GetEmployeeViewById(int employeeId)
        {
            return new FTPAppEntities()
                .vw_Employee.SingleOrDefault(x => x.EmployeeID == employeeId);
        }

        public static bool SaveEmployee(Employee employee) //Add
        {
            try
            {
                using (var context = new FTPAppEntities())
                {
                    var existingRecord = context
                        .Employees.SingleOrDefault(x => x.EmployeeID == employee.EmployeeID);

                    if (existingRecord != null) //Update
                    {
                        existingRecord.FirstName = employee.FirstName;
                        existingRecord.LastName = employee.LastName; 
                    }
                    else
                    {
                        context.Employees.Add(employee);
                    }
                    context.SaveChanges();
                    XtraMessageBox.Show("Employee Saved");
                }
                return true;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Failed to saved an employee.");
                return false;
            }
        }

        public static bool DeleteEmployee(int employeeId)
        {
            try
            {
                using (var context = new FTPAppEntities())
                {
                    var existingRecord = context
                        .Employees.SingleOrDefault(x => x.EmployeeID == employeeId);
                    if (existingRecord != null)
                    {
                        context.Employees.Remove(existingRecord);
                        context.SaveChanges();
                        XtraMessageBox.Show("Employee Deleted");
                        return true;
                    }
                }
                throw new Exception();
            }
            catch
            {
                XtraMessageBox.Show("Failed to delete employee");
                return false;
            }
        }
    }
}
