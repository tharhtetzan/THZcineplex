using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THZcineplex
{
    public partial class Vouncher : Form
    {
        //global vaiable
        public static int discounts = 0;
        int xheight, xwidth;

        public Vouncher()
        {
            InitializeComponent();
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

        private void nameassigning() {
            date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Random random = new Random();
            receiptnumber.Text = (random.Next(100000,1000000)).ToString(); 
            salespersonname.Text = HomePage.theUserName;
            seatnamess.Text = MoviePage.totalseatnames;
            quantity.Text = (MoviePage.totalseats).ToString();
            price.Text = (MoviePage.totalseatamount).ToString();
            totalamount.Text = (MoviePage.totalseatamount).ToString();
            moviename.Text = HomePage.selectedmoviename;
            seatnum.Text = MoviePage.totalseatnames;
            showdate.Text = MoviePage.date;
            showtime.Text = MoviePage.time;
        }

        private void GotoHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
        }

        private void Vouncher_Load(object sender, EventArgs e)
        {
            nameassigning();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cashpanel.Enabled = true;
                cineplexpanel.Enabled = false;
                checkBox2.Checked = false;
            }
            else {
                cashpanel.Enabled = false;
                cineplexpanel.Enabled = true;
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                cashpanel.Enabled = false;
                cineplexpanel.Enabled = true;
                checkBox1.Checked = false;
            }
            else
            {
                cashpanel.Enabled = true;
                cineplexpanel.Enabled = false;
                checkBox1.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                payment.Text = "0";
            }
            else {
                payment.Text = textBox1.Text;
            }
            changecalculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox2.Text == "")
            {
                payment.Text = "0";
            }
            else
            {
                payment.Text = textBox2.Text;
            }
            changecalculate();
        }

        private void changecalculate(){
            if (Convert.ToInt64(payment.Text) > Convert.ToInt64(totalamount.Text))
            {
                change.Text = (Convert.ToInt64(payment.Text) - Convert.ToInt64(totalamount.Text)).ToString();
            }
            else {
                change.Text = "0";
            }
            grandtotal.Text = totalamount.Text;
        }

        // minus for cash
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 99)
            {
                textBox1.Text = (Convert.ToInt32(textBox1.Text) - 100).ToString();
            }
            else { }
        }

        //Plus for cash
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + 100).ToString();
        }

        //minus for cineplex coin
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) > 99)
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) - 100).ToString();
            }
            else { }
        }
        
        //plus for cineplex coin
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(textBox2.Text) + 100).ToString();
        }

        private void enterredeemcode_Click(object sender, EventArgs e)
        {
            if (redeemcode.Text == "thz") {
                discountredeemed.Text = "10%";
                Discountprecent.Text = "10%";
                discounts = 10/100;
            }
        }

        private void Discountprecent_TextChanged(object sender, EventArgs e)
        {
            grandtotal.Text = (Convert.ToInt64(totalamount.Text) - (Convert.ToInt64(totalamount.Text) * 0.1)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(payment.Text) < Convert.ToInt64(totalamount.Text))
            {
                MessageBox.Show("Invalid Amount");
            }
            else {
                MessageBox.Show("Pament Successful");
                panel2.Enabled = false;
                insert_to_database();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(payment.Text) < Convert.ToInt64(totalamount.Text))
            {
                MessageBox.Show("Invalid Amount");
            }
            else
            {
                MessageBox.Show("Pament Successful");
                panel2.Enabled = false;
                insert_to_database();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Service is Bugged. Try again Later");
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //screenshot
        private void screenshot_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomvalue = random.Next(1000000, 100000000);
            string img_path = "C:\\Users\\Dell\\source\\repos\\THZcineplex\\THZcineplex\\bin\\Debug\\image\\"+randomvalue.ToString()+".bmp"; 
            using (var bmp = new Bitmap(panel1.Width, panel1.Height)) {
                panel1.DrawToBitmap(bmp , new Rectangle(0,0,bmp.Width,bmp.Height));
                Image img = bmp;
                try
                {
                    if (img != null)
                    {
                        img.Save(img_path);
                        MessageBox.Show("image Saved");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There was a problem saving the file." +
                        "Check the file permissions.");
                }
            }
        }

        private void insert_to_database() {
            string insertQuery = "INSERT INTO `receipt`(`receipt_id`, `salesperson`, `buydate`, `seat_numbers`, `quantity`, `total_price`, `discount`, `tax`, `grand_total`, `payment`, `change`, `moviename`, `show_date`, `show_time`) VALUES (0,'"+HomePage.theUserName+"','"+ DateTime.Now.ToString("dddd, dd MMMM yyyy") + "','"+MoviePage.totalseatnames+"','"+MoviePage.totalseats+"','"+MoviePage.totalseatamount+"','"+Discountprecent.Text+"','"+taxamount.Text+"','"+payment.Text+"','"+grandtotal.Text+"','"+change.Text+"','"+moviename.Text+"','"+showdate.Text+"','"+showtime.Text+"')";
            executeQuery(insertQuery);
        }
        
    }
}
