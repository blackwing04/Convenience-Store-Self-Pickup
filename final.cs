using System;
using System.Drawing;
using System.Windows.Forms;

namespace system_analysis
{
    public partial class final : Form
    {
        
        private int remainingSeconds;
        private Timer myTimer = new Timer();
        public final(string is_paid)
        {
            //初始化剩餘秒數為 10
            remainingSeconds = 10;
            // 創建計時器並設置間隔爲 1 秒
           
            myTimer.Interval = 1000;  // 30 seconds
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();
            InitializeComponent();
            if (is_paid == "已付款")
            {
                la_final.Text = "已列印取貨單，請持取貨單至自助包裹櫃取包裹";
                la_final.Location = new Point(111, 321);

            }
            else
            {
                la_final.Text = "已列印繳費單，請持繳費單至櫃台結帳";
                la_final.Location = new Point(170, 323);
            }
        }
        
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            // 更新剩餘秒數的顯示
            lb_Remaining_Time.Text = remainingSeconds.ToString()+ " 秒後將返回首頁";
            // 剩餘秒數減少 1
            remainingSeconds--;
            // 當剩餘秒數小於等於 0 時，關閉當前窗口並停止計時器
            if (remainingSeconds <= 0)
            {
                // 遍歷 OpenForms 集合以尋找主頁
                foreach (Form form in Application.OpenForms)
                {
                    if (form is main)  // Replace 'main' with the actual class name of your home form
                    {
                        // 顯示主頁
                        form.Show();
                        break;
                    }
                }

                // 關閉目前頁面
                myTimer.Stop();
                this.Close();
            }
        }

        private void bnt_home_Click(object sender, EventArgs e)
        {
            // 遍歷 OpenForms 集合以尋找主頁
            foreach (Form form in Application.OpenForms)
            {
                if (form is main)  // 找到名為"main"的頁面(此專案主頁便是main)
                {
                    // 顯示主頁
                    form.Show();
                    break;
                }
            }
            // 關閉目前頁面
            myTimer.Stop();
            this.Close();
        }
    }
}
