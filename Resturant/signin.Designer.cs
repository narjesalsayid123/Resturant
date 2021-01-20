
namespace Resturant
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comborole = new System.Windows.Forms.ComboBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.login_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comborole);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.user_textbox);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.login_panel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 664);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 46);
            this.label8.TabIndex = 14;
            this.label8.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "USER NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 60);
            this.label6.TabIndex = 12;
            this.label6.Text = "ROLE";
            // 
            // comborole
            // 
            this.comborole.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborole.FormattingEnabled = true;
            this.comborole.Items.AddRange(new object[] {
            "customer",
            "employee"});
            this.comborole.Location = new System.Drawing.Point(210, 194);
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(394, 56);
            this.comborole.TabIndex = 11;
            this.comborole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.Location = new System.Drawing.Point(210, 346);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(387, 55);
            this.password_textbox.TabIndex = 10;
            // 
            // user_textbox
            // 
            this.user_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_textbox.Location = new System.Drawing.Point(210, 267);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(394, 55);
            this.user_textbox.TabIndex = 9;
            this.user_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Maroon;
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(92, 444);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(482, 54);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(885, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Black;
            this.exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.exit_button.Location = new System.Drawing.Point(934, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(52, 46);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "x";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.White;
            this.login_panel.ForeColor = System.Drawing.Color.White;
            this.login_panel.Location = new System.Drawing.Point(60, 168);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(544, 10);
            this.login_panel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(520, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESTURANT";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAST FOOD";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Maroon;
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(110, 552);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(101, 58);
            this.clear_button.TabIndex = 15;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 664);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signin";
            this.Text = "signin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.ComboBox comborole;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_button;
    }
}