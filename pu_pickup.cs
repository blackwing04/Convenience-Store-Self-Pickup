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
    public partial class pu_pickup : Form
    {
        public pu_package PreviousForm { get; set; }
        public pu_customer customer_previousFor { get; set; }
        public string pp_type;
        public int otp_error_count=0;
        
        public pu_pickup(pu_package previousFor, string type)
        {
            InitializeComponent();
            this.PreviousForm = previousFor;
            this.customer_previousFor = customer_previousFor;
            //判斷使用者是選擇輸入哪種資料
            if (type == "pickup")
            {
                lb_tip.Text = "請輸入訂購碼";
                lb_tip.Location = new Point(230, 303);
                label1.Text = "超商自助取貨/輸入訂購碼";
            }
            else if (type == "phone")
            {
                lb_tip.Text = "請輸入收件人行動電話";
                lb_tip.Location = new Point(150, 303);
                textBox1.MaxLength = 10;
                textBox1.Text = "09";
                label1.Text = "超商自助取貨/輸入收件人電話";
            }
            else {
                lb_tip.Text = "請輸入簡訊OTP碼";
                lb_tip.Location = new Point(190, 303);
                textBox1.MaxLength = 6;
                label1.Text = "超商自助取貨/OTP驗證";
                bnt_return.Visible = false;
            }
            pp_type = type;
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
            string otp = "0";
            bool hasDataReturned = false;
            //連接資料庫
            DataTable dt = new DataTable();
            string connectionString = "Data Source=data.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) 
            {
                connection.Open();
                string query ="SELECT  [arrival_date],[expiration_date],[recipient_name],[recipient_phone],[order_code],[is_paid],[is_collected]"
                             + "  FROM ParcelPickupRecords";
                //判斷資料庫要比對的欄位
                if (pp_type == "pickup")
                {
                    query += "  where [order_code]=@order_code and [is_collected]='N'";
                }
                else if (pp_type == "phone")
                {
                    query += "  where [recipient_phone]=@recipient_phone and [is_collected]='N'";
                }
                else
                {
                    //正常是帶入otp碼，但測試版為6個9
                    otp = "999999";
                }
               
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@order_code", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@recipient_phone", textBox1.Text.ToString());
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
                if (pp_type == "otp") dt.Clear();//如果是otp清除dt
                //判斷是否有資料或者OTP是正確的(測試版OTP為6個9)
                if (dt.Rows.Count > 0 || textBox1.Text.ToString() == otp.ToString()) hasDataReturned = true;
            }
            //如果有資料則進到下一步，資料錯誤查無資料則跳出提示視窗，同時如果是OTP錯誤累積三次退回到選擇資料輸入方式頁面
            if (hasDataReturned)
            {
                if (pp_type == "otp")
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
                //行動電話驗證的且已付款的需驗證OTP
                else if(pp_type == "phone")
                {
                    int originalX = this.Location.X;
                    int originalY = this.Location.Y;
                    int originalWidth = this.Width;
                    int originalHeight = this.Height;
                    pu_customer pu_Customer = new pu_customer(this, dt.Rows[0]["recipient_name"].ToString(), dt.Rows[0]["recipient_phone"].ToString(), dt.Rows[0]["is_paid"].ToString(),true);
                    pu_Customer.StartPosition = FormStartPosition.Manual;
                    pu_Customer.Location = new Point(originalX, originalY);
                    pu_Customer.Size = new Size(originalWidth, originalHeight);
                    pu_Customer.Show();
                    this.Hide();
                }
                else
                {
                    int originalX = this.Location.X;
                    int originalY = this.Location.Y;
                    int originalWidth = this.Width;
                    int originalHeight = this.Height;
                    pu_customer pu_Customer = new pu_customer(this, dt.Rows[0]["recipient_name"].ToString(), dt.Rows[0]["recipient_phone"].ToString(), dt.Rows[0]["is_paid"].ToString(),false);
                    pu_Customer.StartPosition = FormStartPosition.Manual;
                    pu_Customer.Location = new Point(originalX, originalY);
                    pu_Customer.Size = new Size(originalWidth, originalHeight);
                    pu_Customer.Show();
                    this.Hide();
                }
            }
            else
            {              
                textBox1.Clear();
                if (pp_type == "phone") textBox1.Text = "09";
                textBox1.Focus();
                if (pp_type == "otp") 
                {
                    //判斷OTP錯誤累積次數，因為抓的是頁面的文字轉數字所以少記1次，因此判定小於2第三次則返回主頁
                    if (int.Parse(lb_error.Text.Substring(11, 1)) < 2) 
                    {
                        lb_error.Visible = true;
                        otp_error_count = int.Parse(lb_error.Text.Substring(11, 1));
                        lb_error.Text = "OTP輸入錯誤已累積 " + (otp_error_count + 1).ToString() + " 次，累計 3 次將返回首頁";
                        MessageBox.Show("OTP輸入錯誤，請重新輸入");         
                    }
                    else
                    {
                        MessageBox.Show("輸入錯誤達3次，請回首頁重新操作");
                        pu_package pu_Package = new pu_package();
                        int originalX = this.Location.X;
                        int originalY = this.Location.Y;
                        int originalWidth = this.Width;
                        int originalHeight = this.Height;
                        pu_Package.StartPosition = FormStartPosition.Manual;
                        pu_Package.Location = new Point(originalX, originalY);
                        pu_Package.Size = new Size(originalWidth, originalHeight);
                        pu_Package.Show();
                        this.Hide();
                    }
                }
                else 
                {
                    MessageBox.Show("查無資料，請確認輸入的資料是否正確");
                }
            }
        }

        private void bnt_return_Click(object sender, EventArgs e)
        {
            //返回前一頁面
            this.PreviousForm.Show();
            this.Close();
        }

        private void pu_pickup_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
