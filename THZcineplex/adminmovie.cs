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
    public partial class adminmovie : Form
    {
        public adminmovie()
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

        private void button3_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            this.Hide();
            adminHome.ShowDialog();
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

        //for User
        public void populateDGVU()
        {
            string selectQuery = "SELECT * FROM `movie`";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection1);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            insert_to_database();
            populateDGVU();
        }

        private void insert_to_database()
        {
            string insertQuery = "INSERT INTO `movie`(`movie_id`, `movie_name`, `detaillink`, `trailerlink`, `time_to_upload`) VALUES (0,'"+moviename.Text+"','"+moviedetaillink.Text+"','"+moviedetaillink.Text+"','"+movieuploadtime.Text+"')";
            executeQuery(insertQuery);
        }

        private void adminmovie_Load(object sender, EventArgs e)
        {
            populateDGVU();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE `movie` SET `movie_name`='"+umoviename.Text+"',`detaillink`='"+udetaillink.Text+"',`trailerlink`='"+utrailerlink.Text+"',`time_to_upload`='"+udateTimePicker1.Text+ "' WHERE `movie_id`="+Convert.ToInt64(id.Text) +"";
            executeQuery(updateQuery);
            populateDGVU();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            umoviename.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            udetaillink.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            utrailerlink.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            udateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            moviename.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            moviedetaillink.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            movietrailerlink.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            movieuploadtime.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
