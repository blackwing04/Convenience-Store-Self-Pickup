
namespace system_analysis
{
    partial class pu_pickup
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
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_home = new System.Windows.Forms.Button();
            this.bnt_return = new System.Windows.Forms.Button();
            this.bnt_next = new System.Windows.Forms.Button();
            this.lb_tip = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            // bnt_return
            // 
            this.bnt_return.BackColor = System.Drawing.Color.Transparent;
            this.bnt_return.BackgroundImage = global::system_analysis.Properties.Resources.button_return;
            this.bnt_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_return.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bnt_return.FlatAppearance.BorderSize = 0;
            this.bnt_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnt_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnt_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_return.ForeColor = System.Drawing.Color.White;
            this.bnt_return.Location = new System.Drawing.Point(-1, 654);
            this.bnt_return.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_return.Name = "bnt_return";
            this.bnt_return.Size = new System.Drawing.Size(161, 55);
            this.bnt_return.TabIndex = 3;
            this.bnt_return.UseVisualStyleBackColor = false;
            this.bnt_return.Click += new System.EventHandler(this.bnt_return_Click);
            // 
            // bnt_next
            // 
            this.bnt_next.BackColor = System.Drawing.Color.Transparent;
            this.bnt_next.BackgroundImage = global::system_analysis.Properties.Resources.button_next;
            this.bnt_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_next.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bnt_next.FlatAppearance.BorderSize = 0;
            this.bnt_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnt_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_next.ForeColor = System.Drawing.Color.White;
            this.bnt_next.Location = new System.Drawing.Point(846, 654);
            this.bnt_next.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_next.Name = "bnt_next";
            this.bnt_next.Size = new System.Drawing.Size(161, 55);
            this.bnt_next.TabIndex = 3;
            this.bnt_next.UseVisualStyleBackColor = false;
            this.bnt_next.Click += new System.EventHandler(this.bnt_next_Click);
            // 
            // lb_tip
            // 
            this.lb_tip.AutoSize = true;
            this.lb_tip.BackColor = System.Drawing.Color.Transparent;
            this.lb_tip.Font = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.lb_tip.Location = new System.Drawing.Point(287, 303);
            this.lb_tip.Name = "lb_tip";
            this.lb_tip.Size = new System.Drawing.Size(60, 24);
            this.lb_tip.TabIndex = 4;
            this.lb_tip.Text = "lb_tip";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(150, 358);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(696, 40);
            this.lb_error.TabIndex = 6;
            this.lb_error.Text = "OTP輸入錯誤已累積 0 次，累計 3 次將返回首頁";
            this.lb_error.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(353, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 33);
            this.textBox1.TabIndex = 5;
            // 
            // pu_pickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::system_analysis.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1008, 710);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_tip);
            this.Controls.Add(this.bnt_next);
            this.Controls.Add(this.bnt_return);
            this.Controls.Add(this.bnt_home);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pu_pickup";
            this.Text = "pu_pickup_nb";
            this.Shown += new System.EventHandler(this.pu_pickup_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_home;
        private System.Windows.Forms.Button bnt_return;
        private System.Windows.Forms.Button bnt_next;
        private System.Windows.Forms.Label lb_tip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_error;
    }
}