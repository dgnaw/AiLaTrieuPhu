using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AiLaTrieuPhu
{
    public partial class FmChinh : Form
    {
        public FmChinh()
        {
            InitializeComponent();
        }

        private int bang = 1, c = 0;
        private int tongThoiGian = 0;
        int cs = 0;
        int[] MangRandom = new int[5];
        bool ok = true;

        private static Random r = new Random();

        private int i;

        private void FmChinh_Load(object sender, EventArgs e)
        {
            tongThoiGian = 0;

            // 2. Bật đồng hồ đếm giờ ngay khi Form hiện lên
            tmDemGio.Enabled = true;

            // 3. Nếu lần đầu vào game mà câu hỏi chưa hiện, bạn có thể kích hoạt nó luôn ở đây
            // (Nếu game của bạn đã tự hiện câu hỏi rồi thì bỏ qua dòng dưới này)
            tmChuyenCau.Enabled = true;

            ptbKinhLup.Visible = true;
            ptbKinhLup.Enabled = true;
        }

        private void btA_Click_1(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm A và label
                btA.BackColor = Color.Orange;
                lbA.BackColor = Color.Orange;

                btB.Enabled = false;
                btC.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "A"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }//ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btB_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm B và label
                btB.BackColor = Color.Orange;
                lbB.BackColor = Color.Orange;

                btA.Enabled = false;
                btC.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "B"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm C và label
                btC.BackColor = Color.Orange;
                lbC.BackColor = Color.Orange;

                btA.Enabled = false;
                btB.Enabled = false;
                btD.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "C"))
                {
                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void btD_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                ok = false;
                //đổi màu nút bấm B và label
                btD.BackColor = Color.Orange;
                lbD.BackColor = Color.Orange;

                btA.Enabled = false;
                btB.Enabled = false;
                btC.Enabled = false;

                //Bây giờ là lúc tôi đưa ra câu trả lời đúng
                C_AmThanh.batAmThanh("answer_t");

                //nếu trả lời đúng thì chuyển câu
                if (String.Equals(C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i), "D"))
                {

                    tmTraLoiDung.Enabled = true;
                    tmChuyenCau.Enabled = true;
                }
                //ngược lại thì tìm đáp án đúng
                else
                {
                    tmTimDapAn.Enabled = true;
                }
            }
        }

        private void tmTimDapAn_Tick(object sender, EventArgs e)
        {
            //nếu text của lbA trùng với đáp án trong CSDL thì đổi màu nút bấm A
            if (lbA.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btA.BackColor = Color.LimeGreen;
                lbA.BackColor = Color.LimeGreen;
            }
            //nếu text của lbB trùng với đáp án trong CSDL thì đổi màu nút bấm B
            if (lbB.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btB.BackColor = Color.LimeGreen;
                lbB.BackColor = Color.LimeGreen;
            }
            //nếu text của lbC trùng với đáp án trong CSDL thì đổi màu nút bấm C
            if (lbC.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btC.BackColor = Color.LimeGreen;
                lbC.BackColor = Color.LimeGreen;
            }
            //nếu text của lbD trùng với đáp án trong CSDL thì đổi màu nút bấm D
            if (lbD.Text == C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i))
            {
                btD.BackColor = Color.LimeGreen;
                lbD.BackColor = Color.LimeGreen;
            }

            //bật âm thanh trả lời sai
            C_AmThanh.batAmThanh("bgmusic_answer_f");

            bt5050.Enabled = false;
            btDung.Enabled = false;

            btA.Enabled = false;
            btB.Enabled = false;
            btC.Enabled = false;
            btD.Enabled = false;

            tmTimDapAn.Enabled = false;

            tmThuaCuoc.Enabled = true;
        }

        private void tmChuyenCau_Tick(object sender, EventArgs e)
        {
            //nếu câu tăng lên bằng 16 tức người chơi trả lời hết thì dừng
            if (c == 16)
            {
                tmChuyenCau.Enabled = false;
            }

            ok = true;

            //Cho phép lại các nút bấm
            btB.Enabled = true;
            btC.Enabled = true;
            btA.Enabled = true;
            btD.Enabled = true;

            //Chuyển lại màu nút đáp an
            btA.BackColor = Color.Blue;
            btB.BackColor = Color.Blue;
            btC.BackColor = Color.Blue;
            btD.BackColor = Color.Blue;

            //Chuyển màu nền label
            lbA.BackColor = Color.Blue;
            lbB.BackColor = Color.Blue;
            lbC.BackColor = Color.Blue;
            lbD.BackColor = Color.Blue;

            //tăng câu hỏi lên
            c++;
            lbSoCau.Text = "Câu " + c.ToString();

            //Đọc số câu hỏi
            string cauHoi = "start_cau" + c.ToString();
            C_AmThanh.batAmThanh(cauHoi);

            //Đọc câu hỏi và các phương án
            tmCauHoi.Enabled = true;

            #region đổi màu các mốc câu hỏi
            if (c == 1)
            {
                lb1.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;


            }

            if (c == 2)
            {
                lb2.BackColor = Color.Orange;

                lb1.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;


            }
            if (c == 3)
            {
                lb3.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 4)
            {
                lb4.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 5)
            {
                lb5.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 6)
            {
                lb6.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 7)
            {
                lb7.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 8)
            {
                lb8.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 9)
            {
                lb9.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 10)
            {
                lb10.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 11)
            {
                lb11.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 12)
            {
                lb12.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 13)
            {
                lb13.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 14)
            {
                lb14.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;
                lb15.BackColor = Color.SteelBlue;

            }
            if (c == 15)
            {
                lb15.BackColor = Color.Orange;

                lb2.BackColor = Color.SteelBlue;
                lb3.BackColor = Color.SteelBlue;
                lb4.BackColor = Color.SteelBlue;
                lb5.BackColor = Color.SteelBlue;
                lb6.BackColor = Color.SteelBlue;
                lb7.BackColor = Color.SteelBlue;
                lb8.BackColor = Color.SteelBlue;
                lb9.BackColor = Color.SteelBlue;
                lb10.BackColor = Color.SteelBlue;
                lb11.BackColor = Color.SteelBlue;
                lb12.BackColor = Color.SteelBlue;
                lb13.BackColor = Color.SteelBlue;
                lb14.BackColor = Color.SteelBlue;
                lb1.BackColor = Color.SteelBlue;

            }

            #endregion

            //đạt mốc 5 thì lấy dữ liệu câu hỏi bảng 2(khó dần lên)
            if (c == 6)
                bang = 2;

            //đạt mốc 10 thì lấy dữ liệu câu hỏi bảng 3(khó dần lên)
            if (c == 11)
                bang = 3;

            //lấy câu hỏi random trong bảng 1
            if (bang == 1)
            {
                do i = r.Next(1, 339);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;

                if (c == 5)
                {
                    cs = 0;
                    MangRandom = new int[5];
                }

            }
            //lấy câu hỏi random trong bảng 2
            if (bang == 2)
            {
                do i = r.Next(1, 84);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;
                if (c == 10)
                {
                    cs = 0;
                    MangRandom = new int[5];
                }

            }
            //lấy câu hỏi random trong bảng 3
            if (bang == 3)
            {
                do i = r.Next(1, 70);
                while (C_AmThanh.kiemTraCauHoi(i, MangRandom));

                //dùng mảng lưu lại kết quả random nếu trùng thì random lại
                MangRandom[cs] = i;
                cs++;
            }

            //Lấy dữ liệu lên câu hỏi, nếu độ dài câu hỏi vượt 50 kí tự thì cho xuống dòng
            string CauHoi = C_KetNoi.layDuLieu("SELECT CauHoi FROM tbl" + bang.ToString(), "CauHoi", i);
            if (CauHoi.Length >= 50)
            {
                lbCauHoi.Text = C_AmThanh.chenXuongDong(CauHoi, 50);
            }
            else
                lbCauHoi.Text = CauHoi;

            //Lấy dữ liệu lên các nút bấm
            btA.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT A FROM tbl" + bang.ToString(), "A", i));
            btB.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT B FROM tbl" + bang.ToString(), "B", i));
            btC.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT C FROM tbl" + bang.ToString(), "C", i));
            btD.Text = C_AmThanh.loaiDauSao(C_KetNoi.layDuLieu("SELECT D FROM tbl" + bang.ToString(), "D", i));

            tmChuyenCau.Interval = 5000;
            tmChuyenCau.Enabled = false;
        }

        private void tmTraLoiDung_Tick(object sender, EventArgs e)
        {
            //Âm thanh trả lời đúng
            C_AmThanh.batAmThanh("bgmusic_answer_t");

            //Đổi màu nền nút đáp an đúng
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "A")
            {
                btA.BackColor = Color.LimeGreen;
                lbA.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "B")
            {
                btB.BackColor = Color.LimeGreen;
                lbB.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "C")
            {
                btC.BackColor = Color.LimeGreen;
                lbC.BackColor = Color.LimeGreen;
            }
            if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) == "D")
            {
                btD.BackColor = Color.LimeGreen;
                lbD.BackColor = Color.LimeGreen;
            }

            tmTraLoiDung.Enabled = false;
        }

        //bấm play
        private void tmBatDau_Tick(object sender, EventArgs e)
        {
            //Hiện 4 nút chọn đáp án
            btA.Show();
            btB.Show();
            btC.Show();
            btD.Show();

            lbA.Text = "A";
            lbB.Text = "B";
            lbC.Text = "C";
            lbD.Text = "D";

            tmBatDau.Enabled = false;
        }
        //trợ giúp 50 50
        private void tm5050_Tick(object sender, EventArgs e)
        {
            int a = 0;

            while (a != 2)
            {
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbA.Text)
                {
                    btA.Text = "";
                    btA.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbD.Text)
                {
                    btD.Text = "";
                    btD.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbB.Text)
                {
                    btB.Text = "";
                    btB.Enabled = false;
                    a++;
                    if (a == 2) break;
                }
                if (C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i) != lbC.Text)
                {
                    btC.Text = "";
                    btC.Enabled = false;
                    a++;
                    if (a == 2) break;
                }

            }

            tm5050.Enabled = false;
        }
        //đọc câu hỏi và các phương án trả lời
        private void tmCauHoi_Tick(object sender, EventArgs e)
        {
            //Lấy tiêu đề âm thanh trong bảng để bật đúng âm thanh
            string AmThanh = C_KetNoi.layDuLieu("SELECT AmThanh FROM tbl" + bang.ToString(), "AmThanh", i);
            AmThanh = AmThanh.Trim();
            //bật nhạc
            C_AmThanh.batAmThanh(AmThanh);

            tmCauHoi.Enabled = false;
        }

        public static FmKhoiDong fmKhoiDong = new FmKhoiDong();
        //chơi lại
        private void tmChoiLai_Tick(object sender, EventArgs e)
        {
            bang = 1;
            c = 0;

            tmDemGio.Enabled = false;
            tongThoiGian = 0;

            cs = 0;
            MangRandom = new int[5];

            bt5050.Enabled = true;
            btDung.Enabled = true;

            ptbKinhLup.Visible = true;
            ptbKinhLup.Enabled = true;

            btA.Enabled = true;
            btB.Enabled = true;
            btC.Enabled = true;
            btD.Enabled = true;


            fmKhoiDong.Show();
            fmKhoiDong.btBatDau.Show();
            this.Hide();

            tmChoiLai.Enabled = false;
        }

        //trợ giúp 50 50
        private void bt5050_Click(object sender, EventArgs e)
        {
            C_AmThanh.tatAmThanh();
            tm5050.Enabled = true;

            bt5050.Enabled = false;
            bt5050.Visible = false;
        }

        //trợ giúp dừng chơi
        private void btDung_Click(object sender, EventArgs e)
        {
            // 1. Tạm dừng đồng hồ để hỏi ý kiến
            C_AmThanh.tatAmThanh();
            bool trangThaiDongHo = tmDemGio.Enabled;
            tmDemGio.Enabled = false;

            // 2. Hỏi người dùng
            DialogResult kq = MessageBox.Show("Bạn có muốn dừng cuộc chơi và bảo toàn tiền thưởng?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                // --- NẾU ĐỒNG Ý DỪNG ---

                // A. Tính tiền theo luật Dừng Cuộc Chơi (Hàm mới viết ở Bước 1)
                string tienThuong = LayTienDungCuocChoi();

                // B. Lấy thời gian
                string thoiGian = tongThoiGian.ToString();

                // C. Hiện Form Kết Quả
                FormResult frm = new FormResult(tienThuong, thoiGian);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);

                // D. Xử lý sau khi tắt Form Kết Quả (Giống hệt lúc thua)
                if (frm.UserAction == FormResult.LuaChon.ChoiLai)
                {
                    tmChoiNgay.Enabled = true;
                }
                else // Về trang chủ hoặc tắt form
                {
                    tmChoiLai.Interval = 100;
                    tmChoiLai.Enabled = true;
                }
            }
            else
            {
                // --- NẾU KHÔNG MUỐN DỪNG (CHƠI TIẾP) ---

                // Bật lại đồng hồ nếu lúc nãy nó đang chạy
                if (trangThaiDongHo == true)
                {
                    tmDemGio.Enabled = true;
                }
            }
        }
        private string LayTienDungCuocChoi()
        {
            // Luật: Dừng cuộc chơi thì lấy tiền của câu trước đó (c - 1)
            switch (c)
            {
                case 1: return "0 VNĐ";             // Đang câu 1 dừng -> 0 đồng
                case 2: return "200.000 VNĐ";       // Đang câu 2 dừng -> Lấy 200k
                case 3: return "400.000 VNĐ";
                case 4: return "600.000 VNĐ";
                case 5: return "1.000.000 VNĐ";
                case 6: return "2.000.000 VNĐ";
                case 7: return "3.000.000 VNĐ";
                case 8: return "6.000.000 VNĐ";
                case 9: return "10.000.000 VNĐ";
                case 10: return "14.000.000 VNĐ";
                case 11: return "22.000.000 VNĐ";
                case 12: return "30.000.000 VNĐ";
                case 13: return "40.000.000 VNĐ";
                case 14: return "60.000.000 VNĐ";
                case 15: return "85.000.000 VNĐ";
                case 16: return "150.000.000 VNĐ"; // Chiến thắng
                default: return "0 VNĐ";
            }
        }


        //sau khi thua cuộc
        private void tmThuaCuoc_Tick(object sender, EventArgs e)
        {
            tmThuaCuoc.Enabled = false;
            tmDemGio.Enabled = false;
            C_AmThanh.batAmThanh("sound_ket_thuc");
            // 1. Tính tiền thưởng
            string tienThuong = LayTienThuong();

            // 2. Lấy thời gian (Code hiện tại của bạn chưa có biến đếm giờ nên mình để tạm text này)
            // Nếu sau này bạn thêm biến đếm giờ (ví dụ int thoiGian), hãy thay vào đây.
            string thoiGianChoi = tongThoiGian.ToString();

            // 3. Khởi tạo và hiện Form Thành Tích
            // (Đảm bảo bạn đã sửa FormThanhTich để nhận 2 biến string như hướng dẫn trước)
            FormResult frm = new FormResult(tienThuong, thoiGianChoi);

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this); // Hiện form kết quả (chờ người dùng bấm nút ở form kia)


            // --- KẾT THÚC ĐOẠN CODE THÊM MỚI ---
            if (frm.UserAction == FormResult.LuaChon.ChoiLai)
            {
                // Nếu chọn Chơi Lại -> Gọi timer "Chơi Ngay" (Logic reset game của bạn)
                tmChoiNgay.Enabled = true;
            }
            else if (frm.UserAction == FormResult.LuaChon.TrangChu)
            {
                tmChoiLai.Interval = 100;
                // Nếu chọn Trang Chủ -> Gọi timer "Chơi Lại" (Logic về màn hình chính của bạn)
                tmChoiLai.Enabled = true;
            }
            else
            {
                // Trường hợp người dùng bấm dấu X đỏ để tắt form kết quả
                // Bạn có thể chọn cho về trang chủ hoặc thoát luôn
                // Ở đây mình để mặc định là về trang chủ cho an toàn
                tmChoiLai.Interval = 100;
                tmChoiLai.Enabled = true;
            }

        }

        private void ptbThuaCuoc_Click(object sender, EventArgs e)
        {
            tmChoiLai.Enabled = false;
            tmChoiNgay.Enabled = true;
        }

        private void tmChoiNgay_Tick(object sender, EventArgs e)
        {

            tmChuyenCau.Interval = 100;
            tmChuyenCau.Enabled = true;

            bang = 1;
            c = 0;

            tongThoiGian = 0;
            tmDemGio.Enabled = true;

            cs = 0;
            MangRandom = new int[5];

            bt5050.Enabled = true;
            btDung.Enabled = true;

            ptbKinhLup.Visible = true;
            ptbKinhLup.Enabled = true;

            btA.Enabled = true;
            btB.Enabled = true;
            btC.Enabled = true;
            btD.Enabled = true;


            tmChoiNgay.Enabled = false;
        }

        private void FmChinh_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            C_KetNoi.dongKetNoi();
            Application.Exit();
        }

        private void btThongTin_Click(object sender, EventArgs e)
        {

        }

        private void tmDemGio_Tick(object sender, EventArgs e)
        {
            tongThoiGian++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnKinhLup_Click(object sender, EventArgs e)
        {
            tmCauHoi.Enabled = false;
            C_AmThanh.tatAmThanh();
            // 1. Khóa và ẩn trợ giúp này đi để không dùng lại được
            ptbKinhLup.Enabled = false;
            ptbKinhLup.Visible = false; // Ẩn đi cho "mất" như bạn yêu cầu

            // Có thể thêm âm thanh khi chọn trợ giúp nếu muốn
            // C_AmThanh.batAmThanh("sound_chon_kinh_lup");

            // 2. Khóa các tương tác khác để tránh lỗi
            ok = false; // Khóa biến cờ cho phép bấm nút
            btA.Enabled = false; btB.Enabled = false;
            btC.Enabled = false; btD.Enabled = false;

            // 3. Lấy đáp án đúng từ CSDL
            string dapAnDung = C_KetNoi.layDuLieu("SELECT DapAn FROM tbl" + bang.ToString(), "DapAn", i);

            // 4. So sánh và đổi màu đáp án đúng sang màu xanh (LimeGreen) ngay lập tức
            if (dapAnDung == "A")
            {
                btA.BackColor = Color.LimeGreen;
                lbA.BackColor = Color.LimeGreen;
            }
            else if (dapAnDung == "B")
            {
                btB.BackColor = Color.LimeGreen;
                lbB.BackColor = Color.LimeGreen;
            }
            else if (dapAnDung == "C")
            {
                btC.BackColor = Color.LimeGreen;
                lbC.BackColor = Color.LimeGreen;
            }
            else if (dapAnDung == "D")
            {
                btD.BackColor = Color.LimeGreen;
                lbD.BackColor = Color.LimeGreen;
            }

            // 5. Bật âm thanh trả lời đúng
            C_AmThanh.batAmThanh("bgmusic_answer_t");

            tmChuyenCau.Interval = 2000;

            // 6. Bật timer chuyển câu để tự động sang câu mới sau vài giây
            tmChuyenCau.Enabled = true;
        }

        // Hàm này tính tiền dựa trên câu đang chơi (biến c)
        private string LayTienThuong()
        {
            // --- LUẬT 1: Từ câu 11 trở lên, thua thì về mốc câu 10 (22 Triệu) ---
            // (Biến c là câu đang chơi. Ví dụ đang chơi câu 11 mà thua thì vẫn tính là > 10)
            if (c > 10)
            {
                return "22.000.000 VNĐ";
            }

            // --- LUẬT 2: Từ câu 1 đến câu 10, thua thì nhận tiền câu trước đó ---
            switch (c)
            {
                case 1: return "0 VNĐ";            // Đang chơi câu 1 thua -> chưa được đồng nào
                case 2: return "200.000 VNĐ";      // Đang chơi câu 2 thua -> Lấy tiền câu 1
                case 3: return "400.000 VNĐ";      // Đang chơi câu 3 thua -> Lấy tiền câu 2
                case 4: return "600.000 VNĐ";      // ...
                case 5: return "1.000.000 VNĐ";
                case 6: return "2.000.000 VNĐ";
                case 7: return "3.000.000 VNĐ";
                case 8: return "6.000.000 VNĐ";
                case 9: return "10.000.000 VNĐ";
                case 10: return "14.000.000 VNĐ";  // Đang chơi câu 10 thua -> Lấy tiền câu 9
                default: return "0 VNĐ";
            }
        }


    }
}
