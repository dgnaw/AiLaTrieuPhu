using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class FormResult : Form
    {

        public enum LuaChon { ChoiLai, TrangChu, Thoat }
        public LuaChon UserAction { get; private set; } = LuaChon.Thoat;
        public FormResult(string soTien, string thoiGian)
        {
            InitializeComponent();

            // 1. Hiển thị dữ liệu lên Label
            // Format tiền cho đẹp (nếu chưa format) hoặc gán thẳng
            lblTienThuong.Text = "Tiền thưởng: " + soTien;
            lblThoiGian.Text = "Tổng thời gian: " + thoiGian + " giây";

        }

        private void FormResult_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            // Đánh dấu là muốn về trang chủ
            UserAction = LuaChon.TrangChu;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            // Đánh dấu là muốn chơi lại
            UserAction = LuaChon.ChoiLai;
            this.Close(); // Đóng form kết quả đi
        }

        private void lblThanhTich_Click(object sender, EventArgs e)
        {

        }
    }
}
