namespace QLKS
{
    partial class F_QLDV
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
            this.F_QLDV_V = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.F_QLDV_Thoat = new System.Windows.Forms.Button();
            this.F_QLDV_Xoa = new System.Windows.Forms.Button();
            this.F_QLDV_Sua = new System.Windows.Forms.Button();
            this.F_QLDV_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.F_QLDV_V)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // F_QLDV_V
            // 
            this.F_QLDV_V.AllowUserToAddRows = false;
            this.F_QLDV_V.AllowUserToDeleteRows = false;
            this.F_QLDV_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_QLDV_V.Location = new System.Drawing.Point(13, 366);
            this.F_QLDV_V.Name = "F_QLDV_V";
            this.F_QLDV_V.ReadOnly = true;
            this.F_QLDV_V.RowTemplate.Height = 24;
            this.F_QLDV_V.Size = new System.Drawing.Size(1069, 297);
            this.F_QLDV_V.TabIndex = 8;
            this.F_QLDV_V.SelectionChanged += new System.EventHandler(this.F_QLDV_V_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.F_QLDV_Thoat);
            this.panel1.Controls.Add(this.F_QLDV_Xoa);
            this.panel1.Controls.Add(this.F_QLDV_Sua);
            this.panel1.Controls.Add(this.F_QLDV_Them);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 245);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(151, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 162);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_manv);
            this.panel2.Controls.Add(this.tb_gia);
            this.panel2.Controls.Add(this.tb_ten);
            this.panel2.Controls.Add(this.tb_ma);
            this.panel2.Location = new System.Drawing.Point(320, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 172);
            this.panel2.TabIndex = 2;
            // 
            // tb_gia
            // 
            this.tb_gia.Enabled = false;
            this.tb_gia.Location = new System.Drawing.Point(19, 92);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(266, 30);
            this.tb_gia.TabIndex = 0;
            // 
            // tb_ten
            // 
            this.tb_ten.Enabled = false;
            this.tb_ten.Location = new System.Drawing.Point(19, 53);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(266, 30);
            this.tb_ten.TabIndex = 0;
            // 
            // tb_ma
            // 
            this.tb_ma.Enabled = false;
            this.tb_ma.Location = new System.Drawing.Point(19, 14);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(266, 30);
            this.tb_ma.TabIndex = 0;
            // 
            // F_QLDV_Thoat
            // 
            this.F_QLDV_Thoat.AutoSize = true;
            this.F_QLDV_Thoat.Location = new System.Drawing.Point(845, 177);
            this.F_QLDV_Thoat.Name = "F_QLDV_Thoat";
            this.F_QLDV_Thoat.Size = new System.Drawing.Size(118, 32);
            this.F_QLDV_Thoat.TabIndex = 1;
            this.F_QLDV_Thoat.Text = "Thoát";
            this.F_QLDV_Thoat.UseVisualStyleBackColor = true;
            this.F_QLDV_Thoat.Click += new System.EventHandler(this.F_QLDV_Thoat_Click);
            // 
            // F_QLDV_Xoa
            // 
            this.F_QLDV_Xoa.AutoSize = true;
            this.F_QLDV_Xoa.Location = new System.Drawing.Point(845, 79);
            this.F_QLDV_Xoa.Name = "F_QLDV_Xoa";
            this.F_QLDV_Xoa.Size = new System.Drawing.Size(118, 32);
            this.F_QLDV_Xoa.TabIndex = 1;
            this.F_QLDV_Xoa.Text = "Xoá";
            this.F_QLDV_Xoa.UseVisualStyleBackColor = true;
            this.F_QLDV_Xoa.Click += new System.EventHandler(this.F_QLDV_Xoa_Click);
            // 
            // F_QLDV_Sua
            // 
            this.F_QLDV_Sua.AutoSize = true;
            this.F_QLDV_Sua.Location = new System.Drawing.Point(658, 177);
            this.F_QLDV_Sua.Name = "F_QLDV_Sua";
            this.F_QLDV_Sua.Size = new System.Drawing.Size(118, 32);
            this.F_QLDV_Sua.TabIndex = 1;
            this.F_QLDV_Sua.Text = "Sửa";
            this.F_QLDV_Sua.UseVisualStyleBackColor = true;
            this.F_QLDV_Sua.Click += new System.EventHandler(this.F_QLDV_Sua_Click);
            // 
            // F_QLDV_Them
            // 
            this.F_QLDV_Them.AutoSize = true;
            this.F_QLDV_Them.Location = new System.Drawing.Point(658, 79);
            this.F_QLDV_Them.Name = "F_QLDV_Them";
            this.F_QLDV_Them.Size = new System.Drawing.Size(118, 32);
            this.F_QLDV_Them.TabIndex = 1;
            this.F_QLDV_Them.Text = "Thêm";
            this.F_QLDV_Them.UseVisualStyleBackColor = true;
            this.F_QLDV_Them.Click += new System.EventHandler(this.F_QLDV_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // tb_manv
            // 
            this.tb_manv.Enabled = false;
            this.tb_manv.Location = new System.Drawing.Point(19, 128);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(266, 30);
            this.tb_manv.TabIndex = 0;
            // 
            // F_QLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 687);
            this.Controls.Add(this.F_QLDV_V);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "F_QLDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.F_QLDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_QLDV_V)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_QLDV_V;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Button F_QLDV_Thoat;
        private System.Windows.Forms.Button F_QLDV_Xoa;
        private System.Windows.Forms.Button F_QLDV_Sua;
        private System.Windows.Forms.Button F_QLDV_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_manv;
    }
}