using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THZcineplex
{
    public partial class HomePage : Form
    {
        //User Data variables
        public static string theUserName = "";
        public static int thePoints = 0;
        public static string theTicketsBought = "";
        public static string selectedmoviename = "";

        int count = 0;
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter txt = new StreamWriter("F:\\Project log file\\log.txt");
            txt.Write("");
            txt.Close();
            login ln = new login();
            this.Hide();
            ln.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string line1 = File.ReadLines("F:\\Project log file\\log.txt").First(); // gets the first line from file.
            theUserName = line1;
            thePoints = 10000;
            Points.Text = "100000";
            Points.Enabled = false;
            notitimer.Start();
        }

        //Close the app
        private void CloseApp_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Minimise the form
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        int countpanel = 0;
        //For Noti Slider
        private void notitimer_Tick(object sender, EventArgs e)
        {
            if (countpanel == 0)
            {
                Noti.BackgroundImage = Properties.Resources.promo1;
                countpanel = 1;
            }
            else
            {
                Noti.BackgroundImage = Properties.Resources.promo2;
                countpanel = 0;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            selectedmoviename = "AVENGERS END GAME";
            MoviePage moviep = new MoviePage();
            this.Hide();
            moviep.ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.Avengers_Endgame_poster;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Maroon;
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            TopUp topUp = new TopUp();
            topUp.ShowDialog();
        }

        private void getUserData() {

        }

        private void horipanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
