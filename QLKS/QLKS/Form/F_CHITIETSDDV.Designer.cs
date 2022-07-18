namespace QLKS
{
    partial class F_CHITIETSDDV
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
            this.V_Dichvu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tien = new System.Windows.Forms.Label();
            this.btn_chon = new System.Windows.Forms.Button();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_tendv = new System.Windows.Forms.TextBox();
            this.tb_madv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.cl_sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_chitiet = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.V_Dichvu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // V_Dichvu
            // 
            this.V_Dichvu.AllowUserToAddRows = false;
            this.V_Dichvu.AllowUserToDeleteRows = false;
            this.V_Dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.V_Dichvu.Location = new System.Drawing.Point(22, 13);
            this.V_Dichvu.Name = "V_Dichvu";
            this.V_Dichvu.ReadOnly = true;
            this.V_Dichvu.RowTemplate.Height = 24;
            this.V_Dichvu.Size = new System.Drawing.Size(506, 331);
            this.V_Dichvu.TabIndex = 0;
            this.V_Dichvu.SelectionChanged += new System.EventHandler(this.V_Dichvu_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_tien);
            this.panel1.Controls.Add(this.btn_chon);
            this.panel1.Controls.Add(this.tb_sl);
            this.panel1.Controls.Add(this.tb_gia);
            this.panel1.Controls.Add(this.tb_tendv);
            this.panel1.Controls.Add(this.tb_madv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(550, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 331);
            this.panel1.TabIndex = 1;
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.ForeColor = System.Drawing.Color.Red;
            this.lb_tien.Location = new System.Drawing.Point(167, 225);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(2, 21);
            this.lb_tien.TabIndex = 12;
            // 
            // btn_chon
            // 
            this.btn_chon.AutoSize = true;
            this.btn_chon.Enabled = false;
            this.btn_chon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chon.Location = new System.Drawing.Point(114, 271);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(99, 32);
            this.btn_chon.TabIndex = 11;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // tb_sl
            // 
            this.tb_sl.Enabled = false;
            this.tb_sl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sl.Location = new System.Drawing.Point(167, 176);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(146, 27);
            this.tb_sl.TabIndex = 6;
            this.tb_sl.TextChanged += new System.EventHandler(this.tb_sl_TextChanged);
            // 
            // tb_gia
            // 
            this.tb_gia.Enabled = false;
            this.tb_gia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gia.Location = new System.Drawing.Point(167, 123);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(146, 27);
            this.tb_gia.TabIndex = 7;
            // 
            // tb_tendv
            // 
            this.tb_tendv.Enabled = false;
            this.tb_tendv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tendv.Location = new System.Drawing.Point(167, 73);
            this.tb_tendv.Name = "tb_tendv";
            this.tb_tendv.Size = new System.Drawing.Size(146, 27);
            this.tb_tendv.TabIndex = 8;
            // 
            // tb_madv
            // 
            this.tb_madv.Enabled = false;
            this.tb_madv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_madv.Location = new System.Drawing.Point(167, 26);
            this.tb_madv.Name = "tb_madv";
            this.tb_madv.Size = new System.Drawing.Size(146, 27);
            this.tb_madv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_tongtien.Location = new System.Drawing.Point(772, 426);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(2, 21);
            this.lb_tongtien.TabIndex = 12;
            this.lb_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_luu
            // 
            this.btn_luu.AutoSize = true;
            this.btn_luu.Enabled = false;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(764, 486);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(99, 32);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // cl_sl
            // 
            this.cl_sl.HeaderText = "Số lượng";
            this.cl_sl.Name = "cl_sl";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // tendv
            // 
            this.tendv.HeaderText = "Tên dịch vụ";
            this.tendv.Name = "tendv";
            // 
            // madv
            // 
            this.madv.HeaderText = "Mã dịch vụ";
            this.madv.Name = "madv";
            // 
            // V_chitiet
            // 
            this.V_chitiet.AllowUserToAddRows = false;
            this.V_chitiet.AllowUserToDeleteRows = false;
            this.V_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.V_chitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madv,
            this.tendv,
            this.dongia,
            this.cl_sl});
            this.V_chitiet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.V_chitiet.Location = new System.Drawing.Point(22, 361);
            this.V_chitiet.Name = "V_chitiet";
            this.V_chitiet.RowTemplate.Height = 24;
            this.V_chitiet.Size = new System.Drawing.Size(697, 265);
            this.V_chitiet.TabIndex = 0;
            this.V_chitiet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.V_chitiet_CellDoubleClick);
            this.V_chitiet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.V_chitiet_KeyDown);
            this.V_chitiet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V_chitiet_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Enabled = false;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(764, 550);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 32);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // F_CHITIETSDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 638);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.V_chitiet);
            this.Controls.Add(this.V_Dichvu);
            this.Controls.Add(this.label2);
            this.Name = "F_CHITIETSDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hoá đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_CHITIETSDDV_FormClosing);
            this.Load += new System.EventHandler(this.F_CHITIETSDDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.V_Dichvu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_chitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView V_Dichvu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.TextBox tb_tendv;
        private System.Windows.Forms.TextBox tb_madv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridView V_chitiet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_thoat;
    }
}