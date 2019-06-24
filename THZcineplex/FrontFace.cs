using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THZcineplex
{
    public partial class FrontFace : Form
    {
        //Pre login check
        public static string name = "";
        int gg = 0;

        public FrontFace()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
        }

        private void FrontFace_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void readdatafromlogfie()
        {
            //Read data from text file
            string[] lines;
            int count = 0;
            var list = new List<string>();
            var fileStream = new FileStream(@"F:\\Project log file\\log.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                if (streamReader.ReadLine() == null)
                {
                }
                else
                {
                    string line1 = File.ReadLines("F:\\Project log file\\log.txt").First(); // gets the first line from file.
                    name = line1;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        
                        gg = 1;
                        list.Add(line);
                    }
                }
            }

            
        }

        //Encrypt Data
        public static string passwordEncrypt(string inText, string key)
        {
            byte[] bytesBuff = Encoding.Unicode.GetBytes(inText);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    inText = Convert.ToBase64String(mStream.ToArray());
                }
            }
            return inText;
        }
        //Decrypting a string
        public static string passwordDecrypt(string cryptTxt, string key)
        {
            cryptTxt = cryptTxt.Replace(" ", "+");
            byte[] bytesBuff = Convert.FromBase64String(cryptTxt);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(key, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    cryptTxt = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            return cryptTxt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value >= 100)
            {
                timer1.Stop();

                readdatafromlogfie();
                //check passcode
                if (gg == 1)
                {
                    HomePage homePage = new HomePage();
                    this.Hide();
                    homePage.ShowDialog();
                }
                else
                {
                    login li = new login();
                    this.Hide();
                    li.ShowDialog();
                }
            }
            else {
                circularProgressBar1.Value += 5;
            }
        }
    }
}
