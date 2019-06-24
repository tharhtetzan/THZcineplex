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
using MySql.Data.MySqlClient;

namespace THZcineplex
{
    public partial class login : Form
    {
        //Project Globalize Data
        public static string mainusername= "";
        public static string mainpassword= "";
        String testname, testpassword, testrole;

        public login()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;//Hide password
            adminpassword.UseSystemPasswordChar = true;//Hide password
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ; database = thzcineplus");
        MySqlCommand command;
        MySqlDataReader rd1;

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


        private void login_Load(object sender, EventArgs e)
        {
            //Assign Values
            if (CC.checkforlogin == 1)
            {
                username.Text = CC.theusername;
                password.Text = CC.thepassword;
                CC.checkforlogin = 0;
            }
            else
            {
                
            }
        }

        //Exit app
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Login 
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //check username null
            if (username.Text == "")
            {
                usernamenull.Visible = true; beep();
            }
            else {
                usernamenull.Visible = false;
            }

            //check password null
            if (password.Text == "")
            {
                passwordnull.Visible = true; beep();
            }
            else {
                passwordnull.Visible = false;
                LoginFunction();
            }
        }

        //Forget password 
        private void forgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpanel.Visible = true;
        }
        private void emailsend_Click(object sender, EventArgs e)
        {
            //Check valid email
            string a = email.Text;
            if (a.EndsWith("@gmail.com"))
            {
                invalidemail.Visible = false;
                forgetpanel.Visible = false;
                MessageBox.Show("You have send link to your email to change password.");
            }
            else {
                invalidemail.Visible = true; 
            }
        }

        //go to CreateAccount
        private void createaccount_Click(object sender, EventArgs e)
        {
            CC createAccount = new CC();
            this.Hide();
            createAccount.ShowDialog();
        }

        //show or hide password
        private void showpw_Click(object sender, EventArgs e)
        {
            //show password
            if (password.UseSystemPasswordChar == true)
            {
                password.UseSystemPasswordChar = false;
            }
            //hide password
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        //sounds 
        public void beep()
        {
            System.Media.SystemSounds.Beep.Play();
        }

        //Go to Web Page
        private void watermark_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tharhtetzan");
        }

        

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

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void invalidemail_DoubleClick(object sender, EventArgs e)
        {
            secretpanel.Visible = true;
            forgetpanel.Visible = false;
         }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (adminpassword.Text == "alohomora")
            {
                MessageBox.Show("Access granted");
                AdminHome adminHome = new AdminHome();
                this.Hide();
                adminHome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Denied");
                secretpanel.Visible = false;
            }
        }

        public void executeQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query not executed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                closeConnection();
            }
        }

        //Login Function
        private void LoginFunction() {
            openConnection();
            string selectQuery = "SELECT `User_name`, `User_password` FROM `users` WHERE `User_name`= \""+username.Text+"\"";
            
            command = new MySqlCommand(selectQuery, connection);
            rd1 = command.ExecuteReader();

            while (rd1.Read())
            {
                testname = rd1.GetValue(0).ToString();
                testpassword = rd1.GetValue(1).ToString();
            }
            closeConnection();

            string EncryptionKey = "encryptionkey";
            string eStr = passwordEncrypt(password.Text, EncryptionKey);

            if (username.Text == testname && eStr == testpassword)
            {

                //Save password and username in log file
                StreamWriter txt = new StreamWriter("F:\\Project log file\\log.txt");
                txt.WriteLine(username.Text);
                txt.WriteLine(eStr);
                txt.Close();

                //save data
                mainusername = username.Text;
                mainpassword = password.Text;

                //Disable and continue
                passwordincorrect.Visible = false;
                forgetpassword.Visible = false;

                //go to homepage
                this.Hide();
                HomePage homePage = new HomePage();
                homePage.Show();
            }
            else
            {
                beep();
                passwordincorrect.Visible = true;
                forgetpassword.Visible = true;
            }
        }

    }
}
    

