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
    public partial class TopUp : Form
    {
        public static int topup = 0;

        public TopUp()
        {
            InitializeComponent();
        }

        private void exitTopup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValueMinus_Click(object sender, EventArgs e)
        {
            if (topup <= 100)
            {

            }
            else {
                topup -= 100;
                topupvalue.Text = topup.ToString();
                topuppoint.Text = topup.ToString();
                topupamount.Text = topup.ToString();
            }
        }

        private void ValuePlus_Click(object sender, EventArgs e)
        {
            topup += 100;
            topupvalue.Text = topup.ToString();
            topuppoint.Text = topup.ToString();
            topupamount.Text = topup.ToString();
        }

        private void topupvalue_TextChanged(object sender, EventArgs e)
        {
            topup = Convert.ToUInt16(topupvalue.Text);
            topupvalue.Text = topup.ToString();
            topuppoint.Text = topup.ToString();
            topupamount.Text = topup.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            ValuePlus.Enabled = false;
            ValueMinus.Enabled = false;
            topupvalue.Enabled = false;
            MessageBox.Show(topup + " points will be Added to Your Account");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopUp_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            formanimation.Interval = 10;
            formanimation.Tick += new EventHandler(fadeIn);
            formanimation.Start();
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                formanimation.Stop();
            }
            else {
                Opacity += 0.05;
            }  
        }
    }
}
