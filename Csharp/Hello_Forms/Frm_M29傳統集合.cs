using System;
using System.Collections;
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
    public partial class Frm_M29傳統集合 : Form
    {
        public Frm_M29傳統集合()
        {
            InitializeComponent();
        }

        ArrayList listEMP = new ArrayList();

        void ShowEmployee()
        {
            lab_EmployeeList.Text = "員工清單\n";
            for (int i =0; i < listEMP.Count; i++)
            {
                lab_EmployeeList.Text += $"員工：{((Employee)listEMP[i]).employeeName} ， " +
    $"年齡：{((Employee)listEMP[i]).employeeAge}歲\n";
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp ;
            emp.employeeName = txtEMP_Name.Text;
            emp.employeeAge = int.Parse(txtEMP_Age.Text);
            listEMP.Add(emp);
            ShowEmployee();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.employeeName = txtEMP_Name.Text;
            emp.employeeAge = int.Parse(txtEMP_Age.Text);
            listEMP.Insert(0, emp);
            ShowEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Employee emp;
            //emp.employeeName = txtEMP_Name.Text;
            //emp.employeeAge = int.Parse(txtEMP_Age.Text);
            listEMP.Clear();
            ShowEmployee();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listEMP.RemoveAt(0);
            ShowEmployee();
        }
    }
}
