namespace THZcineplex
{
    partial class TopUp
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
            this.exitTopup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topupvalue = new System.Windows.Forms.TextBox();
            this.ValuePlus = new System.Windows.Forms.Button();
            this.ValueMinus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.topupamount = new System.Windows.Forms.TextBox();
            this.topuppoint = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.formanimation = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitTopup
            // 
            this.exitTopup.BackColor = System.Drawing.Color.Silver;
            this.exitTopup.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitTopup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.exitTopup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.exitTopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitTopup.Location = new System.Drawing.Point(422, 3);
            this.exitTopup.Name = "exitTopup";
            this.exitTopup.Size = new System.Drawing.Size(75, 16);
            this.exitTopup.TabIndex = 0;
            this.exitTopup.Text = "-";
            this.exitTopup.UseVisualStyleBackColor = false;
            this.exitTopup.Click += new System.EventHandler(this.exitTopup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitTopup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 25);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "THZPayy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Parabaik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "How Much Would You Like To Top Up?";
            // 
            // topupvalue
            // 
            this.topupvalue.Location = new System.Drawing.Point(199, 106);
            this.topupvalue.Name = "topupvalue";
            this.topupvalue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topupvalue.Size = new System.Drawing.Size(107, 20);
            this.topupvalue.TabIndex = 3;
            this.topupvalue.Text = "0";
            this.topupvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.topupvalue.TextChanged += new System.EventHandler(this.topupvalue_TextChanged);
            // 
            // ValuePlus
            // 
            this.ValuePlus.Location = new System.Drawing.Point(322, 106);
            this.ValuePlus.Name = "ValuePlus";
            this.ValuePlus.Size = new System.Drawing.Size(24, 20);
            this.ValuePlus.TabIndex = 4;
            this.ValuePlus.Text = "+";
            this.ValuePlus.UseVisualStyleBackColor = true;
            this.ValuePlus.Click += new System.EventHandler(this.ValuePlus_Click);
            // 
            // ValueMinus
            // 
            this.ValueMinus.Location = new System.Drawing.Point(159, 106);
            this.ValueMinus.Name = "ValueMinus";
            this.ValueMinus.Size = new System.Drawing.Size(24, 20);
            this.ValueMinus.TabIndex = 5;
            this.ValueMinus.Text = "-";
            this.ValueMinus.UseVisualStyleBackColor = true;
            this.ValueMinus.Click += new System.EventHandler(this.ValueMinus_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 129);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.topupamount);
            this.panel3.Controls.Add(this.topuppoint);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(311, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 148);
            this.panel3.TabIndex = 7;
            // 
            // topupamount
            // 
            this.topupamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topupamount.Enabled = false;
            this.topupamount.Location = new System.Drawing.Point(76, 51);
            this.topupamount.Name = "topupamount";
            this.topupamount.Size = new System.Drawing.Size(100, 13);
            this.topupamount.TabIndex = 4;
            this.topupamount.Text = "0";
            // 
            // topuppoint
            // 
            this.topuppoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topuppoint.Enabled = false;
            this.topuppoint.Location = new System.Drawing.Point(76, 12);
            this.topuppoint.Name = "topuppoint";
            this.topuppoint.Size = new System.Drawing.Size(100, 13);
            this.topuppoint.TabIndex = 3;
            this.topuppoint.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(101, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Top Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Points - ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 148);
            this.panel4.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::THZcineplex.Properties.Resources.G_Pay;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(-1, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 81);
            this.panel7.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::THZcineplex.Properties.Resources.mastercard;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(178, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 68);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::THZcineplex.Properties.Resources.Visa;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 68);
            this.panel5.TabIndex = 9;
            // 
            // formanimation
            // 
            this.formanimation.Interval = 1000;
            // 
            // TopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ValueMinus);
            this.Controls.Add(this.ValuePlus);
            this.Controls.Add(this.topupvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(878, 480);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TopUp";
            this.Load += new System.EventHandler(this.TopUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitTopup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox topupvalue;
        private System.Windows.Forms.Button ValuePlus;
        private System.Windows.Forms.Button ValueMinus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox topupamount;
        private System.Windows.Forms.TextBox topuppoint;
        private System.Windows.Forms.Timer formanimation;
    }
}