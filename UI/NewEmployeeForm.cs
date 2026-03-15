using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
using BusinessLogic;

namespace UI
{
    public partial class NewEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        Employee _employee;
        public NewEmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            BindControls();
        }

        private void BindControls()
        {
            var mode = DataSourceUpdateMode.OnPropertyChanged;
            TxtFirstName.DataBindings.Add("EditValue", _employee, nameof(_employee.FirstName), true, mode);
            TxtLastName.DataBindings.Add("EditValue", _employee, nameof(_employee.LastName), true, mode);
            cbPrefix.DataBindings.Add("EditValue", _employee, nameof(_employee.Prefix), true, mode);
        }

        private void TxtFirstName_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFullName();
        }

        private void TxtLastName_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFullName();
        }

        private void UpdateFullName() //FullName
        {
            string fName = TxtFirstName.Text.Trim();
            string lName = TxtLastName.Text.Trim();

            TxtFullName.Text = $"{fName} {lName}".Trim();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            if (EmployeeBL.SaveEmployee(_employee))
            {
                Close();
            }
        }
    }
}