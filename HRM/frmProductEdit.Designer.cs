﻿namespace HRM
{
    partial class frmProductEdit
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
            this.maNVLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queQuanLabel = new System.Windows.Forms.Label();
            this.hKTTLabel = new System.Windows.Forms.Label();
            this.cMNDLabel = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenTA = new System.Windows.Forms.TextBox();
            this.txtTenTV = new System.Windows.Forms.TextBox();
            this.lkeNhomVT = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lkeKho = new DevExpress.XtraEditors.LookUpEdit();
            this.lkeDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.checkEdit = new DevExpress.XtraEditors.CheckEdit();
            this.btnProductClose = new DevExpress.XtraEditors.DropDownButton();
            this.btnProductEditSave = new DevExpress.XtraEditors.DropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lkeNhomVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            this.maNVLabel.AutoSize = true;
            this.maNVLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maNVLabel.ForeColor = System.Drawing.Color.Black;
            this.maNVLabel.Location = new System.Drawing.Point(50, 76);
            this.maNVLabel.Name = "maNVLabel";
            this.maNVLabel.Size = new System.Drawing.Size(49, 15);
            this.maNVLabel.TabIndex = 80;
            this.maNVLabel.Text = "Mã VT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(344, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "IsActive:";
            // 
            // queQuanLabel
            // 
            this.queQuanLabel.AutoSize = true;
            this.queQuanLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queQuanLabel.ForeColor = System.Drawing.Color.Black;
            this.queQuanLabel.Location = new System.Drawing.Point(46, 103);
            this.queQuanLabel.Name = "queQuanLabel";
            this.queQuanLabel.Size = new System.Drawing.Size(53, 15);
            this.queQuanLabel.TabIndex = 96;
            this.queQuanLabel.Text = "Tên T.A:";
            // 
            // hKTTLabel
            // 
            this.hKTTLabel.AutoSize = true;
            this.hKTTLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hKTTLabel.ForeColor = System.Drawing.Color.Black;
            this.hKTTLabel.Location = new System.Drawing.Point(47, 130);
            this.hKTTLabel.Name = "hKTTLabel";
            this.hKTTLabel.Size = new System.Drawing.Size(52, 15);
            this.hKTTLabel.TabIndex = 98;
            this.hKTTLabel.Text = "Tên T.V:";
            // 
            // cMNDLabel
            // 
            this.cMNDLabel.AutoSize = true;
            this.cMNDLabel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDLabel.ForeColor = System.Drawing.Color.Black;
            this.cMNDLabel.Location = new System.Drawing.Point(33, 258);
            this.cMNDLabel.Name = "cMNDLabel";
            this.cMNDLabel.Size = new System.Drawing.Size(67, 15);
            this.cMNDLabel.TabIndex = 100;
            this.cMNDLabel.Text = "Nhóm VT:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(102, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(250, 26);
            this.labelControl1.TabIndex = 116;
            this.labelControl1.Text = "SỬA THÔNG TIN VẬT TƯ";
            // 
            // txtMaVT
            // 
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Location = new System.Drawing.Point(105, 76);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 21);
            this.txtMaVT.TabIndex = 117;
            // 
            // txtTenTA
            // 
            this.txtTenTA.Location = new System.Drawing.Point(105, 103);
            this.txtTenTA.Name = "txtTenTA";
            this.txtTenTA.Size = new System.Drawing.Size(325, 21);
            this.txtTenTA.TabIndex = 117;
            // 
            // txtTenTV
            // 
            this.txtTenTV.Location = new System.Drawing.Point(105, 130);
            this.txtTenTV.Name = "txtTenTV";
            this.txtTenTV.Size = new System.Drawing.Size(325, 21);
            this.txtTenTV.TabIndex = 117;
            // 
            // lkeNhomVT
            // 
            this.lkeNhomVT.Location = new System.Drawing.Point(106, 256);
            this.lkeNhomVT.Name = "lkeNhomVT";
            this.lkeNhomVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeNhomVT.Size = new System.Drawing.Size(138, 20);
            this.lkeNhomVT.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 98;
            this.label6.Text = "Mô Tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(105, 157);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(325, 21);
            this.txtMoTa.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "Lưu Kho:";
            // 
            // lkeKho
            // 
            this.lkeKho.Location = new System.Drawing.Point(106, 282);
            this.lkeKho.Name = "lkeKho";
            this.lkeKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeKho.Size = new System.Drawing.Size(138, 20);
            this.lkeKho.TabIndex = 121;
            // 
            // lkeDonVi
            // 
            this.lkeDonVi.Location = new System.Drawing.Point(331, 256);
            this.lkeDonVi.Name = "lkeDonVi";
            this.lkeDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeDonVi.Size = new System.Drawing.Size(100, 20);
            this.lkeDonVi.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(273, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 100;
            this.label8.Text = "Đơn Vị:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 98;
            this.label9.Text = "Vị Trí:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(106, 184);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(325, 21);
            this.txtViTri.TabIndex = 117;
            // 
            // checkEdit
            // 
            this.checkEdit.Location = new System.Drawing.Point(405, 74);
            this.checkEdit.Name = "checkEdit";
            this.checkEdit.Properties.Caption = "";
            this.checkEdit.Size = new System.Drawing.Size(25, 19);
            this.checkEdit.TabIndex = 122;
            // 
            // btnProductClose
            // 
            this.btnProductClose.Image = global::HRM.Properties.Resources.quit;
            this.btnProductClose.Location = new System.Drawing.Point(254, 328);
            this.btnProductClose.Name = "btnProductClose";
            this.btnProductClose.Size = new System.Drawing.Size(111, 23);
            this.btnProductClose.TabIndex = 20;
            this.btnProductClose.Text = "Đóng";
            this.btnProductClose.ToolTip = "Đóng cửa sổ này";
            this.btnProductClose.Click += new System.EventHandler(this.btnProductClose_Click);
            // 
            // btnProductEditSave
            // 
            this.btnProductEditSave.Image = global::HRM.Properties.Resources.ok;
            this.btnProductEditSave.Location = new System.Drawing.Point(118, 328);
            this.btnProductEditSave.Name = "btnProductEditSave";
            this.btnProductEditSave.Size = new System.Drawing.Size(111, 23);
            this.btnProductEditSave.TabIndex = 18;
            this.btnProductEditSave.Text = "Cập nhật";
            this.btnProductEditSave.ToolTip = "Lưu lại thông tin vừa nhập";
            this.btnProductEditSave.Click += new System.EventHandler(this.btnProductEditSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(263, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tồn T.Th:";
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(331, 282);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(99, 21);
            this.txtTonKho.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 98;
            this.label3.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(105, 211);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(325, 21);
            this.txtGhiChu.TabIndex = 117;
            // 
            // frmProductEdit
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 377);
            this.Controls.Add(this.checkEdit);
            this.Controls.Add(this.lkeKho);
            this.Controls.Add(this.lkeDonVi);
            this.Controls.Add(this.lkeNhomVT);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenTV);
            this.Controls.Add(this.txtTenTA);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(this.btnProductClose);
            this.Controls.Add(this.btnProductEditSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.queQuanLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hKTTLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cMNDLabel);
            this.Controls.Add(this.maNVLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProductEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Vật Tư";
            this.Load += new System.EventHandler(this.frmProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkeNhomVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maNVLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label queQuanLabel;
        private System.Windows.Forms.Label hKTTLabel;
        private System.Windows.Forms.Label cMNDLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DropDownButton btnProductClose;
        private DevExpress.XtraEditors.DropDownButton btnProductEditSave;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtTenTA;
        private System.Windows.Forms.TextBox txtTenTV;
        private DevExpress.XtraEditors.LookUpEdit lkeNhomVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit lkeKho;
        private DevExpress.XtraEditors.LookUpEdit lkeDonVi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtViTri;
        private DevExpress.XtraEditors.CheckEdit checkEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}