﻿namespace vidu2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNpad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CHẤM CÔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(261, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(28, 382);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 46);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày công";
            // 
            // txtWd
            // 
            this.txtWd.Location = new System.Drawing.Point(526, 159);
            this.txtWd.Name = "txtWd";
            this.txtWd.Size = new System.Drawing.Size(100, 22);
            this.txtWd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày vắng:";
            // 
            // txtPad
            // 
            this.txtPad.Location = new System.Drawing.Point(560, 257);
            this.txtPad.Name = "txtPad";
            this.txtPad.Size = new System.Drawing.Size(31, 22);
            this.txtPad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Có phép";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Không phép";
            // 
            // txtNpad
            // 
            this.txtNpad.Location = new System.Drawing.Point(560, 297);
            this.txtNpad.Name = "txtNpad";
            this.txtNpad.Size = new System.Drawing.Size(31, 22);
            this.txtNpad.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Trễ";
            // 
            // txtLd
            // 
            this.txtLd.Location = new System.Drawing.Point(560, 337);
            this.txtLd.Name = "txtLd";
            this.txtLd.Size = new System.Drawing.Size(31, 22);
            this.txtLd.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phòng ban";
            // 
            // txtDp
            // 
            this.txtDp.Location = new System.Drawing.Point(261, 221);
            this.txtDp.Name = "txtDp";
            this.txtDp.Size = new System.Drawing.Size(100, 22);
            this.txtDp.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giới tính";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(526, 95);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(65, 24);
            this.cbGender.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(109, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 46);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(190, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 46);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(275, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 46);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(437, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 46);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Black;
            this.lblNotice.Location = new System.Drawing.Point(71, 339);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 25);
            this.lblNotice.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(356, 382);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 46);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mã tự động";
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(129, 30);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(100, 22);
            this.txtAuto.TabIndex = 0;
            this.txtAuto.TextChanged += new System.EventHandler(this.txtAuto_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDp);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLd);
            this.Controls.Add(this.txtNpad);
            this.Controls.Add(this.txtPad);
            this.Controls.Add(this.txtWd);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNpad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAuto;
    }
}