
namespace Resturant
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ADD_EMPLOYEE_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.job_name_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BREAK_TIME_TEXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SALARY_TEXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WORK_HOUR_TEXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WORK_DAYS_TEXT = new System.Windows.Forms.TextBox();
            this.HOME_EMPLOYE_BUTTON = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MENU_BUTTON = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 46);
            this.panel1.TabIndex = 4;
            // 
            // ADD_EMPLOYEE_BUTTON
            // 
            this.ADD_EMPLOYEE_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ADD_EMPLOYEE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_EMPLOYEE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.ADD_EMPLOYEE_BUTTON.ImageKey = "(none)";
            this.ADD_EMPLOYEE_BUTTON.Location = new System.Drawing.Point(202, 430);
            this.ADD_EMPLOYEE_BUTTON.Name = "ADD_EMPLOYEE_BUTTON";
            this.ADD_EMPLOYEE_BUTTON.Size = new System.Drawing.Size(161, 54);
            this.ADD_EMPLOYEE_BUTTON.TabIndex = 0;
            this.ADD_EMPLOYEE_BUTTON.Text = "ADD\r\n";
            this.ADD_EMPLOYEE_BUTTON.UseVisualStyleBackColor = false;
            this.ADD_EMPLOYEE_BUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOB NAME:-";
            // 
            // job_name_text
            // 
            this.job_name_text.Location = new System.Drawing.Point(202, 30);
            this.job_name_text.Multiline = true;
            this.job_name_text.Name = "job_name_text";
            this.job_name_text.Size = new System.Drawing.Size(265, 38);
            this.job_name_text.TabIndex = 2;
            this.job_name_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "BREAK TIMES :-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BREAK_TIME_TEXT
            // 
            this.BREAK_TIME_TEXT.Location = new System.Drawing.Point(202, 90);
            this.BREAK_TIME_TEXT.Multiline = true;
            this.BREAK_TIME_TEXT.Name = "BREAK_TIME_TEXT";
            this.BREAK_TIME_TEXT.Size = new System.Drawing.Size(265, 37);
            this.BREAK_TIME_TEXT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "SALARY:-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SALARY_TEXT
            // 
            this.SALARY_TEXT.Location = new System.Drawing.Point(202, 150);
            this.SALARY_TEXT.Multiline = true;
            this.SALARY_TEXT.Name = "SALARY_TEXT";
            this.SALARY_TEXT.Size = new System.Drawing.Size(265, 39);
            this.SALARY_TEXT.TabIndex = 6;
            this.SALARY_TEXT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-6, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "WORK_HOURS:-";
            // 
            // WORK_HOUR_TEXT
            // 
            this.WORK_HOUR_TEXT.Location = new System.Drawing.Point(202, 218);
            this.WORK_HOUR_TEXT.Multiline = true;
            this.WORK_HOUR_TEXT.Name = "WORK_HOUR_TEXT";
            this.WORK_HOUR_TEXT.Size = new System.Drawing.Size(265, 39);
            this.WORK_HOUR_TEXT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "WORKDAYS:-";
            // 
            // WORK_DAYS_TEXT
            // 
            this.WORK_DAYS_TEXT.Location = new System.Drawing.Point(202, 279);
            this.WORK_DAYS_TEXT.Multiline = true;
            this.WORK_DAYS_TEXT.Name = "WORK_DAYS_TEXT";
            this.WORK_DAYS_TEXT.Size = new System.Drawing.Size(265, 39);
            this.WORK_DAYS_TEXT.TabIndex = 10;
            // 
            // HOME_EMPLOYE_BUTTON
            // 
            this.HOME_EMPLOYE_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HOME_EMPLOYE_BUTTON.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME_EMPLOYE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.HOME_EMPLOYE_BUTTON.ImageKey = "(none)";
            this.HOME_EMPLOYE_BUTTON.Location = new System.Drawing.Point(3, 430);
            this.HOME_EMPLOYE_BUTTON.Name = "HOME_EMPLOYE_BUTTON";
            this.HOME_EMPLOYE_BUTTON.Size = new System.Drawing.Size(161, 54);
            this.HOME_EMPLOYE_BUTTON.TabIndex = 11;
            this.HOME_EMPLOYE_BUTTON.Text = "HOME";
            this.HOME_EMPLOYE_BUTTON.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.order_button);
            this.panel2.Controls.Add(this.customer_button);
            this.panel2.Controls.Add(this.MENU_BUTTON);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.HOME_EMPLOYE_BUTTON);
            this.panel2.Controls.Add(this.WORK_DAYS_TEXT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.WORK_HOUR_TEXT);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SALARY_TEXT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BREAK_TIME_TEXT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.job_name_text);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ADD_EMPLOYEE_BUTTON);
            this.panel2.Location = new System.Drawing.Point(25, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 674);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(532, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(639, 445);
            this.dataGridView3.TabIndex = 12;
            // 
            // MENU_BUTTON
            // 
            this.MENU_BUTTON.Location = new System.Drawing.Point(1049, 530);
            this.MENU_BUTTON.Name = "MENU_BUTTON";
            this.MENU_BUTTON.Size = new System.Drawing.Size(122, 82);
            this.MENU_BUTTON.TabIndex = 13;
            this.MENU_BUTTON.Text = "menu";
            this.MENU_BUTTON.UseVisualStyleBackColor = true;
            // 
            // customer_button
            // 
            this.customer_button.Location = new System.Drawing.Point(883, 530);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(122, 82);
            this.customer_button.TabIndex = 14;
            this.customer_button.Text = "customer";
            this.customer_button.UseVisualStyleBackColor = true;
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(706, 530);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(122, 82);
            this.order_button.TabIndex = 15;
            this.order_button.Text = "order";
            this.order_button.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(309, 36);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ADD_EMPLOYEE_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox job_name_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BREAK_TIME_TEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SALARY_TEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WORK_HOUR_TEXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WORK_DAYS_TEXT;
        private System.Windows.Forms.Button HOME_EMPLOYE_BUTTON;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button MENU_BUTTON;
    }
}