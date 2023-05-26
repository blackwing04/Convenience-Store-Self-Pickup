using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace system_analysis
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

		private void main_Load(object sender, EventArgs e)
        {
            bnt_main.FlatAppearance.MouseDownBackColor = Color.FromArgb(183, 201, 167);
            bnt_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 76, 92);
        }

        private void bnt_main_Click(object sender, EventArgs e)
        {
            int originalX = this.Location.X;
            int originalY = this.Location.Y;
            int originalWidth = this.Width;
            int originalHeight = this.Height;
            pu_package pu_Package = new pu_package();
            pu_Package.StartPosition = FormStartPosition.Manual;
            pu_Package.Location = new Point(originalX, originalY);
            pu_Package.Size = new Size(originalWidth, originalHeight);
            pu_Package.Show();
            this.Hide();
        }

        private void bnt_home_Click(object sender, EventArgs e)
        {

        }
    }
}
