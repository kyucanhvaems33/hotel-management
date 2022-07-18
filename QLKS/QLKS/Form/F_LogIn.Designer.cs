
namespace QLKS
{
    partial class F_LogIn
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(253, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 438);
            this.panel1.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(353, 282);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(333, 28);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(353, 223);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(333, 28);
            this.txt_User.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSize = true;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(556, 368);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(78, 32);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 276);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(94, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật khẩu";
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(371, 368);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 32);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 223);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(140, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(263, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phần Mềm Quản Lý Khách Sạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(290, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa Công Nghệ Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trường Đại học Quản lý và Công nghệ Hải Phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Clock
            // 
            this.lb_Clock.AutoSize = true;
            this.lb_Clock.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Clock.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Clock.Location = new System.Drawing.Point(840, 9);
            this.lb_Clock.Name = "lb_Clock";
            this.lb_Clock.Size = new System.Drawing.Size(70, 27);
            this.lb_Clock.TabIndex = 1;
            this.lb_Clock.Text = "label4";
            
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_LogIn
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::QLKS.Properties.Resources.khach_s_n_elizabeth;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 694);
            this.Controls.Add(this.lb_Clock);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "F_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.F_LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_Clock;
        private System.Windows.Forms.Timer timer1;
    }
}

