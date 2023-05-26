using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace system_analysis
{
    public partial class pu_package : Form
    {
        public  main PreviousForm { get; set; }
        public pu_package()
        {
            InitializeComponent();
        }

        private void bnt_pickup_nb_Click(object sender, EventArgs e)
        {
            //訂購碼同時新視窗開啟不會改變位置根高度，後面開啟新視窗皆會有一樣的程式碼
            int originalX = this.Location.X;
            int originalY = this.Location.Y;
            int originalWidth = this.Width;
            int originalHeight = this.Height;     
            pu_pickup pu_Pickup_nb = new pu_pickup(this, "pickup");
            pu_Pickup_nb.StartPosition = FormStartPosition.Manual;
            pu_Pickup_nb.Location = new Point(originalX, originalY);
            pu_Pickup_nb.Size = new Size(originalWidth, originalHeight);
            pu_Pickup_nb.Show();
            this.Hide();
        }

        private void bnt_phone_nb_Click(object sender, EventArgs e)
        {
            int originalX = this.Location.X;
            int originalY = this.Location.Y;
            int originalWidth = this.Width;
            int originalHeight = this.Height;
            pu_pickup pu_Pickup_nb = new pu_pickup(this, "phone");
            pu_Pickup_nb.StartPosition = FormStartPosition.Manual;
            pu_Pickup_nb.Location = new Point(originalX, originalY);
            pu_Pickup_nb.Size = new Size(originalWidth, originalHeight);
            pu_Pickup_nb.Show();
            this.Hide();
        }

        private void bnt_home_Click(object sender, EventArgs e)
        {
            // 遍歷 OpenForms 集合尋找主頁面
            foreach (Form form in Application.OpenForms)
            {
                if (form is main)
                {
                    // 顯示主頁面
                    form.Show();
                    break;
                }
            }
            // 關閉當前頁面
            this.Close();
        }

        private void bnt_return_Click(object sender, EventArgs e)
        {
            // 遍歷 OpenForms 集合尋找主頁面
            foreach (Form form in Application.OpenForms)
            {
                if (form is main)
                {
                    // 顯示主頁面
                    form.Show();
                    break;
                }
            }
            // 關閉當前頁面
            this.Close();
        }
    }
}
