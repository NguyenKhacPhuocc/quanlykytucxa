namespace WindowsFormsApp3
{
    partial class quarlithuvien
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
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvloaisach = new System.Windows.Forms.DataGridView();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(209, 85);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(308, 22);
            this.txtmaloai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "maloai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "tenloai";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(209, 130);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(308, 22);
            this.txttenloai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "mota";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(209, 172);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(308, 37);
            this.txtmota.TabIndex = 4;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(578, 47);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(578, 88);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "sua";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(578, 131);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 26);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // dgvloaisach
            // 
            this.dgvloaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaisach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.tenloai,
            this.mota});
            this.dgvloaisach.Location = new System.Drawing.Point(168, 246);
            this.dgvloaisach.Name = "dgvloaisach";
            this.dgvloaisach.RowHeadersWidth = 51;
            this.dgvloaisach.RowTemplate.Height = 24;
            this.dgvloaisach.Size = new System.Drawing.Size(430, 167);
            this.dgvloaisach.TabIndex = 9;
            // 
            // maloai
            // 
            this.maloai.HeaderText = "maloai";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            this.maloai.Width = 125;
            // 
            // tenloai
            // 
            this.tenloai.HeaderText = "tenloai";
            this.tenloai.MinimumWidth = 6;
            this.tenloai.Name = "tenloai";
            this.tenloai.Width = 125;
            // 
            // mota
            // 
            this.mota.HeaderText = "mota";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            this.mota.Width = 125;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(578, 204);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 26);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(578, 172);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 26);
            this.btntimkiem.TabIndex = 11;
            this.btntimkiem.Text = "tim kiem";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // quarlithuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvloaisach);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaloai);
            this.Name = "quarlithuvien";
            this.Text = "quarlithuvien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntimkiem;
    }
}