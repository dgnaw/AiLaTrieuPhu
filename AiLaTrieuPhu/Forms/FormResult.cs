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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            grpNhapTen.Visible = true; // Hiện khung nhập lên
            txtTen.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //if (txtTen.Text == "") return;

            //string ten = txtTen.Text;

            //// Lấy tiền (Xử lý chuỗi để bỏ chữ "Tiền thưởng: " đi cho gọn)
            //string tien = lblTienThuong.Text.Replace("Tiền thưởng: ", "");

            //// Lấy thời gian (Bỏ chữ "Tổng thời gian: " và " giây")
            //// Lưu ý: Đoạn này phải khớp với cách bạn viết ở FormResult
            //// Ví dụ text là: "Tổng thời gian: 20 giây"
            //string tgStr = lblThoiGian.Text;
            //tgStr = tgStr.Replace("Tổng thời gian: ", "").Replace(" giây", "").Trim();

            //// Viết câu lệnh SQL Insert
            //string sql = "INSERT INTO tblLichSu (HoTen, TienThuong, ThoiGian, NgayChoi) " +
            //             "VALUES (N'" + ten + "', N'" + tien + "', " + tgStr + ", GETDATE())";

            //// Gọi hàm thực thi
            //C_KetNoi.thucHienLenh(sql);

            //MessageBox.Show("Đã lưu thành tích!");

            //// Ẩn đi để không lưu nhiều lần
            //grpNhapTen.Visible = false;
            //btnLuuDiem.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";

            // 2. Ẩn khung nhập tên đi
            grpNhapTen.Visible = false;
        }
    }
}
