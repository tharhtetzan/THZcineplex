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
    public partial class CC : Form
    {
        //Data to transfer
        public static string theusername = "";
        public static string thepassword = "";
        public static int checkforlogin = 0;
        int checks = 0;//check if all the statements are correct

        public CC()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
            password.UseSystemPasswordChar = true;
            password.UseSystemPasswordChar = true;
            confirmpassword.UseSystemPasswordChar = true;
        }

        MySqlConnection connection1 = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ; database = thzcineplus");
        MySqlCommand command;

        MySqlDataReader rd1;

        String testname;

        public void openConnection()
        {
            if (connection1.State == ConnectionState.Closed)
            {
                connection1.Open();
            }
        }

        public void closeConnection()
        {
            if (connection1.State == ConnectionState.Open)
            {
                connection1.Close();
            }
        }

        public void executeQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection1);

                if (command.ExecuteNonQuery() == 1)
                {
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

        //Go to Login Page
        private void button1_Click(object sender, EventArgs e)
        {
            //Assign Values
            theusername = username.Text;
            thepassword = password.Text;
            checkforlogin = 1;

            gotologin();
        }

        //go to login function
        private void gotologin() {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        private void showpw_Click(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        //Show or Hide Password
        private void showcpw_Click(object sender, EventArgs e)
        {
            //Show password
            if (confirmpassword.UseSystemPasswordChar == true)
            {
                confirmpassword.UseSystemPasswordChar = false;
            }
            //Hide password
            else
            {
                confirmpassword.UseSystemPasswordChar = true;
            }
        }

        //Create Account
        private void buttoncreateaccount_Click(object sender, EventArgs e)
        {
            checks = 0;
            //check username null
            if (username.Text == "")
            {
                usernamenull.Visible = true;
            }
            else {
                //if username already exists in database
                SameName_Check();
            }

            //check email null
            if (email.Text == "")
            {
                emailnull.Visible = true;
            }
            else {
                //check valid email (google acc only)
                string checkemail = email.Text;
                if (checkemail.EndsWith("@gmail.com"))
                {
                    invalidemail.Visible = false;
                    emailnull.Visible = false; checks++;
                }
                else {
                    invalidemail.Visible = true;
                }
            }

            //check password null
            if (password.Text == "") {
                passwordnull.Visible = true;
            }
            else{
                passwordnull.Visible = false; checks++;
            }

            //check confirmpassword null
            if (confirmpassword.Text == "")
            {
                confirmpasswordnull.Visible = true;
            }
            else {
                confirmpasswordnull.Visible = false; 
                //Check if the passwords are the same
                //if they are not the same
                if (password.Text != confirmpassword.Text)
                {
                    passwordincorrect.Visible = true;
                }
                //if they are the same
                else {
                    passwordincorrect.Visible = false; checks++;
                }
            }

            //if all conditions are corrct or not
            //if correct
            if (checks == 4)
            {
                Sign_Up();
                //Disable Everything to prevent multiple account opening
                username.Enabled = false;
                email.Enabled = false;
                password.Enabled = false; showpw.Enabled = false;
                confirmpassword.Enabled = false; showcpw.Enabled = false;
                buttoncreateaccount.Enabled = false;
                button1.Enabled = false;
                //Show success panel
                successpanel.Visible = true;
            }
            //if not
            else {
                beep();
                successpanel.Visible = false;
            }

        }

        //Go Back To Login With Data
        private void gobacktologin_Click(object sender, EventArgs e)
        {
            //Assign Values
            theusername = username.Text;
            thepassword = password.Text;
            checkforlogin = 1;

            //Go to Page
            gotologin();
        }

        //sounds 
        public void beep() {
            System.Media.SystemSounds.Beep.Play();
        }

        //go to web page
        private void watermark_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tharhtetzan");
        }

        private void SameName_Check() {
            openConnection();
            string selectQuery = "SELECT `User_name` FROM `users` WHERE `User_name`= \"" + username.Text + "\"";

            command = new MySqlCommand(selectQuery, connection1);
            rd1 = command.ExecuteReader();

            while (rd1.Read())
            {
                testname = rd1.GetValue(0).ToString();
            }
            closeConnection();
            if (username.Text == testname)
                {
                    usernameused.Visible = true;
                }
                //if username does not exist
                else {
                    usernameused.Visible = false;
                    usernamenull.Visible = false; checks++;
                } 
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

        private void Sign_Up() {
            //Encrypt Password
            string EncryptionKey = "encryptionkey";
            string eStr = passwordEncrypt(password.Text, EncryptionKey);

            string insertQuery = "INSERT INTO `users`(`User_id`, `User_name`, `User_password`, `User_email`, `User_points`, `Tickets_bought`) VALUES (0,\""+username.Text+"\",\""+eStr+"\",\""+email.Text+"\",1000,0)";
            executeQuery(insertQuery);
        }
    }
}
