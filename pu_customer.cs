using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_analysis
{
    public partial class pu_customer : Form
    {
        public pu_pickup PreviousForm { get; set; }
        public Boolean otp;
        public pu_customer(pu_pickup previousFor,string recipient_name, string recipient_phone, string is_paid, Boolean OTP)
        {
            InitializeComponent();
            this.PreviousForm = previousFor;
            lb_data_name.Text = recipient_name;
            lb_data_phone.Text = recipient_phone;
            if (is_paid == "Y")
            {
                lb_data_pay.Text = "已付款";
            }
            else
            {
                lb_data_pay.Text = "未付款";
                lb_data_pay.ForeColor = Color.Red;
            }
            otp = OTP;
        }

        private void bnt_home_Click(object sender, EventArgs e)
        {
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

        private void bnt_next_Click(object sender, EventArgs e)
        {
            //這邊判斷如果是未付款一率到結果，列印繳費單至櫃台結帳
            if (lb_data_pay.Text == "未付款")
            {
                final Final = new final("未付款");
                int originalX = this.Location.X;
                int originalY = this.Location.Y;
                int originalWidth = this.Width;
                int originalHeight = this.Height;
                Final.StartPosition = FormStartPosition.Manual;
                Final.Location = new Point(originalX, originalY);
                Final.Size = new Size(originalWidth, originalHeight);
                Final.Show();
                this.Hide();
            }
            else
            {
                //這邊判斷如果是已付款並且是電話驗證的(otp為true)，需要做OTP驗證
                if (otp)
                {
                    MessageBox.Show("即將發送OTP手機驗證碼到您的手機。請注意查收並在下一頁輸入。");
                    int originalX = this.Location.X;
                    int originalY = this.Location.Y;
                    int originalWidth = this.Width;
                    int originalHeight = this.Height;
                    pu_package pu_Package = new pu_package();//為了符合呼叫pu_pickup的參數才建置
                    pu_pickup pu_Pickup_nb = new pu_pickup(pu_Package, "otp");
                    pu_Pickup_nb.StartPosition = FormStartPosition.Manual;
                    pu_Pickup_nb.Location = new Point(originalX, originalY);
                    pu_Pickup_nb.Size = new Size(originalWidth, originalHeight);
                    pu_Pickup_nb.Show();
                    this.Hide();
                   
                }
                //這邊是剩下用訂購碼認證的且已付款，因為是用訂購碼所以不用做OTP了。
                else
                {
                    final Final = new final("已付款");
                    int originalX = this.Location.X;
                    int originalY = this.Location.Y;
                    int originalWidth = this.Width;
                    int originalHeight = this.Height;
                    Final.StartPosition = FormStartPosition.Manual;
                    Final.Location = new Point(originalX, originalY);
                    Final.Size = new Size(originalWidth, originalHeight);
                    Final.Show();
                    this.Hide();
                }
            }
           
        }

        private void bnt_return_Click(object sender, EventArgs e)
        {
            //返回前一頁面
            this.PreviousForm.Show();
            this.Close();
        }
    }
}
