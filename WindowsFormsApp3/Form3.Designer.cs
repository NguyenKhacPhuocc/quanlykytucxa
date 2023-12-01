namespace WindowsFormsApp3
{
    partial class formcapnhatnxb
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
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.manxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(202, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "manxb";
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(296, 70);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(488, 22);
            this.txtmanxb.TabIndex = 1;
           // this.txtmanxb.TextChanged += new System.EventHandler(this.txtmanxb_TextChanged);
            // 
            // dgvds
            // 
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manxb,
            this.tennxb,
            this.dienthoai,
            this.diachi,
            this.email,
            this.ghichu});
            this.dgvds.Location = new System.Drawing.Point(148, 343);
            this.dgvds.Name = "dgvds";
            this.dgvds.RowHeadersWidth = 51;
            this.dgvds.RowTemplate.Height = 24;
            this.dgvds.Size = new System.Drawing.Size(797, 150);
            this.dgvds.TabIndex = 2;
           // this.dgvds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvds_CellContentClick);
            // 
            // manxb
            // 
            this.manxb.DataPropertyName = "manxb";
            this.manxb.HeaderText = "manxb";
            this.manxb.MinimumWidth = 6;
            this.manxb.Name = "manxb";
            this.manxb.Width = 125;
            // 
            // tennxb
            // 
            this.tennxb.DataPropertyName = "tennxb";
            this.tennxb.HeaderText = "tennxb";
            this.tennxb.MinimumWidth = 6;
            this.tennxb.Name = "tennxb";
            this.tennxb.Width = 125;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "dienthoai";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Width = 125;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "diachi";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "ghichu";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(296, 119);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(496, 22);
            this.txttennxb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "tennxb";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(296, 165);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(496, 22);
            this.txtdienthoai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "dienthoai";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(296, 211);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(496, 22);
            this.txtemail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "email";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(296, 239);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(496, 40);
            this.txtdiachi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "diachi";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(296, 294);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(496, 43);
            this.txtghichu.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ghichu";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(821, 84);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(821, 133);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "sua";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(821, 189);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.Text = "tim kiem";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(821, 239);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 16;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(821, 287);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "CẬP NHẬT THÔNG TIN NXB";
            // 
            // formcapnhatnxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttennxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvds);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.label1);
            this.Name = "formcapnhatnxb";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn manxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}