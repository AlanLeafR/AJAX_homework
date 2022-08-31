using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPrj
{
    public partial class Frm會員註冊 : Form
    {
        public Frm會員註冊()
        {
            InitializeComponent();
        }

        TravelerEntities dbContext = new TravelerEntities();
        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            Member_Info_List mem = new Member_Info_List()
            {
                Title = txtTitle.Text,
                Name = txtName.Text,
                Phone_Number = txtPhone_Number.Text,
                Email = txtEmail.Text,
                Nationality = cmbNationality.SelectedItem.ToString(),
                bonus_points = 0,
                password = txtPassword.Text,
                ID_number = txtIDNumber.Text
            };

            //防呆，如果有欄位沒輸入到就會跳訊息要求填寫所有欄位
            var properties = mem.GetType().GetProperties();
            var values = properties.Select(s => s.GetValue(mem)).ToList();
           
            foreach (var p in values)
            {
                if (p.ToString() == "") 
                {
                    MessageBox.Show("有欄位沒輸入");
                    return;
                }
             }

            //將會員資料存進資料庫
            this.dbContext.Member_Info_Lists.Add(mem);
            this.dbContext.SaveChanges();
            MessageBox.Show("輸入資料成功");

            //清除TextBox欄位資訊
            foreach (Control c in this.Controls) 
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

    }
}
