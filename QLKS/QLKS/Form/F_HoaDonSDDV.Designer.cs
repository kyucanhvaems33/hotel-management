namespace QLKS
{
    partial class F_HoaDonSDDV
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
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_in = new System.Windows.Forms.Button();
            this.V_SDDV = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_SDDV)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(821, 203);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(181, 27);
            this.tb_timkiem.TabIndex = 16;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(880, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách hoá đơn sử dụng dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(789, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 152);
            this.panel1.TabIndex = 13;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(53, 106);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 26);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "CCCD";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(53, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(174, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Họ tên khách hàng";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(53, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Số hoá đơn";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_in
            // 
            this.btn_in.AutoSize = true;
            this.btn_in.Enabled = false;
            this.btn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Location = new System.Drawing.Point(848, 236);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(114, 35);
            this.btn_in.TabIndex = 12;
            this.btn_in.Text = "In hoá đơn";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // V_SDDV
            // 
            this.V_SDDV.AllowUserToAddRows = false;
            this.V_SDDV.AllowUserToDeleteRows = false;
            this.V_SDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.V_SDDV.Location = new System.Drawing.Point(24, 33);
            this.V_SDDV.Name = "V_SDDV";
            this.V_SDDV.ReadOnly = true;
            this.V_SDDV.RowTemplate.Height = 24;
            this.V_SDDV.Size = new System.Drawing.Size(730, 297);
            this.V_SDDV.TabIndex = 11;
            this.V_SDDV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.V_SDDV_CellDoubleClick);
            this.V_SDDV.SelectionChanged += new System.EventHandler(this.V_SDDV_SelectionChanged);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(863, 286);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(91, 35);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // F_HoaDonSDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 341);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.tb_timkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.V_SDDV);
            this.Name = "F_HoaDonSDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_HoaDonSDDV";
            this.Load += new System.EventHandler(this.F_HoaDonSDDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.V_SDDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.DataGridView V_SDDV;
        private System.Windows.Forms.Button btn_thoat;
    }
}