
namespace 作業0705
{
    partial class hw2_Loan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loan_txt = new System.Windows.Forms.TextBox();
            this.PayMonth_btn = new System.Windows.Forms.Button();
            this.Report_btn = new System.Windows.Forms.Button();
            this.total_btn = new System.Windows.Forms.Button();
            this.deadline_year_txt = new System.Windows.Forms.TextBox();
            this.AnnualRate_txt = new System.Windows.Forms.TextBox();
            this.down_payment_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(104, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(104, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(104, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "年利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(104, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // loan_txt
            // 
            this.loan_txt.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loan_txt.Location = new System.Drawing.Point(328, 55);
            this.loan_txt.Name = "loan_txt";
            this.loan_txt.Size = new System.Drawing.Size(181, 38);
            this.loan_txt.TabIndex = 4;
            this.loan_txt.Text = "100000";
            // 
            // PayMonth_btn
            // 
            this.PayMonth_btn.Location = new System.Drawing.Point(126, 313);
            this.PayMonth_btn.Name = "PayMonth_btn";
            this.PayMonth_btn.Size = new System.Drawing.Size(140, 74);
            this.PayMonth_btn.TabIndex = 8;
            this.PayMonth_btn.Text = "PMT(月付)";
            this.PayMonth_btn.UseVisualStyleBackColor = true;
            this.PayMonth_btn.Click += new System.EventHandler(this.PayMonth_Click);
            // 
            // Report_btn
            // 
            this.Report_btn.Location = new System.Drawing.Point(520, 313);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(140, 74);
            this.Report_btn.TabIndex = 9;
            this.Report_btn.Text = "Report";
            this.Report_btn.UseVisualStyleBackColor = true;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // total_btn
            // 
            this.total_btn.Location = new System.Drawing.Point(330, 313);
            this.total_btn.Name = "total_btn";
            this.total_btn.Size = new System.Drawing.Size(140, 74);
            this.total_btn.TabIndex = 10;
            this.total_btn.Text = "總付款";
            this.total_btn.UseVisualStyleBackColor = true;
            this.total_btn.Click += new System.EventHandler(this.total_Click);
            // 
            // deadline_year_txt
            // 
            this.deadline_year_txt.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deadline_year_txt.Location = new System.Drawing.Point(328, 127);
            this.deadline_year_txt.Name = "deadline_year_txt";
            this.deadline_year_txt.Size = new System.Drawing.Size(181, 38);
            this.deadline_year_txt.TabIndex = 11;
            this.deadline_year_txt.Text = "2";
            // 
            // AnnualRate_txt
            // 
            this.AnnualRate_txt.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AnnualRate_txt.Location = new System.Drawing.Point(328, 192);
            this.AnnualRate_txt.Name = "AnnualRate_txt";
            this.AnnualRate_txt.Size = new System.Drawing.Size(181, 38);
            this.AnnualRate_txt.TabIndex = 12;
            this.AnnualRate_txt.Text = "10";
            // 
            // down_payment_txt
            // 
            this.down_payment_txt.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down_payment_txt.Location = new System.Drawing.Point(328, 253);
            this.down_payment_txt.Name = "down_payment_txt";
            this.down_payment_txt.Size = new System.Drawing.Size(181, 38);
            this.down_payment_txt.TabIndex = 13;
            this.down_payment_txt.Text = "0";
            // 
            // hw2_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.down_payment_txt);
            this.Controls.Add(this.AnnualRate_txt);
            this.Controls.Add(this.deadline_year_txt);
            this.Controls.Add(this.total_btn);
            this.Controls.Add(this.Report_btn);
            this.Controls.Add(this.PayMonth_btn);
            this.Controls.Add(this.loan_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "hw2_Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PayMonth_btn;
        private System.Windows.Forms.Button Report_btn;
        private System.Windows.Forms.Button total_btn;
        private System.Windows.Forms.TextBox deadline_year_txt;
        private System.Windows.Forms.TextBox AnnualRate_txt;
        private System.Windows.Forms.TextBox down_payment_txt;
        private System.Windows.Forms.TextBox loan_txt;
    }
}