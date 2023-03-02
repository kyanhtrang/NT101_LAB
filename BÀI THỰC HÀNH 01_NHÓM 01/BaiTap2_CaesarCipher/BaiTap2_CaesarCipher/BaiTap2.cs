using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BaiTap2_CaesarCipher
{
    public partial class BaiTap2 : Form
    {
        private static int key;
        private static string input;

        public BaiTap2()
        {
            InitializeComponent();
        }

        private static char Cipher(char c, int key)
        {
            if (!char.IsLetter(c))
                return c;
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + key) - offset) % 26) + offset);
        }

        public static string Encrypt(string input, int key)
        {
            string output = string.Empty;
            foreach (char c in input)
                output += Cipher(c, key);
            return output;
        }

        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            input = inputText.Text;

            if (inputKey.Text == "")
            {
                string randomKey;
                Random rd = new Random();
                randomKey = (rd.Next (1, 25)).ToString();
                key = Int32.Parse(randomKey);
                inputKey.Text = key.ToString();
            }
            else
            {
                key = int.Parse(inputKey.Text);
            }

            outputText.Text = Encrypt(input, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int maxfre = 0;
            input = inputText.Text;

            if (inputKey.Text == "")
            {
                int[] c = new int[(int)char.MaxValue];

                foreach (char t in input)
                {
                    c[(int)t]++;
                }

                for (int i = 0; i < (int)char.MaxValue; i++)
                {
                    if (c[i] > 0 &&
                    char.IsLetterOrDigit((char)i))
                    {
                        if (maxfre <= c[i])
                        {
                            maxfre = c[i];
                            key = (int)(char)i - 101;
                        }
                    }
                }
                inputKey.Text = key.ToString();
            }
            else
            {
                key = int.Parse(inputKey.Text);
            }

            outputText.Text = Decrypt(input, key);
        }
    }
}
