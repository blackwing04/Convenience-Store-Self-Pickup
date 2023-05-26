using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace system_analysis
{
    public class Module
    {
        private Label label;
        private Button button;
        private PictureBox pictureBox;
        public void LoadModule(Form form,string title)
        {
            // 創建標籤
            label = new Label();
            label.Text = title;  
            form.Controls.Add(label);
            label.AutoSize = true;
            label.Location = new Point(0, 23);
            //將文字背景透明化
            label.BackColor = Color.Transparent;
            label.Parent = pictureBox;
            //設定文字樣式
            label.ForeColor = Color.White;
            label.Font = new Font(label.Font.FontFamily, 16, label.Font.Style);
            //標籤置頂於程式上端Z軸
            label.BringToFront();

            // 創建按鈕
            button = new Button();
            //設定位置及背景
            button.Location = new Point(660, 0);
            button.Parent = pictureBox;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackgroundImage = Properties.Resources.button_home;
            //按鈕大小及設定按鈕MouseHover
            button.Size=new Size(70,65);
            //標籤置頂於程式上端Z軸
            button.BringToFront();
      
        }

    }

}
