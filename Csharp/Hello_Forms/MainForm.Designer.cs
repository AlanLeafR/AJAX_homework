
namespace Hello_Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.opnHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpnMethod2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AgeCalculator = new System.Windows.Forms.Button();
            this.EncapTest = new System.Windows.Forms.Button();
            this.PartcailClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opnHello
            // 
            this.opnHello.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.opnHello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.opnHello.Location = new System.Drawing.Point(62, 155);
            this.opnHello.Name = "opnHello";
            this.opnHello.Size = new System.Drawing.Size(233, 63);
            this.opnHello.TabIndex = 0;
            this.opnHello.Text = "1. Open Hello";
            this.opnHello.UseVisualStyleBackColor = true;
            this.opnHello.Click += new System.EventHandler(this.OpnHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function List";
            // 
            // OpnMethod2
            // 
            this.OpnMethod2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OpnMethod2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpnMethod2.Location = new System.Drawing.Point(62, 345);
            this.OpnMethod2.Name = "OpnMethod2";
            this.OpnMethod2.Size = new System.Drawing.Size(280, 63);
            this.OpnMethod2.TabIndex = 3;
            this.OpnMethod2.Text = "3. Method Test";
            this.OpnMethod2.UseVisualStyleBackColor = true;
            this.OpnMethod2.Click += new System.EventHandler(this.OpnMethod2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(62, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "2. First Method ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgeCalculator
            // 
            this.AgeCalculator.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeCalculator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgeCalculator.Location = new System.Drawing.Point(62, 444);
            this.AgeCalculator.Name = "AgeCalculator";
            this.AgeCalculator.Size = new System.Drawing.Size(280, 63);
            this.AgeCalculator.TabIndex = 5;
            this.AgeCalculator.Text = "4. Age Calculator";
            this.AgeCalculator.UseVisualStyleBackColor = true;
            this.AgeCalculator.Click += new System.EventHandler(this.AgeCalculator_Click);
            // 
            // EncapTest
            // 
            this.EncapTest.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EncapTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncapTest.Location = new System.Drawing.Point(445, 155);
            this.EncapTest.Name = "EncapTest";
            this.EncapTest.Size = new System.Drawing.Size(280, 63);
            this.EncapTest.TabIndex = 6;
            this.EncapTest.Text = "5. Encap Test";
            this.EncapTest.UseVisualStyleBackColor = true;
            this.EncapTest.Click += new System.EventHandler(this.EncapTest_Click);
            // 
            // PartcailClass
            // 
            this.PartcailClass.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PartcailClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PartcailClass.Location = new System.Drawing.Point(445, 256);
            this.PartcailClass.Name = "PartcailClass";
            this.PartcailClass.Size = new System.Drawing.Size(280, 63);
            this.PartcailClass.TabIndex = 7;
            this.PartcailClass.Text = "6. Partcail Class";
            this.PartcailClass.UseVisualStyleBackColor = true;
            this.PartcailClass.Click += new System.EventHandler(this.PartcailClass_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 581);
            this.Controls.Add(this.PartcailClass);
            this.Controls.Add(this.EncapTest);
            this.Controls.Add(this.AgeCalculator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OpnMethod2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opnHello);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opnHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpnMethod2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AgeCalculator;
        private System.Windows.Forms.Button EncapTest;
        private System.Windows.Forms.Button PartcailClass;
    }
}