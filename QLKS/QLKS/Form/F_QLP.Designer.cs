namespace QLKS
{
    partial class F_QLP
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
            this.F_QLP_V = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.F_QLP_Thoat = new System.Windows.Forms.Button();
            this.F_QLP_Xoa = new System.Windows.Forms.Button();
            this.F_QLP_Sua = new System.Windows.Forms.Button();
            this.F_QLP_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.F_QLP_V)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // F_QLP_V
            // 
            this.F_QLP_V.AllowUserToAddRows = false;
            this.F_QLP_V.AllowUserToDeleteRows = false;
            this.F_QLP_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_QLP_V.Location = new System.Drawing.Point(13, 423);
            this.F_QLP_V.Name = "F_QLP_V";
            this.F_QLP_V.ReadOnly = true;
            this.F_QLP_V.RowTemplate.Height = 24;
            this.F_QLP_V.Size = new System.Drawing.Size(1069, 303);
            this.F_QLP_V.TabIndex = 5;
            this.F_QLP_V.SelectionChanged += new System.EventHandler(this.F_QLP_V_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.F_QLP_Thoat);
            this.panel1.Controls.Add(this.F_QLP_Xoa);
            this.panel1.Controls.Add(this.F_QLP_Sua);
            this.panel1.Controls.Add(this.F_QLP_Them);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 301);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(70, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 93);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phòng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_manv);
            this.panel3.Controls.Add(this.cb_tinhtrang);
            this.panel3.Controls.Add(this.tb_gia);
            this.panel3.Location = new System.Drawing.Point(727, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 130);
            this.panel3.TabIndex = 2;
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tinhtrang.Enabled = false;
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "RẢNH",
            "BẬN"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(19, 52);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(266, 30);
            this.cb_tinhtrang.TabIndex = 1;
            // 
            // tb_gia
            // 
            this.tb_gia.Enabled = false;
            this.tb_gia.Location = new System.Drawing.Point(19, 14);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(266, 30);
            this.tb_gia.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_loai);
            this.panel2.Controls.Add(this.tb_ma);
            this.panel2.Location = new System.Drawing.Point(229, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 93);
            this.panel2.TabIndex = 2;
            // 
            // cb_loai
            // 
            this.cb_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loai.Enabled = false;
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.Items.AddRange(new object[] {
            "THƯỜNG ĐƠN",
            "THƯỜNG ĐÔI",
            "VIP ĐƠN",
            "VIP ĐÔI"});
            this.cb_loai.Location = new System.Drawing.Point(19, 52);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(266, 30);
            this.cb_loai.TabIndex = 1;
            // 
            // tb_ma
            // 
            this.tb_ma.Enabled = false;
            this.tb_ma.Location = new System.Drawing.Point(19, 14);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(266, 30);
            this.tb_ma.TabIndex = 0;
            // 
            // F_QLP_Thoat
            // 
            this.F_QLP_Thoat.AutoSize = true;
            this.F_QLP_Thoat.Location = new System.Drawing.Point(883, 238);
            this.F_QLP_Thoat.Name = "F_QLP_Thoat";
            this.F_QLP_Thoat.Size = new System.Drawing.Size(118, 32);
            this.F_QLP_Thoat.TabIndex = 1;
            this.F_QLP_Thoat.Text = "Thoát";
            this.F_QLP_Thoat.UseVisualStyleBackColor = true;
            this.F_QLP_Thoat.Click += new System.EventHandler(this.F_QLP_Thoat_Click);
            // 
            // F_QLP_Xoa
            // 
            this.F_QLP_Xoa.AutoSize = true;
            this.F_QLP_Xoa.Location = new System.Drawing.Point(630, 238);
            this.F_QLP_Xoa.Name = "F_QLP_Xoa";
            this.F_QLP_Xoa.Size = new System.Drawing.Size(118, 32);
            this.F_QLP_Xoa.TabIndex = 1;
            this.F_QLP_Xoa.Text = "Xoá";
            this.F_QLP_Xoa.UseVisualStyleBackColor = true;
            this.F_QLP_Xoa.Click += new System.EventHandler(this.F_QLP_Xoa_Click);
            // 
            // F_QLP_Sua
            // 
            this.F_QLP_Sua.AutoSize = true;
            this.F_QLP_Sua.Location = new System.Drawing.Point(391, 238);
            this.F_QLP_Sua.Name = "F_QLP_Sua";
            this.F_QLP_Sua.Size = new System.Drawing.Size(118, 32);
            this.F_QLP_Sua.TabIndex = 1;
            this.F_QLP_Sua.Text = "Sửa";
            this.F_QLP_Sua.UseVisualStyleBackColor = true;
            this.F_QLP_Sua.Click += new System.EventHandler(this.F_QLP_Sua_Click);
            // 
            // F_QLP_Them
            // 
            this.F_QLP_Them.AutoSize = true;
            this.F_QLP_Them.Location = new System.Drawing.Point(160, 238);
            this.F_QLP_Them.Name = "F_QLP_Them";
            this.F_QLP_Them.Size = new System.Drawing.Size(118, 32);
            this.F_QLP_Them.TabIndex = 1;
            this.F_QLP_Them.Text = "Thêm";
            this.F_QLP_Them.UseVisualStyleBackColor = true;
            this.F_QLP_Them.Click += new System.EventHandler(this.F_QLP_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý phòng";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(554, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(145, 136);
            this.panel6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tình trạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên";
            // 
            // cb_manv
            // 
            this.cb_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_manv.Enabled = false;
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(19, 88);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(266, 30);
            this.cb_manv.TabIndex = 1;
            // 
            // F_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1093, 733);
            this.Controls.Add(this.F_QLP_V);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "F_QLP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.F_QLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_QLP_V)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_QLP_V;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button F_QLP_Thoat;
        private System.Windows.Forms.Button F_QLP_Xoa;
        private System.Windows.Forms.Button F_QLP_Sua;
        private System.Windows.Forms.Button F_QLP_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.ComboBox cb_loai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_manv;
    }
}