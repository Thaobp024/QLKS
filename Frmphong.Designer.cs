namespace quanlykhachsan
{
    partial class Frmphong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdonggia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntThem = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donggia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "maphong";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(57, 0);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 20);
            this.txtmaphong.TabIndex = 1;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(58, 37);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(100, 20);
            this.txttenphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "tenphong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "donggia";
            // 
            // txtdonggia
            // 
            this.txtdonggia.Location = new System.Drawing.Point(287, 12);
            this.txtdonggia.Name = "txtdonggia";
            this.txtdonggia.Size = new System.Drawing.Size(100, 20);
            this.txtdonggia.TabIndex = 6;
            this.txtdonggia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdonggia_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.donggia});
            this.dataGridView1.Location = new System.Drawing.Point(58, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 122);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(12, 226);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 8;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(93, 226);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 9;
            this.sua.Text = "sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(174, 226);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 10;
            this.xoa.Text = "xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(255, 226);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 11;
            this.luu.Text = "lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // huy
            // 
            this.huy.Location = new System.Drawing.Point(336, 226);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(75, 23);
            this.huy.TabIndex = 12;
            this.huy.Text = "hủy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(417, 226);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 13;
            this.thoat.Text = "thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "mã phòng";
            this.maphong.Name = "maphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // donggia
            // 
            this.donggia.DataPropertyName = "donggia";
            this.donggia.HeaderText = "đồng giá";
            this.donggia.Name = "donggia";
            // 
            // Frmphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdonggia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label1);
            this.Name = "Frmphong";
            this.Text = "Frmphong";
            this.Load += new System.EventHandler(this.Frmphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdonggia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donggia;
    }
}