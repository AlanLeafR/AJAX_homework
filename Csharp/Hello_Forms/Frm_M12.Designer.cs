
namespace Hello_Forms
{
    partial class Frm_M12
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
            this.CountPlus = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.CountMinus = new System.Windows.Forms.Button();
            this.CountZero = new System.Windows.Forms.Button();
            this.CountMulti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.LabInstant = new System.Windows.Forms.Label();
            this.LabStatic = new System.Windows.Forms.Label();
            this.CallMainFrm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountPlus
            // 
            this.CountPlus.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountPlus.Location = new System.Drawing.Point(394, 60);
            this.CountPlus.Name = "CountPlus";
            this.CountPlus.Size = new System.Drawing.Size(237, 88);
            this.CountPlus.TabIndex = 0;
            this.CountPlus.Text = "計數器+=";
            this.CountPlus.UseVisualStyleBackColor = true;
            this.CountPlus.Click += new System.EventHandler(this.CountPlus_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCount.Location = new System.Drawing.Point(134, 81);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(189, 48);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Count：0";
            // 
            // CountMinus
            // 
            this.CountMinus.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountMinus.Location = new System.Drawing.Point(394, 174);
            this.CountMinus.Name = "CountMinus";
            this.CountMinus.Size = new System.Drawing.Size(237, 88);
            this.CountMinus.TabIndex = 2;
            this.CountMinus.Text = "計數器-=";
            this.CountMinus.UseVisualStyleBackColor = true;
            this.CountMinus.Click += new System.EventHandler(this.CountMinus_Click);
            // 
            // CountZero
            // 
            this.CountZero.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountZero.Location = new System.Drawing.Point(86, 174);
            this.CountZero.Name = "CountZero";
            this.CountZero.Size = new System.Drawing.Size(237, 88);
            this.CountZero.TabIndex = 3;
            this.CountZero.Text = "歸零";
            this.CountZero.UseVisualStyleBackColor = true;
            this.CountZero.Click += new System.EventHandler(this.CountZero_Click);
            // 
            // CountMulti
            // 
            this.CountMulti.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CountMulti.Location = new System.Drawing.Point(687, 60);
            this.CountMulti.Name = "CountMulti";
            this.CountMulti.Size = new System.Drawing.Size(237, 88);
            this.CountMulti.TabIndex = 4;
            this.CountMulti.Text = "計數器*=";
            this.CountMulti.UseVisualStyleBackColor = true;
            this.CountMulti.Click += new System.EventHandler(this.CountMulti_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(687, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 88);
            this.button1.TabIndex = 5;
            this.button1.Text = "計數器/=";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(982, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 88);
            this.button2.TabIndex = 6;
            this.button2.Text = "++count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(982, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 88);
            this.button3.TabIndex = 7;
            this.button3.Text = "count++";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(86, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(99, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 48);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 48);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.CallMainFrm);
            this.groupBox2.Controls.Add(this.LabStatic);
            this.groupBox2.Controls.Add(this.LabInstant);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(621, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 211);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(94, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 48);
            this.button6.TabIndex = 1;
            this.button6.Text = "動態變數計算";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(94, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 48);
            this.button7.TabIndex = 0;
            this.button7.Text = "靜態變數計算";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // LabInstant
            // 
            this.LabInstant.AutoSize = true;
            this.LabInstant.BackColor = System.Drawing.Color.Snow;
            this.LabInstant.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabInstant.Location = new System.Drawing.Point(267, 30);
            this.LabInstant.Name = "LabInstant";
            this.LabInstant.Size = new System.Drawing.Size(200, 30);
            this.LabInstant.TabIndex = 2;
            this.LabInstant.Text = "InstantCount：0";
            // 
            // LabStatic
            // 
            this.LabStatic.AutoSize = true;
            this.LabStatic.BackColor = System.Drawing.Color.Snow;
            this.LabStatic.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabStatic.Location = new System.Drawing.Point(267, 96);
            this.LabStatic.Name = "LabStatic";
            this.LabStatic.Size = new System.Drawing.Size(190, 30);
            this.LabStatic.TabIndex = 3;
            this.LabStatic.Text = "StaiticCount：0";
            // 
            // CallMainFrm
            // 
            this.CallMainFrm.Location = new System.Drawing.Point(192, 156);
            this.CallMainFrm.Name = "CallMainFrm";
            this.CallMainFrm.Size = new System.Drawing.Size(152, 35);
            this.CallMainFrm.TabIndex = 4;
            this.CallMainFrm.Text = "Call Main Frm";
            this.CallMainFrm.UseVisualStyleBackColor = true;
            this.CallMainFrm.Click += new System.EventHandler(this.CallHello_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountMulti);
            this.Controls.Add(this.CountZero);
            this.Controls.Add(this.CountMinus);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.CountPlus);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CountPlus;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button CountMinus;
        private System.Windows.Forms.Button CountZero;
        private System.Windows.Forms.Button CountMulti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabStatic;
        private System.Windows.Forms.Label LabInstant;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button CallMainFrm;
    }
}