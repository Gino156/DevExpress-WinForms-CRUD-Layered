using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Model;

namespace UI
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1(Employee _employee)
        {
            InitializeComponent();
            //_employee = employee;
        }


    }
}
