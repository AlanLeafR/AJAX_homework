
namespace Hello_Forms
{
    partial class Frm_M15_CTS
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
            this.CTS_Value = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Reference = new System.Windows.Forms.TextBox();
            this.btn_Stu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CTS_Value
            // 
            this.CTS_Value.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CTS_Value.Location = new System.Drawing.Point(87, 89);
            this.CTS_Value.Name = "CTS_Value";
            this.CTS_Value.Size = new System.Drawing.Size(230, 95);
            this.CTS_Value.TabIndex = 0;
            this.CTS_Value.Text = "CTS_Value";
            this.CTS_Value.UseVisualStyleBackColor = true;
            this.CTS_Value.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(421, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "CTS_Reference";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_Reference
            // 
            this.txt_Reference.Location = new System.Drawing.Point(421, 255);
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(229, 25);
            this.txt_Reference.TabIndex = 2;
            // 
            // btn_Stu
            // 
            this.btn_Stu.Location = new System.Drawing.Point(39, 312);
            this.btn_Stu.Name = "btn_Stu";
            this.btn_Stu.Size = new System.Drawing.Size(169, 61);
            this.btn_Stu.TabIndex = 3;
            this.btn_Stu.Text = "stu test";
            this.btn_Stu.UseVisualStyleBackColor = true;
            this.btn_Stu.Click += new System.EventHandler(this.btn_Stu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "名稱";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 25);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "價格";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "clear test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_M15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Stu);
            this.Controls.Add(this.txt_Reference);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CTS_Value);
            this.Name = "Frm_M15_CTS";
            this.Text = "Fom15_CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CTS_Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Reference;
        private System.Windows.Forms.Button btn_Stu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}