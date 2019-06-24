using MySql.Data.MySqlClient;
using System;
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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ; database = thzcineplus");
        MySqlCommand command;

        //for User
        public void populateDGVU()
        {
            string selectQuery = "SELECT * FROM `receipt`";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            progressbartimer.Start();
            populateDGVU();
        }

        int count1, count2, count3 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            adminmovie adminmovie = new adminmovie();
            this.Hide();
            adminmovie.ShowDialog();
        }

        private void progressbartimer_Tick(object sender, EventArgs e)
        {
            if (ticketcircularProgressBar.Value >= 40)
            {
                if (count1 == 0)
                {
                    count1++;
                }
            }
            else
            {
                ticketcircularProgressBar.Value+=1;
            }

            if (thisweekcircularProgressBar.Value >= 90)
            {
                if (count2 == 0)
                {
                    count1++;
                }
            }
            else
            {
                thisweekcircularProgressBar.Value +=1;
            }

            if (pastweekcircularProgressBar.Value >= 40)
            {
                if (count3 == 0)
                {
                    count1++;
                }
            }
            else
            {
                pastweekcircularProgressBar.Value +=1;
            }

            if (count1 ==1 && count2 ==1 && count3 ==1) {
                progressbartimer.Stop();
            }
        }
    }
}
