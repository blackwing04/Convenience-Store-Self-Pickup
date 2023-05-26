
namespace system_analysis
{
    partial class final
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
            this.la_final = new System.Windows.Forms.Label();
            this.bnt_home = new System.Windows.Forms.Button();
            this.lb_Remaining_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // la_final
            // 
            this.la_final.AutoSize = true;
            this.la_final.BackColor = System.Drawing.Color.Transparent;
            this.la_final.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.la_final.ForeColor = System.Drawing.Color.Black;
            this.la_final.Location = new System.Drawing.Point(410, 327);
            this.la_final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.la_final.Name = "la_final";
            this.la_final.Size = new System.Drawing.Size(134, 44);
            this.la_final.TabIndex = 6;
            this.la_final.Text = "la_final";
            // 
            // bnt_home
            // 
            this.bnt_home.BackColor = System.Drawing.Color.Transparent;
            this.bnt_home.BackgroundImage = global::system_analysis.Properties.Resources.button_home;
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
            // lb_Remaining_Time
            // 
            this.lb_Remaining_Time.AutoSize = true;
            this.lb_Remaining_Time.BackColor = System.Drawing.Color.Transparent;
            this.lb_Remaining_Time.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Remaining_Time.ForeColor = System.Drawing.Color.Red;
            this.lb_Remaining_Time.Location = new System.Drawing.Point(329, 405);
            this.lb_Remaining_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Remaining_Time.Name = "lb_Remaining_Time";
            this.lb_Remaining_Time.Size = new System.Drawing.Size(314, 44);
            this.lb_Remaining_Time.TabIndex = 7;
            this.lb_Remaining_Time.Text = "10 秒後將返回首頁";
            // 
            // final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::system_analysis.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1008, 710);
            this.Controls.Add(this.lb_Remaining_Time);
            this.Controls.Add(this.bnt_home);
            this.Controls.Add(this.la_final);
            this.Name = "final";
            this.Text = "final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label la_final;
        private System.Windows.Forms.Button bnt_home;
        private System.Windows.Forms.Label lb_Remaining_Time;
    }
}