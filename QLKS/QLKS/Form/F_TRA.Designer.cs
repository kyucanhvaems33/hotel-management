namespace QLKS
{
    partial class F_TRA
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdbtn_mathue = new System.Windows.Forms.RadioButton();
            this.rdbtn_maphong = new System.Windows.Forms.RadioButton();
            this.F_TRA_THUE_V = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.F_TRA_P_V = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.lb_ngayo = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tra = new System.Windows.Forms.Button();
            this.tb_maphong = new System.Windows.Forms.TextBox();
            this.tb_ngaytra = new System.Windows.Forms.TextBox();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.tb_ngaythue = new System.Windows.Forms.TextBox();
            this.tb_mathue = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.tb_matra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_TRA_THUE_V)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_TRA_P_V)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.F_TRA_THUE_V);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 235);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_timkiem);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(1020, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 211);
            this.panel2.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(19, 144);
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
            this.panel6.Size = new System.Drawing.Size(265, 100);
            this.panel6.TabIndex = 1;
            // 
            // rdbtn_mathue
            // 
            this.rdbtn_mathue.AutoSize = true;
            this.rdbtn_mathue.Checked = true;
            this.rdbtn_mathue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_mathue.Location = new System.Drawing.Point(61, 17);
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
            this.rdbtn_maphong.Location = new System.Drawing.Point(72, 56);
            this.rdbtn_maphong.Name = "rdbtn_maphong";
            this.rdbtn_maphong.Size = new System.Drawing.Size(109, 26);
            this.rdbtn_maphong.TabIndex = 0;
            this.rdbtn_maphong.Text = "Mã phòng";
            this.rdbtn_maphong.UseVisualStyleBackColor = true;
            // 
            // F_TRA_THUE_V
            // 
            this.F_TRA_THUE_V.AllowUserToAddRows = false;
            this.F_TRA_THUE_V.AllowUserToDeleteRows = false;
            this.F_TRA_THUE_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_TRA_THUE_V.Location = new System.Drawing.Point(14, 21);
            this.F_TRA_THUE_V.Name = "F_TRA_THUE_V";
            this.F_TRA_THUE_V.RowTemplate.Height = 24;
            this.F_TRA_THUE_V.Size = new System.Drawing.Size(1000, 211);
            this.F_TRA_THUE_V.TabIndex = 1;
            this.F_TRA_THUE_V.SelectionChanged += new System.EventHandler(this.F_TRA_THUE_V_SelectionChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1124, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.F_TRA_P_V);
            this.panel3.Location = new System.Drawing.Point(13, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 240);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá phòng";
            // 
            // F_TRA_P_V
            // 
            this.F_TRA_P_V.AllowUserToAddRows = false;
            this.F_TRA_P_V.AllowUserToDeleteRows = false;
            this.F_TRA_P_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.F_TRA_P_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_TRA_P_V.Enabled = false;
            this.F_TRA_P_V.Location = new System.Drawing.Point(14, 25);
            this.F_TRA_P_V.Name = "F_TRA_P_V";
            this.F_TRA_P_V.RowTemplate.Height = 24;
            this.F_TRA_P_V.Size = new System.Drawing.Size(296, 212);
            this.F_TRA_P_V.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_tongtien);
            this.panel4.Controls.Add(this.lb_ngayo);
            this.panel4.Controls.Add(this.btn_thoat);
            this.panel4.Controls.Add(this.btn_tra);
            this.panel4.Controls.Add(this.tb_maphong);
            this.panel4.Controls.Add(this.tb_ngaytra);
            this.panel4.Controls.Add(this.tb_makh);
            this.panel4.Controls.Add(this.tb_ngaythue);
            this.panel4.Controls.Add(this.tb_mathue);
            this.panel4.Controls.Add(this.tb_dongia);
            this.panel4.Controls.Add(this.tb_matra);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(332, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(994, 233);
            this.panel4.TabIndex = 2;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_tongtien.Location = new System.Drawing.Point(824, 100);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(2, 21);
            this.lb_tongtien.TabIndex = 6;
            // 
            // lb_ngayo
            // 
            this.lb_ngayo.AutoSize = true;
            this.lb_ngayo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_ngayo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayo.ForeColor = System.Drawing.Color.Red;
            this.lb_ngayo.Location = new System.Drawing.Point(544, 173);
            this.lb_ngayo.Name = "lb_ngayo";
            this.lb_ngayo.Size = new System.Drawing.Size(2, 21);
            this.lb_ngayo.TabIndex = 6;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(876, 170);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 32);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tra
            // 
            this.btn_tra.AutoSize = true;
            this.btn_tra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tra.Location = new System.Drawing.Point(737, 171);
            this.btn_tra.Name = "btn_tra";
            this.btn_tra.Size = new System.Drawing.Size(99, 32);
            this.btn_tra.TabIndex = 5;
            this.btn_tra.Text = "Trả phòng";
            this.btn_tra.UseVisualStyleBackColor = true;
            this.btn_tra.Click += new System.EventHandler(this.btn_tra_Click);
            // 
            // tb_maphong
            // 
            this.tb_maphong.Enabled = false;
            this.tb_maphong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maphong.Location = new System.Drawing.Point(222, 170);
            this.tb_maphong.Name = "tb_maphong";
            this.tb_maphong.Size = new System.Drawing.Size(146, 27);
            this.tb_maphong.TabIndex = 1;
            // 
            // tb_ngaytra
            // 
            this.tb_ngaytra.Enabled = false;
            this.tb_ngaytra.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaytra.Location = new System.Drawing.Point(548, 118);
            this.tb_ngaytra.Name = "tb_ngaytra";
            this.tb_ngaytra.Size = new System.Drawing.Size(146, 27);
            this.tb_ngaytra.TabIndex = 1;
            // 
            // tb_makh
            // 
            this.tb_makh.Enabled = false;
            this.tb_makh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_makh.Location = new System.Drawing.Point(222, 117);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(146, 27);
            this.tb_makh.TabIndex = 1;
            // 
            // tb_ngaythue
            // 
            this.tb_ngaythue.Enabled = false;
            this.tb_ngaythue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaythue.Location = new System.Drawing.Point(548, 68);
            this.tb_ngaythue.Name = "tb_ngaythue";
            this.tb_ngaythue.Size = new System.Drawing.Size(146, 27);
            this.tb_ngaythue.TabIndex = 1;
            // 
            // tb_mathue
            // 
            this.tb_mathue.Enabled = false;
            this.tb_mathue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mathue.Location = new System.Drawing.Point(222, 67);
            this.tb_mathue.Name = "tb_mathue";
            this.tb_mathue.Size = new System.Drawing.Size(146, 27);
            this.tb_mathue.TabIndex = 1;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Enabled = false;
            this.tb_dongia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dongia.Location = new System.Drawing.Point(548, 21);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(146, 27);
            this.tb_dongia.TabIndex = 1;
            // 
            // tb_matra
            // 
            this.tb_matra.Enabled = false;
            this.tb_matra.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matra.Location = new System.Drawing.Point(222, 20);
            this.tb_matra.Name = "tb_matra";
            this.tb_matra.Size = new System.Drawing.Size(146, 27);
            this.tb_matra.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(417, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số ngày ở";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phòng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(717, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số phiếu thuê";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số hoá đơn(Tự động)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách phiếu thuê";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_TRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "F_TRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng";
            this.Load += new System.EventHandler(this.F_TRA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_TRA_THUE_V)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_TRA_P_V)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView F_TRA_THUE_V;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView F_TRA_P_V;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_matra;
        private System.Windows.Forms.TextBox tb_maphong;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.TextBox tb_mathue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ngaytra;
        private System.Windows.Forms.TextBox tb_ngaythue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbtn_mathue;
        private System.Windows.Forms.RadioButton rdbtn_maphong;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tra;
        private System.Windows.Forms.Label lb_ngayo;
        private System.Windows.Forms.Label lb_tongtien;
    }
}