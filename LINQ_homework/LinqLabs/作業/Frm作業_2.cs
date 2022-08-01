using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs.作業
{
    public partial class Frm作業_2 : Form
    {
        public Frm作業_2()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(aw2019_DataSet1.ProductPhoto);
            MakeYearComboList();
            dateTimePicker2.Value = DateTime.Now;
        }
        //建構方法
        //===========================================
        void MakeYearComboList()
        {
            //var q = from p in this.aw2019_DataSet1.ProductPhoto
            //        orderby p.ModifiedDate
            //        select p.ModifiedDate.Year;

            var q = this.aw2019_DataSet1.ProductPhoto.OrderBy(p => p.ModifiedDate)
                .Select(p => p.ModifiedDate.Year).ToList().Distinct();

            foreach (var Item in q)
            {
                cmb_Year.Items.Add(Item);
            }
        }

        //練習字典運用
        Dictionary<string, int[]> dic = new Dictionary<string, int[]>()
        {
            { "第一季", new int[] { 1,2,3} },
                        { "第二季", new int[] { 4,5,6} },
                                    { "第三季", new int[] { 7,8,9} },
                                                { "第四季", new int[] { 10,11,12} },
        };

        //https://ithelp.ithome.com.tw/questions/10198887
        //把binay[] 轉成 img
        public Image ConvertToImage(byte[] picBinary)
        {
            
            Image image = null;
            using (MemoryStream ms = new MemoryStream(picBinary))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        //button物件
        //===========================================
        private void btn_all_Bike_Click(object sender, EventArgs e)
        {
            var q = from p in aw2019_DataSet1.ProductPhoto
                    select p;
            dataGridView1.DataSource = q.ToList();

            var img = aw2019_DataSet1.ProductPhoto.Select(p => p.LargePhoto).ToList();
            
            pictureBox1.Image = ConvertToImage(img[1]);
            //pictureBox1.Image = img;

        }

        private void btn_Year_Bike_Click(object sender, EventArgs e)
        {
            //var q = from p in this.aw2019_DataSet1.ProductPhoto
            //        where p.ModifiedDate.Year == Convert.ToInt32(cmb_Year.Text)
            //        select p;

            var q = this.aw2019_DataSet1.ProductPhoto
                          .Where(p => p.ModifiedDate.Year == Convert.ToInt32(cmb_Year.Text));

            dataGridView1.DataSource = q.ToList();
        }

        private void btn_Section_Bike_Click(object sender, EventArgs e)
        {
            var q = from p in this.aw2019_DataSet1.ProductPhoto
                    orderby p.ModifiedDate.Date
                    where p.ModifiedDate > dateTimePicker1.Value && p.ModifiedDate.Date < dateTimePicker2.Value
                    select p;
            dataGridView1.DataSource = q.ToList();
        }

        private void btn_Season_Bike_Click(object sender, EventArgs e)
        {
            //練習利用字典+lambda表示式查詢
            //ComboList.SelectedItem → 在ComboList內選取到的Item
            string quarter = (string)cmb_Season.SelectedItem;

            var q = this.aw2019_DataSet1.ProductPhoto.Where
                (p => dic[quarter].Contains(p.ModifiedDate.Month) && p.ModifiedDate.Year == Convert.ToInt32(cmb_Year.Text));
            //找尋符合年份以及第O季的資料

            dataGridView1.DataSource = q.ToList();
            lab_count.Text = $"共有 {q.ToList().Count} 筆";
        }
    }
}
