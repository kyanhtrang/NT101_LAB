using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB03_BAI01
{
    public partial class LAB03_BAI01 : Form
    {
        public LAB03_BAI01()
        {
            InitializeComponent();
        }

        //Hàm chuyển từ hex sang string
        public static string HexToString(string InputText)
        {
            string[] bb = Enumerable.Range(0, InputText.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Char.ConvertFromUtf32(Convert.ToInt32(InputText.Substring(x, 2), 16)))
                             .ToArray();
            StringBuilder builder = new StringBuilder();
            foreach (string b in bb)
            {
                builder.Append(b);
            }
            return builder.ToString();
        }

        //Hàm băm text string dùng MD5
        public static string TextMD5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        //Hàm băm hex dùng MD5
        public static string HexMD5(string input)
        {
            input = HexToString(input);
            return TextMD5(input);
        }

        //Hàm hash 1 file sử dụng MD5
        public static string FileMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = new BufferedStream(File.OpenRead(filename), 4096))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Hàm băm text string sử dụng SHA1
        public static string TextSHA1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        //Hàm băm hex string sử dụng SHA1
        public static string HexSHA1(string input)
        {
            input = HexToString(input);
            return TextSHA1(input);
        }

        //Hàm băm 1 file sử dụng SHA1
        public static string FileSHA1(string filename)
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = new BufferedStream(File.OpenRead(filename), 4096))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Hàm băm text string sử dụng SHA384
        public static string TextSHA384(string input)
        {
            using (SHA384Managed sha384 = new SHA384Managed())
            {
                var hash = sha384.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        //Hàm băm hex string sử dụng SHA384
        public static string HexSHA384(string input)
        {
            input = HexToString(input);
            return TextSHA384(input);
        }

        //Hàm băm file sử dụng SHA384
        public static string FileSHA384(string filename)
        {
            using (var sha384 = SHA384.Create())
            {
                using (var stream = new BufferedStream(File.OpenRead(filename), 4096))
                {
                    var hash = sha384.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Hàm băm text string sử dụng SHA512
        public static string TextSHA512(string input)
        {
            using (SHA512Managed sha512 = new SHA512Managed())
            {
                var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        //Hàm băm hex string sử dụng SHA512
        public static string HexSHA512(string input)
        {
            input = HexToString(input);
            return TextSHA512(input);
        }

        //Hàm băm file sử dụng SHA512
        public static string FileSHA512(string filename)
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = new BufferedStream(File.OpenRead(filename), 4096))
                {
                    var hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Hàm băm text string sử dụng SHA256
        public static string TextSHA256(string input)
        {
            using (SHA256Managed sha256 = new SHA256Managed())
            {
                var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        //Hàm băm hex string sử dụng SHA256
        public static string HexSHA256(string input)
        {
            input = HexToString(input);
            return TextSHA256(input);

        }
        //Hàm băm file sử dụng SHA256
        public static string FileSHA256(string filename)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = new BufferedStream(File.OpenRead(filename), 4096))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Hàm xóa nội dung textbox
        private void Clear()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        //Hàm mở file
        private static string SelectFile()
        {
            var dlg = new OpenFileDialog()
            {
                RestoreDirectory = true
            };
            if (dlg.ShowDialog() != DialogResult.OK)
                return "";
            return dlg.FileName;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(cbFormat.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn kiểu dữ liệu cần băm!");
            }
            else if (cbFormat.SelectedItem.ToString() == "Text string")
            {
                if (checkMD5.Checked)
                {
                    outputMD5.Text = TextMD5(inputData.Text);
                }
                if(checkSHA1.Checked)
                {
                    outputSHA1.Text = TextSHA1(inputData.Text);
                }
                if(checkSHA384.Checked)
                {
                    outputSHA384.Text = TextSHA384(inputData.Text);
                }
                if (checkSHA256.Checked)
                {
                    outputSHA256.Text = TextSHA256(inputData.Text);
                }
                if(checkSHA512.Checked)
                {
                    outputSHA512.Text = TextSHA512(inputData.Text);
                }
            }
            else if (cbFormat.SelectedItem.ToString() == "Hex string")
            {
                if (inputData.TextLength % 2 != 0)
                {
                    MessageBox.Show("Số lượng byte dữ liệu đầu vào dưới dạng hex phải là số chẵn ! ");
                    return;
                }
                string input = inputData.Text;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > 'f')
                    {
                        MessageBox.Show("Dữ liệu đầu vào phải dưới dạng hex ! ");
                        return;
                    }
                }
                if (checkMD5.Checked)
                {
                    outputMD5.Text = HexMD5(inputData.Text);
                }
                if(checkSHA1.Checked)
                {
                    outputSHA1.Text = HexSHA1(inputData.Text);
                }
                if(checkSHA384.Checked)
                {
                    outputSHA384.Text = HexSHA384(inputData.Text);
                }
                if(checkSHA256.Checked)
                {
                    outputSHA256.Text = HexSHA256(inputData.Text);
                }    
                if(checkSHA512.Checked)
                {
                    outputSHA512.Text= HexSHA512(inputData.Text);
                }
            }
            else
            {
                if (checkMD5.Checked)
                {
                    outputMD5.Text = FileMD5(inputData.Text);
                }
                if(checkSHA1.Checked)
                {
                    outputSHA1.Text = FileSHA1(inputData.Text);
                }
                if(checkSHA384.Checked)
                {
                    outputSHA384.Text = FileSHA384(inputData.Text);
                }
                if (checkSHA256.Checked)
                {
                    outputSHA256.Text = FileSHA256(inputData.Text);
                }
                if (checkSHA512.Checked)
                {
                    outputSHA512.Text = FileSHA512(inputData.Text);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            inputData.Text = SelectFile();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
