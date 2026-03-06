# DevExpress-WinForms-CRUD-Layered
Basic CRUD application using C#, DevExpress WinForms, and Entity Framework

# CRUD Documentation (C# .NET)

## Setup (Model, BusinessLogicLayer, UI)

1. Create a new project.
2. Right-click the Solution Name and select <b>Add > New Project > Class Library (.NET Framework)</b>. Name it <b><i>Model</i></b>.
3. Right-click the Solution Name and select <b>Add > New Project > Class Library (.NET Framework)</b>. Name it <b><i>BusinessLogicLayer</i></b>.
4. Right-click the Solution Name and select <b>Add > New Project > DevExpress vXX.X WinForms App Template Gallery</b>. Name it <b><i>UI</i></b>.

## Modifying the UI
Right-click the UI project, then select Add > Reference > Projects. Check:
[ ✔️ ] BusinessLogicLayer   [ ✔️ ] Model

## Modifying the BusinessLogicLayer
Right-click the BusinessLogicLayer project, then select Add > Reference > Projects. Check:
[ ✔️ ] BusinessLogicLayer   [ ✔️ ] Model

## Managing NuGet Packages

1. <b>EF Framework</b> (Model, BusinessLogicLayer, UI)
2. <b>FluentFTP</b> (BusinessLogicLayer)

---

### Creating Basic CRUD

1. In UI Form1.cs, open the Toolbox, drag a LayoutControl onto the form, and set Dock to Fill.
    - In the Toolbox, drag a GridControl inside the LayoutControl.
2. Set up the DataSource (Choose Data Source).
3. Right-click the Model project > Add > New Item > ADO.NET > Choose Data Source.
    - Go to <b>Model > App.config</b>, copy the full <b>connectionStrings</b>, and overwrite <b>UI > App.config</b> (Critical Part).
4. Go back to UI Form1.cs. Add BarButtonItems for <b>Add, Edit, Delete</b>.
5. Double-click the Add button. <i><b>(Note:</b> Make sure to rename all the BarButtonItems. In Properties, set them to <b>bbiAdd, bbiEdit, bbiDelete)</b>.</i>

5.1 Call the method using <b>AddEmployee();</b>
```csharp
private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
{
    AddEmployee();
}
```

5.2 Now create the <b>AddEmployee()</b> method above.
```csharp
private void AddEmployee()
{
    var employee = new Employee();
    var form = new NewEmployeeForm(employee);
    form.ShowDialog();
    LoadGridDataSource();
}
```

5.3 In the previous step, a new form is being created. In the UI project, <b>Right-click > Add > New Item > DevExpress Template Gallery > Choose a Blank Form</b>, and name it <b><i>NewEmployeeForm</i></b>. This should open the sample file below.

<b>NewEmployeeForm.cs:</b>

```csharp
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
namespace UI
{
    public partial class NewEmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }
    }
}
```

5.4 Go to <b>NewEmployeeForm.cs[Design]</b>, insert LayoutControl, insert <b>textEdit</b> for <i>FirstName</i> and <i>LastName</i> field. Insert simpleButton for saving new Employee.

5.5 Go to BusinessLogicLayer, <b>Right Click > New Item > Choose Class</b> named it <b><i>EmployeeBL.cs</i></b>

5.6 Now in the <i><b>EmployeeBL.cs</b></i>, create new static method that return list of <i>vw_Employee</i> objects from database using <i>Entity Framework</i>.

<b>EmployeeBL.cs:</b>

```csharp
using Model;
using System;
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
    }
}
```

5.7 Go back to First Created Form (Form1.cs), above the AddEmployee() method, create a new method called <b>LoadGridDataSource()</b>.

```csharp
        private void LoadGridDataSource()
        {
            var datasource = EmployeeBL.GetEmployees();
            gcEmployee.DataSource = datasource;
        }
```

5.8 As you can see in <b><i>Steps 5.6</b></i>, we already created the <b>EmployeeBL</b> at <b>BusinessLogicLayer</b>. The minimal setup is to rename the grid column and grid view located in Form1.cs[Design], go to properties and set it to <b>gcEmployee</b> and  <b>gvEmployee</b>.

The following below must the current states.

<b>Form1.cs:</b>
```csharp
using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void AddEmployee()
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
    }
}
```

<b>NewEmployeeForm.cs:</b>
```csharp
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
```

<b>EmployeeBL.cs</b>
```csharp
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

        public static bool SaveEmployee(Employee employee) //Add and Save
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
    }
}
```

Now we're done in <b>Add</b> and <b>Update</b> functionality, we're now going the proceed in Delete functionality.

#### Deleting Employee

1. Go to <b>Form1.cs[Design]</b>, Double Click the <i>bbiDelete</i>

1.1 Call the method using <b>DeleteEmployee();</b>

```csharp
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteEmployee();
        }
```

1.2 Now create the <b>DeleteEmployee()</b> method above.
```csharp
        private void DeleteEmployee()
        {
            var rowHandle = gvEmployee.FocusedRowHandle;
            var id = (int)gvEmployee.GetRowCellValue(rowHandle, "EmployeeID");
            var deleteEmployee = EmployeeBL.DeleteEmployee(id);
            LoadGridDataSource();
        }
```

1.3 Create a DeleteEmployee method on <b>EmployeeBL.cs</b>
```csharp
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
```

This should be the latest code of your <b>EmployeeBL.cs:</b>
``` csharp
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

```

We're Done in <b>Deleting  Employee</b>

Time to cleanup some UI:
Go to Form1.cs[Design] > OptionBehavior > <b>Editable = False, ReadOnly = True</b> 
Go to Form1.cs[Design] > Size > WindowState > <b>Set to Maximized</b>

## You can now start to improve your WinForm by your own. Hope this help! <3
