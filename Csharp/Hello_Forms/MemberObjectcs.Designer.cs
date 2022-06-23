
namespace Hello_Forms
{
    partial class MemberObjectcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterClick = new System.Windows.Forms.Button();
            this.MemberRegister = new System.Windows.Forms.Button();
            this.MemberRegister02 = new System.Windows.Forms.Button();
            this.UnRegisterClick = new System.Windows.Forms.Button();
            this.SetProperty = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WhatDays = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(491, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "會員資料\r\n物件實體化";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterClick
            // 
            this.RegisterClick.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RegisterClick.Location = new System.Drawing.Point(102, 60);
            this.RegisterClick.Name = "RegisterClick";
            this.RegisterClick.Size = new System.Drawing.Size(167, 77);
            this.RegisterClick.TabIndex = 1;
            this.RegisterClick.Text = "註冊事件";
            this.RegisterClick.UseVisualStyleBackColor = true;
            this.RegisterClick.Click += new System.EventHandler(this.RegisterClick_Click);
            // 
            // MemberRegister
            // 
            this.MemberRegister.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberRegister.Location = new System.Drawing.Point(102, 180);
            this.MemberRegister.Name = "MemberRegister";
            this.MemberRegister.Size = new System.Drawing.Size(209, 51);
            this.MemberRegister.TabIndex = 2;
            this.MemberRegister.Text = "Register 01";
            this.MemberRegister.UseVisualStyleBackColor = true;
            // 
            // MemberRegister02
            // 
            this.MemberRegister02.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberRegister02.Location = new System.Drawing.Point(102, 271);
            this.MemberRegister02.Name = "MemberRegister02";
            this.MemberRegister02.Size = new System.Drawing.Size(209, 51);
            this.MemberRegister02.TabIndex = 3;
            this.MemberRegister02.Text = "Register 02";
            this.MemberRegister02.UseVisualStyleBackColor = true;
            // 
            // UnRegisterClick
            // 
            this.UnRegisterClick.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UnRegisterClick.Location = new System.Drawing.Point(102, 361);
            this.UnRegisterClick.Name = "UnRegisterClick";
            this.UnRegisterClick.Size = new System.Drawing.Size(167, 77);
            this.UnRegisterClick.TabIndex = 4;
            this.UnRegisterClick.Text = "解除註冊";
            this.UnRegisterClick.UseVisualStyleBackColor = true;
            this.UnRegisterClick.Click += new System.EventHandler(this.UnRegisterClick_Click);
            // 
            // SetProperty
            // 
            this.SetProperty.BackColor = System.Drawing.Color.RosyBrown;
            this.SetProperty.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetProperty.Location = new System.Drawing.Point(482, 170);
            this.SetProperty.Name = "SetProperty";
            this.SetProperty.Size = new System.Drawing.Size(198, 70);
            this.SetProperty.TabIndex = 5;
            this.SetProperty.Text = "SetProperty";
            this.SetProperty.UseVisualStyleBackColor = false;
            this.SetProperty.Click += new System.EventHandler(this.SetProperty_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "SetBunds";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WhatDays
            // 
            this.WhatDays.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WhatDays.Location = new System.Drawing.Point(484, 347);
            this.WhatDays.Name = "WhatDays";
            this.WhatDays.Size = new System.Drawing.Size(220, 78);
            this.WhatDays.TabIndex = 7;
            this.WhatDays.Text = "今天星期幾?";
            this.WhatDays.UseVisualStyleBackColor = true;
            this.WhatDays.Click += new System.EventHandler(this.WhatDays_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 73);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MemberObjectcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1001, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.WhatDays);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SetProperty);
            this.Controls.Add(this.UnRegisterClick);
            this.Controls.Add(this.MemberRegister02);
            this.Controls.Add(this.MemberRegister);
            this.Controls.Add(this.RegisterClick);
            this.Controls.Add(this.button1);
            this.Name = "MemberObjectcs";
            this.Text = "MemberObjectcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegisterClick;
        private System.Windows.Forms.Button MemberRegister;
        private System.Windows.Forms.Button MemberRegister02;
        private System.Windows.Forms.Button UnRegisterClick;
        private System.Windows.Forms.Button SetProperty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button WhatDays;
        private System.Windows.Forms.Button button3;
    }
}