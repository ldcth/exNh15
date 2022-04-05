namespace GK
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
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCMND = new System.Windows.Forms.CheckBox();
            this.cbHB = new System.Windows.Forms.CheckBox();
            this.cbAnh = new System.Windows.Forms.CheckBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(165, 34);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(165, 27);
            this.txtMSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 27);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp SH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "DTB";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(567, 87);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(292, 27);
            this.txtDTB.TabIndex = 1;
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(165, 136);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(165, 28);
            this.cbbLSH.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(59, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(161, 49);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 24);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(33, 49);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(66, 24);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCMND);
            this.groupBox2.Controls.Add(this.cbHB);
            this.groupBox2.Controls.Add(this.cbAnh);
            this.groupBox2.Location = new System.Drawing.Point(450, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ nộp";
            // 
            // cbCMND
            // 
            this.cbCMND.AutoSize = true;
            this.cbCMND.Location = new System.Drawing.Point(30, 116);
            this.cbCMND.Name = "cbCMND";
            this.cbCMND.Size = new System.Drawing.Size(82, 24);
            this.cbCMND.TabIndex = 0;
            this.cbCMND.Text = "CMND";
            this.cbCMND.UseVisualStyleBackColor = true;
            // 
            // cbHB
            // 
            this.cbHB.AutoSize = true;
            this.cbHB.Location = new System.Drawing.Point(30, 77);
            this.cbHB.Name = "cbHB";
            this.cbHB.Size = new System.Drawing.Size(85, 24);
            this.cbHB.TabIndex = 0;
            this.cbHB.Text = "Học bạ";
            this.cbHB.UseVisualStyleBackColor = true;
            // 
            // cbAnh
            // 
            this.cbAnh.AutoSize = true;
            this.cbAnh.Location = new System.Drawing.Point(30, 38);
            this.cbAnh.Name = "cbAnh";
            this.cbAnh.Size = new System.Drawing.Size(60, 24);
            this.cbAnh.TabIndex = 0;
            this.cbAnh.Text = "Ảnh";
            this.cbAnh.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(238, 339);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(106, 44);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(452, 339);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(113, 44);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 422);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbCMND;
        private System.Windows.Forms.CheckBox cbHB;
        private System.Windows.Forms.CheckBox cbAnh;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}