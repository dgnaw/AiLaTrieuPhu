namespace AiLaTrieuPhu
{
    partial class FmKhoiDong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmKhoiDong));
            this.tmBatDauChoi = new System.Windows.Forms.Timer(this.components);
            this.btBatDau = new System.Windows.Forms.Button();
            this.btSanSang = new System.Windows.Forms.Button();
            this.ptbKhoiDong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhoiDong)).BeginInit();
            this.SuspendLayout();
            // 
            // tmBatDauChoi
            // 
            this.tmBatDauChoi.Interval = 5000;
            this.tmBatDauChoi.Tick += new System.EventHandler(this.tmBatDauChoi_Tick);
            // 
            // btBatDau
            // 
            this.btBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btBatDau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBatDau.BackgroundImage")));
            this.btBatDau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBatDau.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBatDau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btBatDau.Location = new System.Drawing.Point(247, 310);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(200, 60);
            this.btBatDau.TabIndex = 25;
            this.btBatDau.Text = "CHƠI NGAY";
            this.btBatDau.UseVisualStyleBackColor = false;
            this.btBatDau.Click += new System.EventHandler(this.btBatDau_Click);
            // 
            // btSanSang
            // 
            this.btSanSang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSanSang.BackColor = System.Drawing.Color.Lime;
            this.btSanSang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSanSang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSanSang.ForeColor = System.Drawing.Color.Lime;
            this.btSanSang.Image = ((System.Drawing.Image)(resources.GetObject("btSanSang.Image")));
            this.btSanSang.Location = new System.Drawing.Point(247, 310);
            this.btSanSang.Name = "btSanSang";
            this.btSanSang.Size = new System.Drawing.Size(200, 60);
            this.btSanSang.TabIndex = 24;
            this.btSanSang.Text = "TÔI SẴNG SÀNG";
            this.btSanSang.UseVisualStyleBackColor = false;
            this.btSanSang.Click += new System.EventHandler(this.btSanSang_Click);
            // 
            // ptbKhoiDong
            // 
            this.ptbKhoiDong.Image = global::AiLaTrieuPhu.Properties.Resources.nenPlay;
            this.ptbKhoiDong.Location = new System.Drawing.Point(-1, -18);
            this.ptbKhoiDong.Name = "ptbKhoiDong";
            this.ptbKhoiDong.Size = new System.Drawing.Size(685, 431);
            this.ptbKhoiDong.TabIndex = 23;
            this.ptbKhoiDong.TabStop = false;
            this.ptbKhoiDong.Click += new System.EventHandler(this.ptbKhoiDong_Click);
            // 
            // FmKhoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.btBatDau);
            this.Controls.Add(this.btSanSang);
            this.Controls.Add(this.ptbKhoiDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmKhoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ai là triệu phú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmKhoiDong_FormClosed);
            this.Load += new System.EventHandler(this.FmKhoiDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhoiDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer tmBatDauChoi;
        private System.Windows.Forms.PictureBox ptbKhoiDong;
        private System.Windows.Forms.Button btSanSang;
        public System.Windows.Forms.Button btBatDau;
    }
}