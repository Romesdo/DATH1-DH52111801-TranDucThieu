namespace Quan_Ly_F_B
{
    partial class fMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cboChonLoaiMon = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.blnNhapDonGia = new System.Windows.Forms.Label();
            this.lbnChonLoaiMon = new System.Windows.Forms.Label();
            this.lbnNhapTenMon = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Controls.Add(this.btnLuuMon);
            this.pnlMenu.Controls.Add(this.btnSuaMon);
            this.pnlMenu.Controls.Add(this.btnXoaMon);
            this.pnlMenu.Controls.Add(this.btnThemMon);
            this.pnlMenu.Controls.Add(this.cboChonLoaiMon);
            this.pnlMenu.Controls.Add(this.txtDonGia);
            this.pnlMenu.Controls.Add(this.txtTenMon);
            this.pnlMenu.Controls.Add(this.blnNhapDonGia);
            this.pnlMenu.Controls.Add(this.lbnChonLoaiMon);
            this.pnlMenu.Controls.Add(this.lbnNhapTenMon);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1248, 674);
            this.pnlMenu.TabIndex = 0;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToOrderColumns = true;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMenu.ColumnHeadersHeight = 29;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMenu.Location = new System.Drawing.Point(318, 235);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(594, 415);
            this.dgvMenu.TabIndex = 27;
            this.dgvMenu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenMon";
            this.Column1.HeaderText = "Tên món";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoaiMon";
            this.Column2.HeaderText = "Loại món ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 88;
            // 
            // btnLuuMon
            // 
            this.btnLuuMon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLuuMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuMon.Location = new System.Drawing.Point(1018, 114);
            this.btnLuuMon.Name = "btnLuuMon";
            this.btnLuuMon.Size = new System.Drawing.Size(195, 72);
            this.btnLuuMon.TabIndex = 26;
            this.btnLuuMon.Text = "Lưu ";
            this.btnLuuMon.UseVisualStyleBackColor = false;
            this.btnLuuMon.Click += new System.EventHandler(this.btnLuuMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.Location = new System.Drawing.Point(795, 114);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(195, 72);
            this.btnSuaMon.TabIndex = 25;
            this.btnSuaMon.Text = "Sửa món";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Location = new System.Drawing.Point(1018, 22);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(195, 72);
            this.btnXoaMon.TabIndex = 24;
            this.btnXoaMon.Text = "Xóa món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(795, 22);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(195, 72);
            this.btnThemMon.TabIndex = 23;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cboChonLoaiMon
            // 
            this.cboChonLoaiMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChonLoaiMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChonLoaiMon.BackColor = System.Drawing.Color.White;
            this.cboChonLoaiMon.DropDownHeight = 150;
            this.cboChonLoaiMon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLoaiMon.FormattingEnabled = true;
            this.cboChonLoaiMon.IntegralHeight = false;
            this.cboChonLoaiMon.Items.AddRange(new object[] {
            "Cà Phê Máy",
            "Cà Phê Việt Nam",
            "HighFee",
            "HighTea",
            "ColdBrew",
            "Ice Blended",
            "R-Tea",
            "Trà Sữa",
            "Trà Trái Cây",
            "Trà Xanh - Chocolate",
            "Bánh Ngọt",
            "Bánh Mặn"});
            this.cboChonLoaiMon.Location = new System.Drawing.Point(318, 81);
            this.cboChonLoaiMon.MaxDropDownItems = 5;
            this.cboChonLoaiMon.Name = "cboChonLoaiMon";
            this.cboChonLoaiMon.Size = new System.Drawing.Size(458, 54);
            this.cboChonLoaiMon.TabIndex = 21;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(318, 141);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(458, 53);
            this.txtDonGia.TabIndex = 22;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(318, 22);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(458, 53);
            this.txtTenMon.TabIndex = 20;
            // 
            // blnNhapDonGia
            // 
            this.blnNhapDonGia.AutoSize = true;
            this.blnNhapDonGia.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blnNhapDonGia.Location = new System.Drawing.Point(25, 141);
            this.blnNhapDonGia.Name = "blnNhapDonGia";
            this.blnNhapDonGia.Size = new System.Drawing.Size(261, 45);
            this.blnNhapDonGia.TabIndex = 19;
            this.blnNhapDonGia.Text = "Nhập đơn giá:";
            // 
            // lbnChonLoaiMon
            // 
            this.lbnChonLoaiMon.AutoSize = true;
            this.lbnChonLoaiMon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnChonLoaiMon.Location = new System.Drawing.Point(25, 81);
            this.lbnChonLoaiMon.Name = "lbnChonLoaiMon";
            this.lbnChonLoaiMon.Size = new System.Drawing.Size(279, 45);
            this.lbnChonLoaiMon.TabIndex = 18;
            this.lbnChonLoaiMon.Text = "Chọn loại món:";
            // 
            // lbnNhapTenMon
            // 
            this.lbnNhapTenMon.AutoSize = true;
            this.lbnNhapTenMon.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnNhapTenMon.Location = new System.Drawing.Point(25, 22);
            this.lbnNhapTenMon.Name = "lbnNhapTenMon";
            this.lbnNhapTenMon.Size = new System.Drawing.Size(272, 45);
            this.lbnNhapTenMon.TabIndex = 17;
            this.lbnNhapTenMon.Text = "Nhập tên món:";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 698);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLuuMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cboChonLoaiMon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label blnNhapDonGia;
        private System.Windows.Forms.Label lbnChonLoaiMon;
        private System.Windows.Forms.Label lbnNhapTenMon;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}