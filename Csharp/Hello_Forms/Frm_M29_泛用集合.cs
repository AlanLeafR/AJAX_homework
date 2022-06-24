using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class Frm_M29_泛用集合 : Form
    {
        public Frm_M29_泛用集合()
        {
            InitializeComponent();
        }

        List<Employee> listEmp = new List<Employee>();

        void ShowEmployee()
        {
            lab_EmployeeList.Text = "員工清單\n";
            
    //        for (int i = 0; i < listEmp.Count; i++)
    //        {
    //            lab_EmployeeList.Text += $"員工：{listEmp[i].employeeName} ， " +
    //$"年齡：{listEmp[i].employeeAge}歲\n";
    //        }

            foreach (Employee Item in listEmp)
            {
                lab_EmployeeList.Text += $"員工：{Item.employeeName} ， " +
    $"年齡：{Item.employeeAge}歲\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.employeeName = txtEMP_Name.Text;
            emp.employeeAge = int.Parse(txtEMP_Age.Text);

            listEmp.Add(emp);
            ShowEmployee();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listEmp.Clear();
            ShowEmployee();
        }
    }
}
