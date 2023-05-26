
namespace system_analysis
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.bnt_main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_main
            // 
            this.bnt_main.BackColor = System.Drawing.Color.Transparent;
            this.bnt_main.BackgroundImage = global::system_analysis.Properties.Resources.button_main;
            this.bnt_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_main.FlatAppearance.BorderSize = 0;
            this.bnt_main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnt_main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnt_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_main.Location = new System.Drawing.Point(6, 112);
            this.bnt_main.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_main.Name = "bnt_main";
            this.bnt_main.Size = new System.Drawing.Size(149, 93);
            this.bnt_main.TabIndex = 0;
            this.bnt_main.UseVisualStyleBackColor = false;
            this.bnt_main.Click += new System.EventHandler(this.bnt_main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "歡迎使用ibon";
            // 
            // bnt_home
            // 
            this.bnt_home.BackColor = System.Drawing.Color.Transparent;
            this.bnt_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_home.BackgroundImage")));
            this.bnt_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_home.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bnt_home.FlatAppearance.BorderSize = 0;
            this.bnt_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnt_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_home.ForeColor = System.Drawing.Color.White;
            this.bnt_home.Location = new System.Drawing.Point(917, 9);
            this.bnt_home.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_home.Name = "bnt_home";
            this.bnt_home.Size = new System.Drawing.Size(79, 89);
            this.bnt_home.TabIndex = 3;
            this.bnt_home.UseVisualStyleBackColor = false;
            this.bnt_home.Click += new System.EventHandler(this.bnt_home_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::system_analysis.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.bnt_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "首頁";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_home;
    }
}