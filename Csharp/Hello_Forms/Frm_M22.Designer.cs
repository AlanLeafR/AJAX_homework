
namespace Hello_Forms
{
    partial class Frm_M22
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
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_grade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(542, 77);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(183, 25);
            this.txt_grade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "分級";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_grade
            // 
            this.lab_grade.AutoSize = true;
            this.lab_grade.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_grade.Location = new System.Drawing.Point(468, 74);
            this.lab_grade.Name = "lab_grade";
            this.lab_grade.Size = new System.Drawing.Size(68, 28);
            this.lab_grade.TabIndex = 2;
            this.lab_grade.Text = "級分";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "switch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "while";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "do_while1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(258, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 78);
            this.button5.TabIndex = 6;
            this.button5.Text = "do_while2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(258, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 78);
            this.button6.TabIndex = 7;
            this.button6.Text = "for";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(460, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 78);
            this.button7.TabIndex = 8;
            this.button7.Text = "foreach";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Frm_M22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lab_grade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_grade);
            this.Name = "Frm_M22";
            this.Text = "Frm_M22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_grade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}