
namespace LinqLabs.作業
{
    partial class Frm作業_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Season = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Section_Bike = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Year_Bike = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Season_Bike = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_all_Bike = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aw2019_DataSet1 = new LinqLabs.aw2019_DataSet();
            this.productPhotoTableAdapter1 = new LinqLabs.aw2019_DataSetTableAdapters.ProductPhotoTableAdapter();
            this.lab_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aw2019_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lab_count);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Year);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Season);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Section_Bike);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Year_Bike);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Season_Bike);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_all_Bike);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1243, 698);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(411, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 136;
            this.label10.Text = "年:";
            // 
            // cmb_Year
            // 
            this.cmb_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(481, 152);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(157, 23);
            this.cmb_Year.TabIndex = 135;
            this.cmb_Year.Text = "2008";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(411, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 132;
            this.label8.Text = "季:";
            // 
            // cmb_Season
            // 
            this.cmb_Season.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmb_Season.FormattingEnabled = true;
            this.cmb_Season.Items.AddRange(new object[] {
            "第一季",
            "第二季",
            "第三季",
            "第四季"});
            this.cmb_Season.Location = new System.Drawing.Point(481, 195);
            this.cmb_Season.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.Size = new System.Drawing.Size(157, 23);
            this.cmb_Season.TabIndex = 131;
            this.cmb_Season.Text = "第一季";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(783, 95);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(217, 25);
            this.dateTimePicker2.TabIndex = 130;
            this.dateTimePicker2.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // btn_Section_Bike
            // 
            this.btn_Section_Bike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Section_Bike.Location = new System.Drawing.Point(60, 93);
            this.btn_Section_Bike.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Section_Bike.Name = "btn_Section_Bike";
            this.btn_Section_Bike.Size = new System.Drawing.Size(319, 35);
            this.btn_Section_Bike.TabIndex = 81;
            this.btn_Section_Bike.Text = "     區間腳踏車 ";
            this.btn_Section_Bike.UseVisualStyleBackColor = false;
            this.btn_Section_Bike.Click += new System.EventHandler(this.btn_Section_Bike_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(730, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 129;
            this.label7.Text = "~";
            // 
            // btn_Year_Bike
            // 
            this.btn_Year_Bike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Year_Bike.Location = new System.Drawing.Point(60, 148);
            this.btn_Year_Bike.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Year_Bike.Name = "btn_Year_Bike";
            this.btn_Year_Bike.Size = new System.Drawing.Size(319, 35);
            this.btn_Year_Bike.TabIndex = 82;
            this.btn_Year_Bike.Text = "     某年腳踏車 ";
            this.btn_Year_Bike.UseVisualStyleBackColor = false;
            this.btn_Year_Bike.Click += new System.EventHandler(this.btn_Year_Bike_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 93);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 25);
            this.dateTimePicker1.TabIndex = 128;
            this.dateTimePicker1.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // btn_Season_Bike
            // 
            this.btn_Season_Bike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Season_Bike.ForeColor = System.Drawing.Color.Black;
            this.btn_Season_Bike.Location = new System.Drawing.Point(60, 191);
            this.btn_Season_Bike.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Season_Bike.Name = "btn_Season_Bike";
            this.btn_Season_Bike.Size = new System.Drawing.Size(319, 35);
            this.btn_Season_Bike.TabIndex = 83;
            this.btn_Season_Bike.Text = "     某季腳踏車  ? 有幾筆 ?";
            this.btn_Season_Bike.UseVisualStyleBackColor = false;
            this.btn_Season_Bike.Click += new System.EventHandler(this.btn_Season_Bike_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(406, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 127;
            this.label3.Text = "區間:";
            // 
            // btn_all_Bike
            // 
            this.btn_all_Bike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_all_Bike.Location = new System.Drawing.Point(60, 51);
            this.btn_all_Bike.Margin = new System.Windows.Forms.Padding(4);
            this.btn_all_Bike.Name = "btn_all_Bike";
            this.btn_all_Bike.Size = new System.Drawing.Size(319, 35);
            this.btn_all_Bike.TabIndex = 84;
            this.btn_all_Bike.Text = "     All 腳踏車 ";
            this.btn_all_Bike.UseVisualStyleBackColor = false;
            this.btn_all_Bike.Click += new System.EventHandler(this.btn_all_Bike_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(57, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 15);
            this.label6.TabIndex = 105;
            this.label6.Text = "LINQ to AdventureWorks DataSet";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1243, 442);
            this.splitContainer2.SplitterDistance = 521;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(4, 0);
            this.lblMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(509, 33);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "Master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 74;
            this.dataGridView1.Size = new System.Drawing.Size(509, 397);
            this.dataGridView1.TabIndex = 71;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 438);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(4, 0);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(706, 33);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // aw2019_DataSet1
            // 
            this.aw2019_DataSet1.DataSetName = "aw2019_DataSet";
            this.aw2019_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_count.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_count.Location = new System.Drawing.Point(677, 192);
            this.lab_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(86, 24);
            this.lab_count.TabIndex = 137;
            this.lab_count.Text = "共幾筆：";
            // 
            // Frm作業_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 698);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm作業_2";
            this.Text = "Frm作業_2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aw2019_DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Season;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_Section_Bike;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Year_Bike;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Season_Bike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_all_Bike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private aw2019_DataSet aw2019_DataSet1;
        private aw2019_DataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private System.Windows.Forms.Label lab_count;
    }
}