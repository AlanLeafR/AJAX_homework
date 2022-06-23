
namespace Hello_Forms
{
    partial class hw4_student_structform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_Stu_name = new System.Windows.Forms.TextBox();
            this.txt_Chi_score = new System.Windows.Forms.TextBox();
            this.txt_Eng_score = new System.Windows.Forms.TextBox();
            this.txt_Math_score = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(98, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(98, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(98, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 76);
            this.button3.TabIndex = 6;
            this.button3.Text = "最高分/最低分科目";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_Stu_name
            // 
            this.txt_Stu_name.Location = new System.Drawing.Point(203, 73);
            this.txt_Stu_name.Name = "txt_Stu_name";
            this.txt_Stu_name.Size = new System.Drawing.Size(182, 25);
            this.txt_Stu_name.TabIndex = 7;
            // 
            // txt_Chi_score
            // 
            this.txt_Chi_score.Location = new System.Drawing.Point(203, 118);
            this.txt_Chi_score.Name = "txt_Chi_score";
            this.txt_Chi_score.Size = new System.Drawing.Size(182, 25);
            this.txt_Chi_score.TabIndex = 8;
            this.txt_Chi_score.Text = "0";
            // 
            // txt_Eng_score
            // 
            this.txt_Eng_score.Location = new System.Drawing.Point(203, 172);
            this.txt_Eng_score.Name = "txt_Eng_score";
            this.txt_Eng_score.Size = new System.Drawing.Size(182, 25);
            this.txt_Eng_score.TabIndex = 9;
            this.txt_Eng_score.Text = "0";
            // 
            // txt_Math_score
            // 
            this.txt_Math_score.Location = new System.Drawing.Point(203, 231);
            this.txt_Math_score.Name = "txt_Math_score";
            this.txt_Math_score.Size = new System.Drawing.Size(182, 25);
            this.txt_Math_score.TabIndex = 10;
            this.txt_Math_score.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(506, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 201);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(16, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 110);
            this.label6.TabIndex = 1;
            // 
            // hw4_student_structform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1012, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Math_score);
            this.Controls.Add(this.txt_Eng_score);
            this.Controls.Add(this.txt_Chi_score);
            this.Controls.Add(this.txt_Stu_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hw4_student_structform";
            this.Text = "hw4_student_structform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_Stu_name;
        private System.Windows.Forms.TextBox txt_Chi_score;
        private System.Windows.Forms.TextBox txt_Eng_score;
        private System.Windows.Forms.TextBox txt_Math_score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}