using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AiLaTrieuPhu
{
    class C_AmThanh
    {
        private static WMPLib.WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();

        //bật âm thanh
        public static void batAmThanh(string ten)
        {

            sound.URL = @"Audio\" + ten + ".mp3";
            sound.controls.play();

            ////thêm đường dẫn thư mục Audio
            //SoundPlayer Sound = new SoundPlayer(@"Audio\" + ten);
            //Sound.Play();
        }
        public static void tatAmThanh()
        {
            try
            {
                sound.controls.stop(); // Lệnh dừng phát nhạc
            }
            catch { }
        }
        //

        //chèn kí tự xuống dòng vào một xâu
        public static string chenXuongDong(string chen, int viTri)
        {
            while (viTri < chen.Length)
            {
                if (string.Equals(chen[viTri].ToString(), " "))
                    break;
                else
                {
                    if (string.Equals(chen[viTri].ToString(), "?"))
                        return chen;
                    else
                        viTri++;
                }
            }
            if (viTri >= chen.Length) return chen;
            return chen = chen.Insert(viTri, "\n");
        }
        //Loại bỏ kí tự *** trong đáp án
        public static string loaiDauSao(string s)
        {
            if (s[s.Length - 1].ToString() == "*")
            {
                s = s.Substring(0, s.Length - 3);

            }

            return s;
        }

        //Kiểm tra câu hỏi có bị trùng không nếu trùng trả về true ngược lại false
        public static bool kiemTraCauHoi(int t, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (t == a[i])
                    return true;
            }

            return false;
        }
    }
}
