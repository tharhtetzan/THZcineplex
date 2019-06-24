using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THZcineplex
{
    public partial class MoviePage : Form
    {
        int percent;
        int otherfilmCount = 0;

        public static ArrayList list = new ArrayList();

        //Global Variables
        public static int totalseatamount = 0;
        public static int totalseats = 0;
        public static String totalseatnames = "";
        public static string date = "";
        public static string time = "";

        public MoviePage()
        {
            InitializeComponent();
        }

        private void MoviePage_Load(object sender, EventArgs e)
        {
            list.Clear();
            totalseatnames = ""; totalseatamount = 0; totalseats = 0; date = ""; time = "";
            percent = 0; circularProgressBar1.Value = 0;
            likemeter.Start(); otherfilmtimer.Start();
            webBrowser1.Navigate($"https://www.youtube.com/v/TcMBFSGVi1c");
        }

        //Close App
        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Minimise App
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GotoHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Close();
            homePage.ShowDialog();
        }

        private void likemeter_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value >= 90)
            {
                likemeter.Stop();
            }
            else
            {
                percent += 1;
                circularProgressBar1.Value += 1;
                likepercenttxt.Text = percent + "%";
            }    
        }

        private void otherfilmtimer_Tick(object sender, EventArgs e)
        {
            if (otherfilmCount == 1)
            {
                otherfilmpanel.BackgroundImage = Properties.Resources.DetectivePikachu;
                otherfilmCount = 0;
            }
            else {
                otherfilmpanel.BackgroundImage = Properties.Resources.GoodBoys;
                otherfilmCount = 1;
            }
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            TopUp topUp = new TopUp();
            topUp.ShowDialog();
        }

        public void takeseatname()
        {
            SeatsValue.Text = totalseats.ToString();
            SeatPrice.Text = totalseatamount.ToString();
            string seatnames = "";
            foreach (string j in list)
            {
                seatnames = seatnames + j + " ";
            }
            SeatNumber.Text = seatnames;
            totalseatnames = seatnames; // set global variable;
        }

        //Seat Value = 2000
        private void S1_Click(object sender, EventArgs e)
        {
            if (S1.BackColor == Color.Gainsboro)
            {
                S1.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S1 ");
            }
            else {
                S1.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S1 ");
            }
            takeseatname();
        }

        private void S2_Click(object sender, EventArgs e)
        {
            if(S2.BackColor == Color.Gainsboro)
            {
                S2.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S2 ");
            }
            else {
                S2.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S2 ");
            }
            takeseatname();
        }

        private void S3_Click(object sender, EventArgs e)
        {
            if (S3.BackColor == Color.Gainsboro)
            {
                S3.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S3 ");
            }
            else
            {
                S3.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S3 ");
            }
            takeseatname();
        }

        private void S4_Click(object sender, EventArgs e)
        {
            if (S4.BackColor == Color.Gainsboro)
            {
                S4.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S4 ");
            }
            else
            {
                S4.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S4 ");
            }
            takeseatname();
        }

        private void S5_Click(object sender, EventArgs e)
        {
            if (S5.BackColor == Color.Gainsboro)
            {
                S5.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S5 ");
            }
            else
            {
                S5.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S5 ");
            }
            takeseatname();
        }

        private void S6_Click(object sender, EventArgs e)
        {
            if (S6.BackColor == Color.Gainsboro)
            {
                S6.BackColor = Color.DimGray;
                totalseatamount += 2000;
                totalseats += 1;
                list.Add("S6 ");
            }
            else
            {
                S6.BackColor = Color.Gainsboro;
                totalseatamount -= 2000;
                totalseats -= 1;
                list.Remove("S6 ");
            }
            takeseatname();
        }

        //Seat Value = 2500
        private void S7_Click(object sender, EventArgs e)
        {
            if (S7.BackColor == Color.Gainsboro)
            {
                S7.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S7 ");
            }
            else
            {
                S7.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S7 ");
            }
            takeseatname();
        }

        private void S8_Click(object sender, EventArgs e)
        {
            if (S8.BackColor == Color.Gainsboro)
            {
                S8.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S8 ");
            }
            else
            {
                S8.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S8 ");
            }
            takeseatname();
        }

        private void S9_Click(object sender, EventArgs e)
        {
            if (S9.BackColor == Color.Gainsboro)
            {
                S9.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S9 ");
            }
            else
            {
                S9.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S9 ");
            }
            takeseatname();
        }

        private void S10_Click(object sender, EventArgs e)
        {
            if (S10.BackColor == Color.Gainsboro)
            {
                S10.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S10");
            }
            else
            {
                S10.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S10");
            }
            takeseatname();
        }

        private void S11_Click(object sender, EventArgs e)
        {
            if (S11.BackColor == Color.Gainsboro)
            {
                S11.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S11");
            }
            else
            {
                S11.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S11");
            }
            takeseatname();
        }

        private void S12_Click(object sender, EventArgs e)
        {
            if (S12.BackColor == Color.Gainsboro)
            {
                S12.BackColor = Color.DimGray;
                totalseatamount += 2500;
                totalseats += 1;
                list.Add("S12");
            }
            else
            {
                S12.BackColor = Color.Gainsboro;
                totalseatamount -= 2500;
                totalseats -= 1;
                list.Remove("S12");
            }
            takeseatname();
        }

        //3000 ks , Green Row
        private void S13_Click(object sender, EventArgs e)
        {
            if (S13.BackColor == Color.Gainsboro)
            {
                S13.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S13");
            }
            else
            {
                S13.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S13");
            }
            takeseatname();
        }

        private void S14_Click(object sender, EventArgs e)
        {
            if (S14.BackColor == Color.Gainsboro)
            {
                S14.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S14");
            }
            else
            {
                S14.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S14");
            }
            takeseatname();
        }

        private void S15_Click(object sender, EventArgs e)
        {
            if (S15.BackColor == Color.Gainsboro)
            {
                S15.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S15");
            }
            else
            {
                S15.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S15");
            }
            takeseatname();
        }

        private void S16_Click(object sender, EventArgs e)
        {
            if (S16.BackColor == Color.Gainsboro)
            {
                S16.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S16");
            }
            else
            {
                S16.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S16");
            }
            takeseatname();
        }

        private void S17_Click(object sender, EventArgs e)
        {
            if (S17.BackColor == Color.Gainsboro)
            {
                S17.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S17");
            }
            else
            {
                S17.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S17");
            }
            takeseatname();
        }

        private void S18_Click(object sender, EventArgs e)
        {
            if (S18.BackColor == Color.Gainsboro)
            {
                S18.BackColor = Color.DimGray;
                totalseatamount += 3000;
                totalseats += 1;
                list.Add("S18");
            }
            else
            {
                S18.BackColor = Color.Gainsboro;
                totalseatamount -= 3000;
                totalseats -= 1;
                list.Remove("S18");
            }
            takeseatname();
        }

        //3500 ks , Green Row
        private void S19_Click(object sender, EventArgs e)
        {
            if (S19.BackColor == Color.Gainsboro)
            {
                S19.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S19");
            }
            else
            {
                S19.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S19");
            }
            takeseatname();
        }

        private void S20_Click(object sender, EventArgs e)
        {
            if (S20.BackColor == Color.Gainsboro)
            {
                S20.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S20");
            }
            else
            {
                S20.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S20");
            }
            takeseatname();
        }

        private void S21_Click(object sender, EventArgs e)
        {
            if (S21.BackColor == Color.Gainsboro)
            {
                S21.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S21");
            }
            else
            {
                S21.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S21");
            }
            takeseatname();
        }

        private void S22_Click(object sender, EventArgs e)
        {
            if (S22.BackColor == Color.Gainsboro)
            {
                S22.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S22");
            }
            else
            {
                S22.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S22");
            }
            takeseatname();
        }

        private void S23_Click(object sender, EventArgs e)
        {
            if (S23.BackColor == Color.Gainsboro)
            {
                S23.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S23");
            }
            else
            {
                S23.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S23");
            }
            takeseatname();
        }

        private void S24_Click(object sender, EventArgs e)
        {
            if (S24.BackColor == Color.Gainsboro)
            {
                S24.BackColor = Color.DimGray;
                totalseatamount += 3500;
                totalseats += 1;
                list.Add("S24");
            }
            else
            {
                S24.BackColor = Color.Gainsboro;
                totalseatamount -= 3500;
                totalseats -= 1;
                list.Remove("S24");
            }
            takeseatname();
        }

        //10000 ks , Couple seat(Red)
        private void S25_Click(object sender, EventArgs e)
        {
            if (S25.BackColor == Color.Gainsboro)
            {
                S25.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S25");
            }
            else
            {
                S25.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S25");
            }
            takeseatname();
        }

        private void S26_Click(object sender, EventArgs e)
        {
            if (S26.BackColor == Color.Gainsboro)
            {
                S26.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S26");
            }
            else
            {
                S26.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S26");
            }
            takeseatname();
        }

        private void S27_Click(object sender, EventArgs e)
        {
            if (S27.BackColor == Color.Gainsboro)
            {
                S27.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S27");
            }
            else
            {
                S27.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S27");
            }
            takeseatname();
        }

        private void S28_Click(object sender, EventArgs e)
        {
            if (S28.BackColor == Color.Gainsboro)
            {
                S28.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S28");
            }
            else
            {
                S28.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S28");
            }
            takeseatname();
        }

        private void S29_Click(object sender, EventArgs e)
        {
            if (S29.BackColor == Color.Gainsboro)
            {
                S29.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S29");
            }
            else
            {
                S29.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S29");
            }
            takeseatname();
        }

        private void S30_Click(object sender, EventArgs e)
        {
            if (S30.BackColor == Color.Gainsboro)
            {
                S30.BackColor = Color.DimGray;
                totalseatamount += 10000;
                totalseats += 1;
                list.Add("S30");
            }
            else
            {
                S30.BackColor = Color.Gainsboro;
                totalseatamount -= 10000;
                totalseats -= 1;
                list.Remove("S30");
            }
            takeseatname();
        }

        //Buy 
        private void buybtn_Click(object sender, EventArgs e)
        {
            if (totalseats == 0) {
                notickets.Visible = true;
            }
            else {
                notickets.Visible = false;
                date = dateTimePicker1.Text;
                time = showtime.Text;
                Vouncher vouncher = new Vouncher();
                this.Hide();
                vouncher.ShowDialog();
            }
        }

        private void circulartimer_Tick(object sender, EventArgs e)
        {
        }
    }
}
