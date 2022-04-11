
namespace week_9_praktikum
{
    partial class Form1
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
            this.cBox_home = new System.Windows.Forms.ComboBox();
            this.cBox_away = new System.Windows.Forms.ComboBox();
            this.lbl_vs = new System.Windows.Forms.Label();
            this.lbl_managerkiri = new System.Windows.Forms.Label();
            this.lbl_captainkiri = new System.Windows.Forms.Label();
            this.lbl_managerkanan = new System.Windows.Forms.Label();
            this.lbl_captainkanan = new System.Windows.Forms.Label();
            this.lbl_namamanager1 = new System.Windows.Forms.Label();
            this.lbl_namacaptain1 = new System.Windows.Forms.Label();
            this.lbl_namacaptain2 = new System.Windows.Forms.Label();
            this.lbl_namamanager2 = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.lbl_namastadium = new System.Windows.Forms.Label();
            this.lbl_namacapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBox_home
            // 
            this.cBox_home.FormattingEnabled = true;
            this.cBox_home.Location = new System.Drawing.Point(75, 32);
            this.cBox_home.Name = "cBox_home";
            this.cBox_home.Size = new System.Drawing.Size(228, 24);
            this.cBox_home.TabIndex = 0;
            this.cBox_home.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cBox_away
            // 
            this.cBox_away.FormattingEnabled = true;
            this.cBox_away.Location = new System.Drawing.Point(458, 32);
            this.cBox_away.Name = "cBox_away";
            this.cBox_away.Size = new System.Drawing.Size(203, 24);
            this.cBox_away.TabIndex = 1;
            this.cBox_away.SelectedIndexChanged += new System.EventHandler(this.cBox_away_SelectedIndexChanged);
            // 
            // lbl_vs
            // 
            this.lbl_vs.AutoSize = true;
            this.lbl_vs.Location = new System.Drawing.Point(372, 35);
            this.lbl_vs.Name = "lbl_vs";
            this.lbl_vs.Size = new System.Drawing.Size(26, 17);
            this.lbl_vs.TabIndex = 2;
            this.lbl_vs.Text = "VS";
            // 
            // lbl_managerkiri
            // 
            this.lbl_managerkiri.AutoSize = true;
            this.lbl_managerkiri.Location = new System.Drawing.Point(75, 90);
            this.lbl_managerkiri.Name = "lbl_managerkiri";
            this.lbl_managerkiri.Size = new System.Drawing.Size(76, 17);
            this.lbl_managerkiri.TabIndex = 3;
            this.lbl_managerkiri.Text = "Manager : ";
            this.lbl_managerkiri.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_captainkiri
            // 
            this.lbl_captainkiri.AutoSize = true;
            this.lbl_captainkiri.Location = new System.Drawing.Point(75, 142);
            this.lbl_captainkiri.Name = "lbl_captainkiri";
            this.lbl_captainkiri.Size = new System.Drawing.Size(72, 17);
            this.lbl_captainkiri.TabIndex = 4;
            this.lbl_captainkiri.Text = "Captain   :";
            // 
            // lbl_managerkanan
            // 
            this.lbl_managerkanan.AutoSize = true;
            this.lbl_managerkanan.Location = new System.Drawing.Point(455, 90);
            this.lbl_managerkanan.Name = "lbl_managerkanan";
            this.lbl_managerkanan.Size = new System.Drawing.Size(76, 17);
            this.lbl_managerkanan.TabIndex = 5;
            this.lbl_managerkanan.Text = "Manager : ";
            // 
            // lbl_captainkanan
            // 
            this.lbl_captainkanan.AutoSize = true;
            this.lbl_captainkanan.Location = new System.Drawing.Point(455, 142);
            this.lbl_captainkanan.Name = "lbl_captainkanan";
            this.lbl_captainkanan.Size = new System.Drawing.Size(72, 17);
            this.lbl_captainkanan.TabIndex = 6;
            this.lbl_captainkanan.Text = "Captain   :";
            // 
            // lbl_namamanager1
            // 
            this.lbl_namamanager1.AutoSize = true;
            this.lbl_namamanager1.Location = new System.Drawing.Point(158, 90);
            this.lbl_namamanager1.Name = "lbl_namamanager1";
            this.lbl_namamanager1.Size = new System.Drawing.Size(31, 17);
            this.lbl_namamanager1.TabIndex = 7;
            this.lbl_namamanager1.Text = "N/A";
            this.lbl_namamanager1.Click += new System.EventHandler(this.lbl_namamanager1_Click);
            // 
            // lbl_namacaptain1
            // 
            this.lbl_namacaptain1.AutoSize = true;
            this.lbl_namacaptain1.Location = new System.Drawing.Point(158, 142);
            this.lbl_namacaptain1.Name = "lbl_namacaptain1";
            this.lbl_namacaptain1.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacaptain1.TabIndex = 8;
            this.lbl_namacaptain1.Text = "N/A";
            // 
            // lbl_namacaptain2
            // 
            this.lbl_namacaptain2.AutoSize = true;
            this.lbl_namacaptain2.Location = new System.Drawing.Point(537, 142);
            this.lbl_namacaptain2.Name = "lbl_namacaptain2";
            this.lbl_namacaptain2.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacaptain2.TabIndex = 9;
            this.lbl_namacaptain2.Text = "N/A";
            // 
            // lbl_namamanager2
            // 
            this.lbl_namamanager2.AutoSize = true;
            this.lbl_namamanager2.Location = new System.Drawing.Point(537, 90);
            this.lbl_namamanager2.Name = "lbl_namamanager2";
            this.lbl_namamanager2.Size = new System.Drawing.Size(31, 17);
            this.lbl_namamanager2.TabIndex = 10;
            this.lbl_namamanager2.Text = "N/A";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(257, 253);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(71, 17);
            this.lbl_stadium.TabIndex = 11;
            this.lbl_stadium.Text = "Stadium  :";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(257, 299);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(70, 17);
            this.lbl_capacity.TabIndex = 12;
            this.lbl_capacity.Text = "Capacity :";
            // 
            // lbl_namastadium
            // 
            this.lbl_namastadium.AutoSize = true;
            this.lbl_namastadium.Location = new System.Drawing.Point(352, 253);
            this.lbl_namastadium.Name = "lbl_namastadium";
            this.lbl_namastadium.Size = new System.Drawing.Size(31, 17);
            this.lbl_namastadium.TabIndex = 13;
            this.lbl_namastadium.Text = "N/A";
            // 
            // lbl_namacapacity
            // 
            this.lbl_namacapacity.AutoSize = true;
            this.lbl_namacapacity.Location = new System.Drawing.Point(352, 299);
            this.lbl_namacapacity.Name = "lbl_namacapacity";
            this.lbl_namacapacity.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacapacity.TabIndex = 14;
            this.lbl_namacapacity.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_namacapacity);
            this.Controls.Add(this.lbl_namastadium);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_namamanager2);
            this.Controls.Add(this.lbl_namacaptain2);
            this.Controls.Add(this.lbl_namacaptain1);
            this.Controls.Add(this.lbl_namamanager1);
            this.Controls.Add(this.lbl_captainkanan);
            this.Controls.Add(this.lbl_managerkanan);
            this.Controls.Add(this.lbl_captainkiri);
            this.Controls.Add(this.lbl_managerkiri);
            this.Controls.Add(this.lbl_vs);
            this.Controls.Add(this.cBox_away);
            this.Controls.Add(this.cBox_home);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_home;
        private System.Windows.Forms.ComboBox cBox_away;
        private System.Windows.Forms.Label lbl_vs;
        private System.Windows.Forms.Label lbl_managerkiri;
        private System.Windows.Forms.Label lbl_captainkiri;
        private System.Windows.Forms.Label lbl_managerkanan;
        private System.Windows.Forms.Label lbl_captainkanan;
        private System.Windows.Forms.Label lbl_namamanager1;
        private System.Windows.Forms.Label lbl_namacaptain1;
        private System.Windows.Forms.Label lbl_namacaptain2;
        private System.Windows.Forms.Label lbl_namamanager2;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label lbl_namastadium;
        private System.Windows.Forms.Label lbl_namacapacity;
    }
}

