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
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.grpNhapTen = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpNhapTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chúc mừng người chơi đã dành được phần thưởng ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(276, 319);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(94, 42);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(126, 319);
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
            this.lblTienThuong.Location = new System.Drawing.Point(133, 124);
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
            this.lblThoiGian.Location = new System.Drawing.Point(216, 226);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(202, 23);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "label3";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Location = new System.Drawing.Point(427, 319);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(94, 42);
            this.btnLuuDiem.TabIndex = 6;
            this.btnLuuDiem.Text = "Save";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // grpNhapTen
            // 
            this.grpNhapTen.Controls.Add(this.btnXacNhan);
            this.grpNhapTen.Controls.Add(this.btnHuy);
            this.grpNhapTen.Controls.Add(this.txtTen);
            this.grpNhapTen.Location = new System.Drawing.Point(138, 97);
            this.grpNhapTen.Name = "grpNhapTen";
            this.grpNhapTen.Size = new System.Drawing.Size(371, 187);
            this.grpNhapTen.TabIndex = 7;
            this.grpNhapTen.TabStop = false;
            this.grpNhapTen.Text = "Nhập tên người chơi";
            this.grpNhapTen.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(94, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(180, 22);
            this.txtTen.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Location = new System.Drawing.Point(94, 114);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.Location = new System.Drawing.Point(199, 114);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 40);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AiLaTrieuPhu.Properties.Resources.hq720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 395);
            this.Controls.Add(this.grpNhapTen);
            this.Controls.Add(this.btnLuuDiem);
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
            this.grpNhapTen.ResumeLayout(false);
            this.grpNhapTen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Label lblTienThuong;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.GroupBox grpNhapTen;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTen;
    }
}