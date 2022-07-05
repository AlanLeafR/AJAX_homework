
namespace 作業0705
{
    partial class FormHello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHello));
            this.label_Name1 = new System.Windows.Forms.Label();
            this.button_Name1 = new System.Windows.Forms.Button();
            this.label_Name2 = new System.Windows.Forms.Label();
            this.Sex_Box = new System.Windows.Forms.Label();
            this.Star_Sign = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.Sex_txt = new System.Windows.Forms.TextBox();
            this.Star_txt = new System.Windows.Forms.TextBox();
            this.button_Name2 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name1
            // 
            this.label_Name1.AutoSize = true;
            this.label_Name1.BackColor = System.Drawing.Color.PeachPuff;
            this.label_Name1.Font = new System.Drawing.Font("微軟正黑體 Light", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name1.Location = new System.Drawing.Point(76, 59);
            this.label_Name1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label_Name1.Name = "label_Name1";
            this.label_Name1.Size = new System.Drawing.Size(152, 54);
            this.label_Name1.TabIndex = 0;
            this.label_Name1.Text = "姓名：";
            this.label_Name1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Name1
            // 
            this.button_Name1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Name1.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Name1.Location = new System.Drawing.Point(75, 509);
            this.button_Name1.Margin = new System.Windows.Forms.Padding(4);
            this.button_Name1.Name = "button_Name1";
            this.button_Name1.Size = new System.Drawing.Size(279, 91);
            this.button_Name1.TabIndex = 2;
            this.button_Name1.Text = "Hello !";
            this.button_Name1.UseVisualStyleBackColor = false;
            this.button_Name1.Click += new System.EventHandler(this.button_Name1_Click);
            // 
            // label_Name2
            // 
            this.label_Name2.AutoSize = true;
            this.label_Name2.BackColor = System.Drawing.Color.PeachPuff;
            this.label_Name2.Font = new System.Drawing.Font("微軟正黑體 Light", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name2.Location = new System.Drawing.Point(76, 163);
            this.label_Name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name2.Name = "label_Name2";
            this.label_Name2.Size = new System.Drawing.Size(291, 54);
            this.label_Name2.TabIndex = 3;
            this.label_Name2.Text = "English Name";
            // 
            // Sex_Box
            // 
            this.Sex_Box.AutoSize = true;
            this.Sex_Box.BackColor = System.Drawing.Color.PeachPuff;
            this.Sex_Box.Font = new System.Drawing.Font("微軟正黑體 Light", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sex_Box.Location = new System.Drawing.Point(96, 273);
            this.Sex_Box.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sex_Box.Name = "Sex_Box";
            this.Sex_Box.Size = new System.Drawing.Size(109, 54);
            this.Sex_Box.TabIndex = 4;
            this.Sex_Box.Text = "性別";
            // 
            // Star_Sign
            // 
            this.Star_Sign.AutoSize = true;
            this.Star_Sign.BackColor = System.Drawing.Color.PeachPuff;
            this.Star_Sign.Font = new System.Drawing.Font("微軟正黑體 Light", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Star_Sign.Location = new System.Drawing.Point(96, 365);
            this.Star_Sign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Star_Sign.Name = "Star_Sign";
            this.Star_Sign.Size = new System.Drawing.Size(109, 54);
            this.Star_Sign.TabIndex = 5;
            this.Star_Sign.Text = "星座";
            // 
            // txtBox2
            // 
            this.txtBox2.BackColor = System.Drawing.Color.LightGray;
            this.txtBox2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox2.Location = new System.Drawing.Point(509, 163);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(242, 43);
            this.txtBox2.TabIndex = 6;
            this.txtBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Sex_txt
            // 
            this.Sex_txt.BackColor = System.Drawing.Color.LightGray;
            this.Sex_txt.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sex_txt.Location = new System.Drawing.Point(504, 273);
            this.Sex_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Sex_txt.Name = "Sex_txt";
            this.Sex_txt.Size = new System.Drawing.Size(247, 43);
            this.Sex_txt.TabIndex = 7;
            // 
            // Star_txt
            // 
            this.Star_txt.BackColor = System.Drawing.Color.LightGray;
            this.Star_txt.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Star_txt.Location = new System.Drawing.Point(504, 376);
            this.Star_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Star_txt.Name = "Star_txt";
            this.Star_txt.Size = new System.Drawing.Size(247, 43);
            this.Star_txt.TabIndex = 8;
            // 
            // button_Name2
            // 
            this.button_Name2.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Name2.Location = new System.Drawing.Point(487, 504);
            this.button_Name2.Margin = new System.Windows.Forms.Padding(4);
            this.button_Name2.Name = "button_Name2";
            this.button_Name2.Size = new System.Drawing.Size(279, 96);
            this.button_Name2.TabIndex = 9;
            this.button_Name2.Text = "你好嗎？";
            this.button_Name2.UseVisualStyleBackColor = true;
            this.button_Name2.Click += new System.EventHandler(this.button_Name2_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.LightGray;
            this.txtBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox1.Location = new System.Drawing.Point(509, 59);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(242, 43);
            this.txtBox1.TabIndex = 6;
            // 
            // FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 643);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.button_Name2);
            this.Controls.Add(this.Star_txt);
            this.Controls.Add(this.Sex_txt);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.Star_Sign);
            this.Controls.Add(this.Sex_Box);
            this.Controls.Add(this.label_Name2);
            this.Controls.Add(this.button_Name1);
            this.Controls.Add(this.label_Name1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHello";
            this.Text = "HelloForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name1;
        private System.Windows.Forms.Button button_Name1;
        private System.Windows.Forms.Label label_Name2;
        private System.Windows.Forms.Label Sex_Box;
        private System.Windows.Forms.Label Star_Sign;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox Sex_txt;
        private System.Windows.Forms.TextBox Star_txt;
        private System.Windows.Forms.Button button_Name2;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

