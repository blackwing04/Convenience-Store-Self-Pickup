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

        }

        private void bnt_home_Click(object sender, EventArgs e)
        {

        }
    }
}
