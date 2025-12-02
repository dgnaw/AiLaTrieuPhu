namespace AiLaTrieuPhu
{
    partial class FormResult
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
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.lblTienThuong = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblThanhTich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chúc mừng người chơi đã dành được phần thưởng ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(173, 311);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(94, 42);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(350, 311);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(105, 42);
            this.btnChoiLai.TabIndex = 3;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // lblTienThuong
            // 
            this.lblTienThuong.BackColor = System.Drawing.Color.Gold;
            this.lblTienThuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThuong.Location = new System.Drawing.Point(124, 139);
            this.lblTienThuong.Name = "lblTienThuong";
            this.lblTienThuong.Size = new System.Drawing.Size(388, 40);
            this.lblTienThuong.TabIndex = 4;
            this.lblTienThuong.Text = "label2";
            this.lblTienThuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.BackColor = System.Drawing.Color.Gold;
            this.lblThoiGian.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(216, 237);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(202, 23);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "label3";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThanhTich
            // 
            this.lblThanhTich.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTich.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblThanhTich.Location = new System.Drawing.Point(183, 9);
            this.lblThanhTich.Name = "lblThanhTich";
            this.lblThanhTich.Size = new System.Drawing.Size(256, 50);
            this.lblThanhTich.TabIndex = 6;
            this.lblThanhTich.Text = "THÀNH TÍCH";
            this.lblThanhTich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThanhTich.Click += new System.EventHandler(this.lblThanhTich_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.hq720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 383);
            this.Controls.Add(this.lblThanhTich);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTienThuong);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResult";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label lblTienThuong;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblThanhTich;
    }
}