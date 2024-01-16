namespace Quan_Ly_F_B
{
    partial class fNotification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlKetQua = new System.Windows.Forms.Panel();
            this.flpKetQua = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvMonHet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenMonKetQua = new System.Windows.Forms.TextBox();
            this.lbnKetQua = new System.Windows.Forms.Label();
            this.pnlKhaiBao = new System.Windows.Forms.Panel();
            this.flpKhaiBao = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvMonCon = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenMonKhaiBao = new System.Windows.Forms.TextBox();
            this.lbnMonCon = new System.Windows.Forms.Label();
            this.btnConMon = new System.Windows.Forms.Button();
            this.btnHetMon = new System.Windows.Forms.Button();
            this.lbnThongBao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlKetQua.SuspendLayout();
            this.flpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHet)).BeginInit();
            this.pnlKhaiBao.SuspendLayout();
            this.flpKhaiBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonCon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.pnlKetQua);
            this.panel1.Controls.Add(this.pnlKhaiBao);
            this.panel1.Controls.Add(this.btnConMon);
            this.panel1.Controls.Add(this.btnHetMon);
            this.panel1.Controls.Add(this.lbnThongBao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 629);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(531, 537);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 40);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(534, 583);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlKetQua
            // 
            this.pnlKetQua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlKetQua.Controls.Add(this.flpKetQua);
            this.pnlKetQua.Controls.Add(this.txtTenMonKetQua);
            this.pnlKetQua.Controls.Add(this.lbnKetQua);
            this.pnlKetQua.Location = new System.Drawing.Point(633, 32);
            this.pnlKetQua.Name = "pnlKetQua";
            this.pnlKetQua.Size = new System.Drawing.Size(525, 594);
            this.pnlKetQua.TabIndex = 6;
            // 
            // flpKetQua
            // 
            this.flpKetQua.AutoScroll = true;
            this.flpKetQua.Controls.Add(this.dgvMonHet);
            this.flpKetQua.Location = new System.Drawing.Point(3, 75);
            this.flpKetQua.Name = "flpKetQua";
            this.flpKetQua.Size = new System.Drawing.Size(519, 516);
            this.flpKetQua.TabIndex = 4;
            // 
            // dgvMonHet
            // 
            this.dgvMonHet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMonHet.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMonHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvMonHet.Location = new System.Drawing.Point(3, 3);
            this.dgvMonHet.Name = "dgvMonHet";
            this.dgvMonHet.RowHeadersWidth = 51;
            this.dgvMonHet.RowTemplate.Height = 24;
            this.dgvMonHet.Size = new System.Drawing.Size(492, 513);
            this.dgvMonHet.TabIndex = 0;
            this.dgvMonHet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenMon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Món";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // txtTenMonKetQua
            // 
            this.txtTenMonKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonKetQua.Location = new System.Drawing.Point(3, 35);
            this.txtTenMonKetQua.Name = "txtTenMonKetQua";
            this.txtTenMonKetQua.Size = new System.Drawing.Size(519, 34);
            this.txtTenMonKetQua.TabIndex = 3;
            this.txtTenMonKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbnKetQua
            // 
            this.lbnKetQua.AutoSize = true;
            this.lbnKetQua.BackColor = System.Drawing.Color.SandyBrown;
            this.lbnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnKetQua.Location = new System.Drawing.Point(3, 3);
            this.lbnKetQua.Name = "lbnKetQua";
            this.lbnKetQua.Size = new System.Drawing.Size(625, 29);
            this.lbnKetQua.TabIndex = 2;
            this.lbnKetQua.Text = "                                          Món Hết                                " +
    "             ";
            this.lbnKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKhaiBao
            // 
            this.pnlKhaiBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlKhaiBao.Controls.Add(this.flpKhaiBao);
            this.pnlKhaiBao.Controls.Add(this.txtTenMonKhaiBao);
            this.pnlKhaiBao.Controls.Add(this.lbnMonCon);
            this.pnlKhaiBao.Location = new System.Drawing.Point(3, 32);
            this.pnlKhaiBao.Name = "pnlKhaiBao";
            this.pnlKhaiBao.Size = new System.Drawing.Size(525, 594);
            this.pnlKhaiBao.TabIndex = 5;
            // 
            // flpKhaiBao
            // 
            this.flpKhaiBao.AutoScroll = true;
            this.flpKhaiBao.Controls.Add(this.dgvMonCon);
            this.flpKhaiBao.Location = new System.Drawing.Point(3, 75);
            this.flpKhaiBao.Name = "flpKhaiBao";
            this.flpKhaiBao.Size = new System.Drawing.Size(519, 516);
            this.flpKhaiBao.TabIndex = 4;
            // 
            // dgvMonCon
            // 
            this.dgvMonCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMonCon.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMonCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon});
            this.dgvMonCon.Location = new System.Drawing.Point(3, 3);
            this.dgvMonCon.Name = "dgvMonCon";
            this.dgvMonCon.RowHeadersWidth = 51;
            this.dgvMonCon.RowTemplate.Height = 24;
            this.dgvMonCon.Size = new System.Drawing.Size(492, 513);
            this.dgvMonCon.TabIndex = 0;
            this.dgvMonCon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhaiBao_CellClick);
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 103;
            // 
            // txtTenMonKhaiBao
            // 
            this.txtTenMonKhaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonKhaiBao.Location = new System.Drawing.Point(3, 35);
            this.txtTenMonKhaiBao.Name = "txtTenMonKhaiBao";
            this.txtTenMonKhaiBao.Size = new System.Drawing.Size(519, 34);
            this.txtTenMonKhaiBao.TabIndex = 3;
            this.txtTenMonKhaiBao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenMonKhaiBao.TextChanged += new System.EventHandler(this.txtTenMonKhaiBao_TextChanged);
            // 
            // lbnMonCon
            // 
            this.lbnMonCon.AutoSize = true;
            this.lbnMonCon.BackColor = System.Drawing.Color.SandyBrown;
            this.lbnMonCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnMonCon.Location = new System.Drawing.Point(3, 3);
            this.lbnMonCon.Name = "lbnMonCon";
            this.lbnMonCon.Size = new System.Drawing.Size(626, 29);
            this.lbnMonCon.TabIndex = 2;
            this.lbnMonCon.Text = "                                          Món Còn                                " +
    "            ";
            this.lbnMonCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConMon
            // 
            this.btnConMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConMon.Location = new System.Drawing.Point(534, 340);
            this.btnConMon.Name = "btnConMon";
            this.btnConMon.Size = new System.Drawing.Size(90, 40);
            this.btnConMon.TabIndex = 4;
            this.btnConMon.Text = "<";
            this.btnConMon.UseVisualStyleBackColor = true;
            this.btnConMon.Click += new System.EventHandler(this.btnConMon_Click);
            // 
            // btnHetMon
            // 
            this.btnHetMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHetMon.Location = new System.Drawing.Point(534, 294);
            this.btnHetMon.Name = "btnHetMon";
            this.btnHetMon.Size = new System.Drawing.Size(90, 40);
            this.btnHetMon.TabIndex = 3;
            this.btnHetMon.Text = ">";
            this.btnHetMon.UseVisualStyleBackColor = true;
            this.btnHetMon.Click += new System.EventHandler(this.btnHetMon_Click);
            // 
            // lbnThongBao
            // 
            this.lbnThongBao.AutoSize = true;
            this.lbnThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnThongBao.Location = new System.Drawing.Point(312, 0);
            this.lbnThongBao.Name = "lbnThongBao";
            this.lbnThongBao.Size = new System.Drawing.Size(735, 29);
            this.lbnThongBao.TabIndex = 0;
            this.lbnThongBao.Text = "Bạn chuyển món hết sang phải, món còn sang trái và nhấn Ok nhé !!!";
            // 
            // fNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai Báo Hết Món";
            this.Load += new System.EventHandler(this.fNotification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKetQua.ResumeLayout(false);
            this.pnlKetQua.PerformLayout();
            this.flpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHet)).EndInit();
            this.pnlKhaiBao.ResumeLayout(false);
            this.pnlKhaiBao.PerformLayout();
            this.flpKhaiBao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbnThongBao;
        private System.Windows.Forms.Button btnHetMon;
        private System.Windows.Forms.Panel pnlKhaiBao;
        private System.Windows.Forms.Button btnConMon;
        private System.Windows.Forms.TextBox txtTenMonKhaiBao;
        private System.Windows.Forms.Label lbnMonCon;
        private System.Windows.Forms.FlowLayoutPanel flpKhaiBao;
        private System.Windows.Forms.DataGridView dgvMonCon;
        private System.Windows.Forms.Panel pnlKetQua;
        private System.Windows.Forms.FlowLayoutPanel flpKetQua;
        private System.Windows.Forms.DataGridView dgvMonHet;
        private System.Windows.Forms.TextBox txtTenMonKetQua;
        private System.Windows.Forms.Label lbnKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHuy;
    }
}