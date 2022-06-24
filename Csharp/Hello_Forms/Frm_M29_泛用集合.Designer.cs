
namespace Hello_Forms
{
    partial class Frm_M29_泛用集合
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_EmployeeList = new System.Windows.Forms.Label();
            this.txtEMP_Age = new System.Windows.Forms.TextBox();
            this.txtEMP_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 55);
            this.button4.TabIndex = 17;
            this.button4.Text = "RemoveAt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "Insert員工";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "添加員工";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_EmployeeList
            // 
            this.lab_EmployeeList.AutoSize = true;
            this.lab_EmployeeList.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lab_EmployeeList.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_EmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_EmployeeList.Location = new System.Drawing.Point(451, 50);
            this.lab_EmployeeList.Name = "lab_EmployeeList";
            this.lab_EmployeeList.Size = new System.Drawing.Size(109, 30);
            this.lab_EmployeeList.TabIndex = 13;
            this.lab_EmployeeList.Text = "員工清單";
            // 
            // txtEMP_Age
            // 
            this.txtEMP_Age.Location = new System.Drawing.Point(167, 113);
            this.txtEMP_Age.Name = "txtEMP_Age";
            this.txtEMP_Age.Size = new System.Drawing.Size(132, 25);
            this.txtEMP_Age.TabIndex = 12;
            // 
            // txtEMP_Name
            // 
            this.txtEMP_Name.Location = new System.Drawing.Point(167, 58);
            this.txtEMP_Name.Name = "txtEMP_Name";
            this.txtEMP_Name.Size = new System.Drawing.Size(132, 25);
            this.txtEMP_Name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "員工年齡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "員工姓名";
            // 
            // Frm_M29_泛用集合
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_EmployeeList);
            this.Controls.Add(this.txtEMP_Age);
            this.Controls.Add(this.txtEMP_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_M29_泛用集合";
            this.Text = "Frm_M29_泛用集合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_EmployeeList;
        private System.Windows.Forms.TextBox txtEMP_Age;
        private System.Windows.Forms.TextBox txtEMP_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}