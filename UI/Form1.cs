using BusinessLogic;
using DevExpress.XtraEditors;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Extensions;

namespace UI
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Employee _employee;
        public Form1()
        {
            InitializeComponent();
            LoadGridDataSource();
        }

        private void LoadGridDataSource()
        {
            var datasource = EmployeeBL.GetEmployees();
            gcEmployee.DataSource = datasource;
        }

        private void AddEmployee() //Add
        {
            var employee = new Employee();
            var form = new NewEmployeeForm(employee);
            form.ShowDialog();
            LoadGridDataSource();
        }
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddEmployee();
        }

        private void EditEmployee() //Edit
        {
            var rowHandle = gvEmployee.FocusedRowHandle;
            var id = (int)gvEmployee.GetRowCellValue(rowHandle, "EmployeeID");
            var employee = EmployeeBL.GetEmployeeById(id);
            var form = new NewEmployeeForm(employee);
            form.ShowDialog();
            LoadGridDataSource();
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditEmployee();
        }

        private void DeleteEmployee() //Delete
        {
            var rowHandle = gvEmployee.FocusedRowHandle;
            var id = (int)gvEmployee.GetRowCellValue(rowHandle, "EmployeeID");
            var deleteEmployee = EmployeeBL.DeleteEmployee(id);
            LoadGridDataSource();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteEmployee();
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) //Export
        {
            gvEmployee.ShowRibbonPrintPreview();
        }

        private void bbiTenure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rowHandle = gvEmployee.FocusedRowHandle;
            var id = (int)gvEmployee.GetRowCellValue(rowHandle, "EmployeeID");
            var tenurecalc = EmployeeBL.GetEmployeeViewById(id);
            XtraMessageBox.Show($"Employee Age: {(tenurecalc.GetEmployeeAgeInYears()).ToString("F2")} years");
        }

        /*-------------------------------*/

        private void gvEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var empId = (int)gvEmployee.GetRowCellValue(gvEmployee.FocusedRowHandle, "EmployeeID");
                var employee = EmployeeBL.GetEmployeeById(empId);
                _employee = employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Occurred: {ex.Message}");
            }
        }

        private void gvEmployee_DoubleClick(object sender, EventArgs e)
        {
            EditEmployee();
        }
    }
}
