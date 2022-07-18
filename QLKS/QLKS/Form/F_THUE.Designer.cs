namespace QLKS
{
    partial class F_THUE
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
            this.F_THUE_KH_V = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_loaiphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.F_THUE_P_V = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.btn_thue = new System.Windows.Forms.Button();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_maphong = new System.Windows.Forms.TextBox();
            this.tb_ngay = new System.Windows.Forms.TextBox();
            this.tb_mathue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.F_THUE_KH_V)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_THUE_P_V)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // F_THUE_KH_V
            // 
            this.F_THUE_KH_V.AllowUserToAddRows = false;
            this.F_THUE_KH_V.AllowUserToDeleteRows = false;
            this.F_THUE_KH_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_THUE_KH_V.Location = new System.Drawing.Point(18, 22);
            this.F_THUE_KH_V.Name = "F_THUE_KH_V";
            this.F_THUE_KH_V.RowTemplate.Height = 24;
            this.F_THUE_KH_V.Size = new System.Drawing.Size(687, 150);
            this.F_THUE_KH_V.TabIndex = 1;
            this.F_THUE_KH_V.SelectionChanged += new System.EventHandler(this.F_THUE_KH_V_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.tb_tenkh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.F_THUE_KH_V);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 178);
            this.panel1.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(761, 112);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(104, 29);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm Khách";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(727, 69);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(176, 22);
            this.tb_tenkh.TabIndex = 2;
            this.tb_tenkh.TextChanged += new System.EventHandler(this.tb_tenkh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "-- Nhập tên --";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_loaiphong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.F_THUE_P_V);
            this.panel2.Location = new System.Drawing.Point(12, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 178);
            this.panel2.TabIndex = 2;
            // 
            // tb_loaiphong
            // 
            this.tb_loaiphong.Location = new System.Drawing.Point(728, 94);
            this.tb_loaiphong.Name = "tb_loaiphong";
            this.tb_loaiphong.Size = new System.Drawing.Size(176, 22);
            this.tb_loaiphong.TabIndex = 2;
            this.tb_loaiphong.TextChanged += new System.EventHandler(this.tb_loaiphong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "-- Loại Phòng --";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin phòng";
            // 
            // F_THUE_P_V
            // 
            this.F_THUE_P_V.AllowUserToAddRows = false;
            this.F_THUE_P_V.AllowUserToDeleteRows = false;
            this.F_THUE_P_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_THUE_P_V.Location = new System.Drawing.Point(18, 22);
            this.F_THUE_P_V.Name = "F_THUE_P_V";
            this.F_THUE_P_V.RowTemplate.Height = 24;
            this.F_THUE_P_V.Size = new System.Drawing.Size(687, 150);
            this.F_THUE_P_V.TabIndex = 1;
            this.F_THUE_P_V.SelectionChanged += new System.EventHandler(this.F_THUE_P_V_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_thoat);
            this.panel3.Controls.Add(this.tb_makh);
            this.panel3.Controls.Add(this.btn_thue);
            this.panel3.Controls.Add(this.tb_gia);
            this.panel3.Controls.Add(this.tb_maphong);
            this.panel3.Controls.Add(this.tb_ngay);
            this.panel3.Controls.Add(this.tb_mathue);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(13, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 161);
            this.panel3.TabIndex = 3;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(499, 108);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 29);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // tb_makh
            // 
            this.tb_makh.Enabled = false;
            this.tb_makh.Location = new System.Drawing.Point(225, 53);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(120, 22);
            this.tb_makh.TabIndex = 1;
            // 
            // btn_thue
            // 
            this.btn_thue.AutoSize = true;
            this.btn_thue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thue.Location = new System.Drawing.Point(319, 108);
            this.btn_thue.Name = "btn_thue";
            this.btn_thue.Size = new System.Drawing.Size(104, 29);
            this.btn_thue.TabIndex = 3;
            this.btn_thue.Text = "Thuê Phòng";
            this.btn_thue.UseVisualStyleBackColor = true;
            this.btn_thue.Click += new System.EventHandler(this.btn_thue_Click);
            // 
            // tb_gia
            // 
            this.tb_gia.Enabled = false;
            this.tb_gia.Location = new System.Drawing.Point(461, 53);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(142, 22);
            this.tb_gia.TabIndex = 1;
            // 
            // tb_maphong
            // 
            this.tb_maphong.Enabled = false;
            this.tb_maphong.Location = new System.Drawing.Point(764, 36);
            this.tb_maphong.Name = "tb_maphong";
            this.tb_maphong.Size = new System.Drawing.Size(120, 22);
            this.tb_maphong.TabIndex = 1;
            // 
            // tb_ngay
            // 
            this.tb_ngay.Enabled = false;
            this.tb_ngay.Location = new System.Drawing.Point(461, 18);
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Size = new System.Drawing.Size(142, 22);
            this.tb_ngay.TabIndex = 1;
            // 
            // tb_mathue
            // 
            this.tb_mathue.Enabled = false;
            this.tb_mathue.Location = new System.Drawing.Point(225, 18);
            this.tb_mathue.Name = "tb_mathue";
            this.tb_mathue.Size = new System.Drawing.Size(120, 22);
            this.tb_mathue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã KH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá/Ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(664, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số phiếu thuê(Tự động)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_THUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F_THUE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.F_THUE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_THUE_KH_V)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.F_THUE_P_V)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView F_THUE_KH_V;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_loaiphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView F_THUE_P_V;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mathue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_ngay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_maphong;
        private System.Windows.Forms.Button btn_thue;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Timer timer1;
    }
}