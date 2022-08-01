
namespace LinqLabs.作業
{
    partial class Frm作業_4
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NwOders_GroupByYearMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Classification_int = new System.Windows.Forms.Button();
            this.btn_Top5_Sales_Price = new System.Windows.Forms.Button();
            this.btn_SalesFigures = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Classification_FileYear = new System.Windows.Forms.Button();
            this.btn_NW_Products = new System.Windows.Forms.Button();
            this.btn_Classification_FileSize = new System.Windows.Forms.Button();
            this.btn_Top5_SalesPerson = new System.Windows.Forms.Button();
            this.btn_NwOders_GroupByYear = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.btn_IsOver300 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 134;
            this.label3.Text = "LINQ to Northwind Entity";
            // 
            // btn_NwOders_GroupByYearMonth
            // 
            this.btn_NwOders_GroupByYearMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_NwOders_GroupByYearMonth.Location = new System.Drawing.Point(13, 487);
            this.btn_NwOders_GroupByYearMonth.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NwOders_GroupByYearMonth.Name = "btn_NwOders_GroupByYearMonth";
            this.btn_NwOders_GroupByYearMonth.Size = new System.Drawing.Size(618, 51);
            this.btn_NwOders_GroupByYearMonth.TabIndex = 133;
            this.btn_NwOders_GroupByYearMonth.Text = " Orders -  Group by 年 / 月";
            this.btn_NwOders_GroupByYearMonth.UseVisualStyleBackColor = false;
            this.btn_NwOders_GroupByYearMonth.Click += new System.EventHandler(this.btn_NwOders_GroupByYearMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 126;
            this.label4.Text = "LINQ - GroupBy";
            // 
            // btn_Classification_int
            // 
            this.btn_Classification_int.BackColor = System.Drawing.Color.Blue;
            this.btn_Classification_int.ForeColor = System.Drawing.Color.White;
            this.btn_Classification_int.Location = new System.Drawing.Point(6, 66);
            this.btn_Classification_int.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Classification_int.Name = "btn_Classification_int";
            this.btn_Classification_int.Size = new System.Drawing.Size(618, 51);
            this.btn_Classification_int.TabIndex = 85;
            this.btn_Classification_int.Text = "int[]  分三群 - No LINQ";
            this.btn_Classification_int.UseVisualStyleBackColor = false;
            this.btn_Classification_int.Click += new System.EventHandler(this.btn_Classification_int_Click);
            // 
            // btn_Top5_Sales_Price
            // 
            this.btn_Top5_Sales_Price.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Top5_Sales_Price.Location = new System.Drawing.Point(15, 686);
            this.btn_Top5_Sales_Price.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Top5_Sales_Price.Name = "btn_Top5_Sales_Price";
            this.btn_Top5_Sales_Price.Size = new System.Drawing.Size(658, 51);
            this.btn_Top5_Sales_Price.TabIndex = 91;
            this.btn_Top5_Sales_Price.Text = "     NW 產品最高單價前 5 筆 (包括類別名稱)";
            this.btn_Top5_Sales_Price.UseVisualStyleBackColor = false;
            this.btn_Top5_Sales_Price.Click += new System.EventHandler(this.btn_Top5_Sales_Price_Click);
            // 
            // btn_SalesFigures
            // 
            this.btn_SalesFigures.BackColor = System.Drawing.Color.LightGreen;
            this.btn_SalesFigures.Location = new System.Drawing.Point(17, 560);
            this.btn_SalesFigures.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SalesFigures.Name = "btn_SalesFigures";
            this.btn_SalesFigures.Size = new System.Drawing.Size(658, 54);
            this.btn_SalesFigures.TabIndex = 129;
            this.btn_SalesFigures.Text = "總銷售金額";
            this.btn_SalesFigures.UseVisualStyleBackColor = false;
            this.btn_SalesFigures.Click += new System.EventHandler(this.btn_SalesFigures_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Location = new System.Drawing.Point(16, 885);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(658, 51);
            this.button7.TabIndex = 92;
            this.button7.Text = "     NW 產品有任何一筆單價大於300 ?";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "LINQ to FileInfo[]";
            // 
            // btn_Classification_FileYear
            // 
            this.btn_Classification_FileYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Classification_FileYear.ForeColor = System.Drawing.Color.Black;
            this.btn_Classification_FileYear.Location = new System.Drawing.Point(9, 247);
            this.btn_Classification_FileYear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Classification_FileYear.Name = "btn_Classification_FileYear";
            this.btn_Classification_FileYear.Size = new System.Drawing.Size(618, 51);
            this.btn_Classification_FileYear.TabIndex = 93;
            this.btn_Classification_FileYear.Text = "  依 年 分組檔案 (大=>小)";
            this.btn_Classification_FileYear.UseVisualStyleBackColor = false;
            this.btn_Classification_FileYear.Click += new System.EventHandler(this.btn_Classification_FileYear_Click);
            // 
            // btn_NW_Products
            // 
            this.btn_NW_Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_NW_Products.ForeColor = System.Drawing.Color.Black;
            this.btn_NW_Products.Location = new System.Drawing.Point(17, 361);
            this.btn_NW_Products.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NW_Products.Name = "btn_NW_Products";
            this.btn_NW_Products.Size = new System.Drawing.Size(618, 51);
            this.btn_NW_Products.TabIndex = 94;
            this.btn_NW_Products.Text = "NW Products 低中高 價產品 ";
            this.btn_NW_Products.UseVisualStyleBackColor = false;
            this.btn_NW_Products.Click += new System.EventHandler(this.btn_NW_Products_Click);
            // 
            // btn_Classification_FileSize
            // 
            this.btn_Classification_FileSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Classification_FileSize.ForeColor = System.Drawing.Color.Black;
            this.btn_Classification_FileSize.Location = new System.Drawing.Point(15, 183);
            this.btn_Classification_FileSize.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Classification_FileSize.Name = "btn_Classification_FileSize";
            this.btn_Classification_FileSize.Size = new System.Drawing.Size(618, 51);
            this.btn_Classification_FileSize.TabIndex = 95;
            this.btn_Classification_FileSize.Text = "依 檔案大小 分組檔案 (大=>小)";
            this.btn_Classification_FileSize.UseVisualStyleBackColor = false;
            this.btn_Classification_FileSize.Click += new System.EventHandler(this.btn_Classification_FileSize_Click);
            // 
            // btn_Top5_SalesPerson
            // 
            this.btn_Top5_SalesPerson.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Top5_SalesPerson.Location = new System.Drawing.Point(17, 624);
            this.btn_Top5_SalesPerson.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Top5_SalesPerson.Name = "btn_Top5_SalesPerson";
            this.btn_Top5_SalesPerson.Size = new System.Drawing.Size(658, 51);
            this.btn_Top5_SalesPerson.TabIndex = 125;
            this.btn_Top5_SalesPerson.Text = "銷售最好的top 5業務員";
            this.btn_Top5_SalesPerson.UseVisualStyleBackColor = false;
            this.btn_Top5_SalesPerson.Click += new System.EventHandler(this.btn_Top5_SalesPerson_Click);
            // 
            // btn_NwOders_GroupByYear
            // 
            this.btn_NwOders_GroupByYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_NwOders_GroupByYear.Location = new System.Drawing.Point(17, 415);
            this.btn_NwOders_GroupByYear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NwOders_GroupByYear.Name = "btn_NwOders_GroupByYear";
            this.btn_NwOders_GroupByYear.Size = new System.Drawing.Size(618, 51);
            this.btn_NwOders_GroupByYear.TabIndex = 121;
            this.btn_NwOders_GroupByYear.Text = " Orders -  Group by 年";
            this.btn_NwOders_GroupByYear.UseVisualStyleBackColor = false;
            this.btn_NwOders_GroupByYear.Click += new System.EventHandler(this.btn_NwOders_GroupByYear_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(5, 298);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(970, 283);
            this.treeView1.TabIndex = 130;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(5, 0);
            this.lblMaster.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(392, 49);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "Master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(390, 218);
            this.dataGridView1.TabIndex = 71;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 279);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(5, 5);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(970, 283);
            this.splitContainer2.SplitterDistance = 406;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 131;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 279);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("新細明體", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(5, 0);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(544, 49);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(542, 218);
            this.dataGridView2.TabIndex = 100;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(721, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(980, 880);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1706, 890);
            this.tableLayoutPanel3.TabIndex = 134;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.btn_IsOver300);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_NwOders_GroupByYearMonth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Classification_int);
            this.panel1.Controls.Add(this.btn_Top5_Sales_Price);
            this.panel1.Controls.Add(this.btn_SalesFigures);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Classification_FileYear);
            this.panel1.Controls.Add(this.btn_NW_Products);
            this.panel1.Controls.Add(this.btn_Classification_FileSize);
            this.panel1.Controls.Add(this.btn_Top5_SalesPerson);
            this.panel1.Controls.Add(this.btn_NwOders_GroupByYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 880);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(321, 813);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 40);
            this.button5.TabIndex = 139;
            this.button5.Text = "年 銷售成長率";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.ForeColor = System.Drawing.Color.Black;
            this.button34.Location = new System.Drawing.Point(18, 813);
            this.button34.Margin = new System.Windows.Forms.Padding(4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(267, 40);
            this.button34.TabIndex = 140;
            this.button34.Text = "每年 銷售分析 &&　plot";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // btn_IsOver300
            // 
            this.btn_IsOver300.BackColor = System.Drawing.Color.LightGreen;
            this.btn_IsOver300.Location = new System.Drawing.Point(18, 748);
            this.btn_IsOver300.Margin = new System.Windows.Forms.Padding(5);
            this.btn_IsOver300.Name = "btn_IsOver300";
            this.btn_IsOver300.Size = new System.Drawing.Size(657, 42);
            this.btn_IsOver300.TabIndex = 135;
            this.btn_IsOver300.Text = "     NW 產品有任何一筆單價大於300 ?";
            this.btn_IsOver300.UseVisualStyleBackColor = false;
            this.btn_IsOver300.Click += new System.EventHandler(this.btn_IsOver300_Click);
            // 
            // Frm作業_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 890);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm作業_4";
            this.Text = "Frm作業_4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NwOders_GroupByYearMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Classification_int;
        private System.Windows.Forms.Button btn_Top5_Sales_Price;
        private System.Windows.Forms.Button btn_SalesFigures;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Classification_FileYear;
        private System.Windows.Forms.Button btn_NW_Products;
        private System.Windows.Forms.Button btn_Classification_FileSize;
        private System.Windows.Forms.Button btn_Top5_SalesPerson;
        private System.Windows.Forms.Button btn_NwOders_GroupByYear;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_IsOver300;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button34;
    }
}