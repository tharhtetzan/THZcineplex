namespace THZcineplex
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Panel();
            this.Creator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.header2 = new System.Windows.Forms.Panel();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.AddPoint = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.TextBox();
            this.horipanel = new System.Windows.Forms.Panel();
            this.Noti = new System.Windows.Forms.Panel();
            this.NowShowing = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.footer2 = new System.Windows.Forms.Panel();
            this.seatpicturepanel = new System.Windows.Forms.Panel();
            this.ThzCineplex = new System.Windows.Forms.Label();
            this.notitimer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.horipanel.SuspendLayout();
            this.NowShowing.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.seatpicturepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header.Controls.Add(this.minimize);
            this.header.Controls.Add(this.CloseApp);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1370, 19);
            this.header.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Gold;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.Location = new System.Drawing.Point(1271, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(53, 19);
            this.minimize.TabIndex = 7;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.Maroon;
            this.CloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseApp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseApp.Location = new System.Drawing.Point(1324, 0);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(46, 19);
            this.CloseApp.TabIndex = 6;
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click_1);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footer.Controls.Add(this.Creator);
            this.footer.Controls.Add(this.button1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 734);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1370, 38);
            this.footer.TabIndex = 2;
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.BackColor = System.Drawing.Color.Transparent;
            this.Creator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Creator.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Creator.Location = new System.Drawing.Point(8, 18);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(120, 13);
            this.Creator.TabIndex = 0;
            this.Creator.Text = "Created by - EpicASIAN";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1288, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.header2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.header2.Controls.Add(this.Profile);
            this.header2.Controls.Add(this.AddPoint);
            this.header2.Controls.Add(this.Points);
            this.header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.header2.Location = new System.Drawing.Point(0, 19);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(1370, 48);
            this.header2.TabIndex = 3;
            // 
            // Profile
            // 
            this.Profile.ErrorImage = null;
            this.Profile.Image = global::THZcineplex.Properties.Resources.profile;
            this.Profile.InitialImage = global::THZcineplex.Properties.Resources.profile;
            this.Profile.Location = new System.Drawing.Point(11, 6);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(37, 39);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile.TabIndex = 6;
            this.Profile.TabStop = false;
            // 
            // AddPoint
            // 
            this.AddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPoint.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.AddPoint.FlatAppearance.BorderSize = 0;
            this.AddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPoint.Location = new System.Drawing.Point(1345, 19);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(18, 20);
            this.AddPoint.TabIndex = 5;
            this.AddPoint.UseVisualStyleBackColor = false;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // Points
            // 
            this.Points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Points.Location = new System.Drawing.Point(1220, 19);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(125, 20);
            this.Points.TabIndex = 1;
            this.Points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // horipanel
            // 
            this.horipanel.Controls.Add(this.Noti);
            this.horipanel.Controls.Add(this.NowShowing);
            this.horipanel.Controls.Add(this.footer2);
            this.horipanel.Controls.Add(this.seatpicturepanel);
            this.horipanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horipanel.Location = new System.Drawing.Point(0, 0);
            this.horipanel.Name = "horipanel";
            this.horipanel.Size = new System.Drawing.Size(1370, 772);
            this.horipanel.TabIndex = 5;
            this.horipanel.Paint += new System.Windows.Forms.PaintEventHandler(this.horipanel_Paint);
            // 
            // Noti
            // 
            this.Noti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Noti.BackgroundImage = global::THZcineplex.Properties.Resources.red_shading_background_05_hd_pictures_169759;
            this.Noti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Noti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Noti.Location = new System.Drawing.Point(858, 351);
            this.Noti.Name = "Noti";
            this.Noti.Size = new System.Drawing.Size(487, 351);
            this.Noti.TabIndex = 3;
            // 
            // NowShowing
            // 
            this.NowShowing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NowShowing.Controls.Add(this.label1);
            this.NowShowing.Controls.Add(this.panel1);
            this.NowShowing.Controls.Add(this.panel2);
            this.NowShowing.Controls.Add(this.panel3);
            this.NowShowing.Location = new System.Drawing.Point(30, 315);
            this.NowShowing.Name = "NowShowing";
            this.NowShowing.Size = new System.Drawing.Size(813, 392);
            this.NowShowing.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Now Showing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 351);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THZcineplex.Properties.Resources.Avengers_Endgame_poster;
            this.pictureBox1.Location = new System.Drawing.Point(10, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(270, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 351);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::THZcineplex.Properties.Resources.DetectivePikachu;
            this.pictureBox2.Location = new System.Drawing.Point(11, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(537, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 351);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::THZcineplex.Properties.Resources.GoodBoys;
            this.pictureBox3.Location = new System.Drawing.Point(10, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(239, 327);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // footer2
            // 
            this.footer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(9)))), ((int)(((byte)(10)))));
            this.footer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer2.Location = new System.Drawing.Point(0, 718);
            this.footer2.Name = "footer2";
            this.footer2.Size = new System.Drawing.Size(1370, 54);
            this.footer2.TabIndex = 1;
            // 
            // seatpicturepanel
            // 
            this.seatpicturepanel.BackgroundImage = global::THZcineplex.Properties.Resources.seats;
            this.seatpicturepanel.Controls.Add(this.ThzCineplex);
            this.seatpicturepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.seatpicturepanel.Location = new System.Drawing.Point(0, 0);
            this.seatpicturepanel.Name = "seatpicturepanel";
            this.seatpicturepanel.Size = new System.Drawing.Size(1370, 313);
            this.seatpicturepanel.TabIndex = 0;
            // 
            // ThzCineplex
            // 
            this.ThzCineplex.AutoSize = true;
            this.ThzCineplex.BackColor = System.Drawing.Color.Transparent;
            this.ThzCineplex.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThzCineplex.ForeColor = System.Drawing.SystemColors.Control;
            this.ThzCineplex.Location = new System.Drawing.Point(483, 127);
            this.ThzCineplex.Name = "ThzCineplex";
            this.ThzCineplex.Size = new System.Drawing.Size(433, 114);
            this.ThzCineplex.TabIndex = 18;
            this.ThzCineplex.Text = "THZ-cineplex";
            // 
            // notitimer
            // 
            this.notitimer.Interval = 2000;
            this.notitimer.Tick += new System.EventHandler(this.notitimer_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.horipanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.header.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.header2.ResumeLayout(false);
            this.header2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.horipanel.ResumeLayout(false);
            this.NowShowing.ResumeLayout(false);
            this.NowShowing.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.seatpicturepanel.ResumeLayout(false);
            this.seatpicturepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel header2;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Panel horipanel;
        private System.Windows.Forms.Panel seatpicturepanel;
        private System.Windows.Forms.Panel footer2;
        private System.Windows.Forms.Panel Noti;
        private System.Windows.Forms.Panel NowShowing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ThzCineplex;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer notitimer;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Label Creator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}