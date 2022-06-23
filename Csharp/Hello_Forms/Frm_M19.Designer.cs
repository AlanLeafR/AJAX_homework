
namespace Hello_Forms
{
    partial class Frm_M19
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
            this.lab_ProductName = new System.Windows.Forms.Label();
            this.lab_ProductPrice = new System.Windows.Forms.Label();
            this.lab_List = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.lab_ProductDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ProductName
            // 
            this.lab_ProductName.AutoSize = true;
            this.lab_ProductName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ProductName.Location = new System.Drawing.Point(35, 70);
            this.lab_ProductName.Name = "lab_ProductName";
            this.lab_ProductName.Size = new System.Drawing.Size(127, 35);
            this.lab_ProductName.TabIndex = 0;
            this.lab_ProductName.Text = "產品名稱";
            // 
            // lab_ProductPrice
            // 
            this.lab_ProductPrice.AutoSize = true;
            this.lab_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ProductPrice.Location = new System.Drawing.Point(35, 141);
            this.lab_ProductPrice.Name = "lab_ProductPrice";
            this.lab_ProductPrice.Size = new System.Drawing.Size(127, 35);
            this.lab_ProductPrice.TabIndex = 1;
            this.lab_ProductPrice.Text = "產品價格";
            // 
            // lab_List
            // 
            this.lab_List.AutoSize = true;
            this.lab_List.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_List.Location = new System.Drawing.Point(509, 28);
            this.lab_List.Name = "lab_List";
            this.lab_List.Size = new System.Drawing.Size(155, 35);
            this.lab_List.TabIndex = 2;
            this.lab_List.Text = "產品列表：";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductName.Location = new System.Drawing.Point(181, 67);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(223, 38);
            this.txt_ProductName.TabIndex = 3;
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductPrice.Location = new System.Drawing.Point(181, 141);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(223, 38);
            this.txt_ProductPrice.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.Location = new System.Drawing.Point(53, 279);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 67);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show.Location = new System.Drawing.Point(245, 279);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(159, 67);
            this.btn_show.TabIndex = 6;
            this.btn_show.Text = "顯示列表";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lab_ProductDetail
            // 
            this.lab_ProductDetail.AutoSize = true;
            this.lab_ProductDetail.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ProductDetail.Location = new System.Drawing.Point(509, 279);
            this.lab_ProductDetail.Name = "lab_ProductDetail";
            this.lab_ProductDetail.Size = new System.Drawing.Size(127, 35);
            this.lab_ProductDetail.TabIndex = 7;
            this.lab_ProductDetail.Text = "產品明細";
            // 
            // Frm_M19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1043, 519);
            this.Controls.Add(this.lab_ProductDetail);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lab_List);
            this.Controls.Add(this.lab_ProductPrice);
            this.Controls.Add(this.lab_ProductName);
            this.Name = "Frm_M19";
            this.Text = "Frm_M19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ProductName;
        private System.Windows.Forms.Label lab_ProductPrice;
        private System.Windows.Forms.Label lab_List;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label lab_ProductDetail;
    }
}