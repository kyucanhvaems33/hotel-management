namespace QLKS
{
    partial class F_SDDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdbtn_mathue = new System.Windows.Forms.RadioButton();
            this.rdbtn_maphong = new System.Windows.Forms.RadioButton();
            this.F_SDDV_THUE_V = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_taophieu = new System.Windows.Forms.Button();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.tb_mathue = new System.Windows.Forms.TextBox();
            this.tb_gio = new System.Windows.Forms.TextBox();
            this.tb_sophieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_SDDV_THUE_V)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách phiếu thuê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.F_SDDV_THUE_V);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 235);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_timkiem);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(727, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 211);
            this.panel2.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(29, 146);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(233, 27);
            this.tb_timkiem.TabIndex = 2;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdbtn_mathue);
            this.panel6.Controls.Add(this.rdbtn_maphong);
            this.panel6.Location = new System.Drawing.Point(3, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 100);
            this.panel6.TabIndex = 1;
            // 
            // rdbtn_mathue
            // 
            this.rdbtn_mathue.AutoSize = true;
            this.rdbtn_mathue.Checked = true;
            this.rdbtn_mathue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_mathue.Location = new System.Drawing.Point(67, 14);
            this.rdbtn_mathue.Name = "rdbtn_mathue";
            this.rdbtn_mathue.Size = new System.Drawing.Size(137, 26);
            this.rdbtn_mathue.TabIndex = 0;
            this.rdbtn_mathue.TabStop = true;
            this.rdbtn_mathue.Text = "Số phiếu thuê";
            this.rdbtn_mathue.UseVisualStyleBackColor = true;
            // 
            // rdbtn_maphong
            // 
            this.rdbtn_maphong.AutoSize = true;
            this.rdbtn_maphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_maphong.Location = new System.Drawing.Point(79, 55);
            this.rdbtn_maphong.Name = "rdbtn_maphong";
            this.rdbtn_maphong.Size = new System.Drawing.Size(109, 26);
            this.rdbtn_maphong.TabIndex = 0;
            this.rdbtn_maphong.Text = "Mã phòng";
            this.rdbtn_maphong.UseVisualStyleBackColor = true;
            // 
            // F_SDDV_THUE_V
            // 
            this.F_SDDV_THUE_V.AllowUserToAddRows = false;
            this.F_SDDV_THUE_V.AllowUserToDeleteRows = false;
            this.F_SDDV_THUE_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_SDDV_THUE_V.Location = new System.Drawing.Point(14, 21);
            this.F_SDDV_THUE_V.Name = "F_SDDV_THUE_V";
            this.F_SDDV_THUE_V.RowTemplate.Height = 24;
            this.F_SDDV_THUE_V.Size = new System.Drawing.Size(693, 211);
            this.F_SDDV_THUE_V.TabIndex = 1;
            this.F_SDDV_THUE_V.SelectionChanged += new System.EventHandler(this.F_SDDV_THUE_V_SelectionChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(822, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_taophieu);
            this.panel3.Controls.Add(this.tb_makh);
            this.panel3.Controls.Add(this.tb_mathue);
            this.panel3.Controls.Add(this.tb_gio);
            this.panel3.Controls.Add(this.tb_sophieu);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 145);
            this.panel3.TabIndex = 7;
            // 
            // btn_taophieu
            // 
            this.btn_taophieu.AutoSize = true;
            this.btn_taophieu.Enabled = false;
            this.btn_taophieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taophieu.Location = new System.Drawing.Point(869, 52);
            this.btn_taophieu.Name = "btn_taophieu";
            this.btn_taophieu.Size = new System.Drawing.Size(99, 32);
            this.btn_taophieu.TabIndex = 10;
            this.btn_taophieu.Text = "Tạo phiếu";
            this.btn_taophieu.UseVisualStyleBackColor = true;
            this.btn_taophieu.Click += new System.EventHandler(this.btn_taophieu_Click);
            // 
            // tb_makh
            // 
            this.tb_makh.Enabled = false;
            this.tb_makh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makh.Location = new System.Drawing.Point(661, 82);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(146, 27);
            this.tb_makh.TabIndex = 6;
            // 
            // tb_mathue
            // 
            this.tb_mathue.Enabled = false;
            this.tb_mathue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mathue.Location = new System.Drawing.Point(296, 83);
            this.tb_mathue.Name = "tb_mathue";
            this.tb_mathue.Size = new System.Drawing.Size(146, 27);
            this.tb_mathue.TabIndex = 7;
            // 
            // tb_gio
            // 
            this.tb_gio.Enabled = false;
            this.tb_gio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gio.Location = new System.Drawing.Point(661, 35);
            this.tb_gio.Name = "tb_gio";
            this.tb_gio.Size = new System.Drawing.Size(146, 27);
            this.tb_gio.TabIndex = 8;
            // 
            // tb_sophieu
            // 
            this.tb_sophieu.Enabled = false;
            this.tb_sophieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(296, 36);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.Size = new System.Drawing.Size(146, 27);
            this.tb_sophieu.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số phiếu thuê";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giờ cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số phiếu dịch vụ(Tự động)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_SDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "F_SDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.F_SDDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_SDDV_THUE_V)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbtn_mathue;
        private System.Windows.Forms.RadioButton rdbtn_maphong;
        private System.Windows.Forms.DataGridView F_SDDV_THUE_V;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.TextBox tb_mathue;
        private System.Windows.Forms.TextBox tb_gio;
        private System.Windows.Forms.TextBox tb_sophieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_taophieu;
        private System.Windows.Forms.Timer timer1;
    }
}