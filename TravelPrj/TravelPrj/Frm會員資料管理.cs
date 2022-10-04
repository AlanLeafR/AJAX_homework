using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPrj
{
    public partial class Frm會員資料管理 : Form
    {
        public Frm會員資料管理()
        {
            InitializeComponent();
        }
        TravelerEntities dbContext = new TravelerEntities();
        private void Method_SearchAllMember()
        {
            var q = from member in dbContext.Member_Info_Lists
                    select member;
            dataGridView1.DataSource = q.ToList();
            //把Order欄位隱藏起來
            dataGridView1.Columns[9].Visible = false;
        }
        private void btnMemberList_Click(object sender, EventArgs e)
        {
            Method_SearchAllMember();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {

            var q = from member in dbContext.Member_Info_Lists
                    where member.Name == txtSearchMember.Text
                    select member;
            dataGridView1.DataSource = q.ToList();
            //把Order欄位隱藏起來
            dataGridView1.Columns[9].Visible = false;
        }
       
        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            //檢查有沒有輸入查詢的字串，有的話就打開查詢按鈕
            //三元運算子，如果txtSearchMember.Text不是" "的話就打開按鈕
            string s = txtSearchMember.Text;
            btnSearchMember.Enabled = s == "" ? false : true;
            
            //如果空值則搜尋全部會員資料
            if(s=="")
                Method_SearchAllMember();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // e.RowIndex
        }
    }
}
