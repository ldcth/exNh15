namespace bt01
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbCV = new System.Windows.Forms.CheckBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbCH = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbbTR = new System.Windows.Forms.ComboBox();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.butTT = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ten khach hang";
            // 
            // cbCV
            // 
            this.cbCV.AutoSize = true;
            this.cbCV.Location = new System.Drawing.Point(70, 155);
            this.cbCV.Name = "cbCV";
            this.cbCV.Size = new System.Drawing.Size(75, 20);
            this.cbCV.TabIndex = 3;
            this.cbCV.Text = "Cao voi";
            this.cbCV.UseVisualStyleBackColor = true;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(70, 194);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(86, 20);
            this.cbTT.TabIndex = 3;
            this.cbTT.Text = "Tay trang";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbCH
            // 
            this.cbCH.AutoSize = true;
            this.cbCH.Location = new System.Drawing.Point(70, 231);
            this.cbCH.Name = "cbCH";
            this.cbCH.Size = new System.Drawing.Size(87, 20);
            this.cbCH.TabIndex = 3;
            this.cbCH.Text = "Chup hinh";
            this.cbCH.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(253, 332);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 22);
            this.txtTotal.TabIndex = 0;
            // 
            // cbbTR
            // 
            this.cbbTR.FormattingEnabled = true;
            this.cbbTR.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cbbTR.Location = new System.Drawing.Point(159, 264);
            this.cbbTR.Name = "cbbTR";
            this.cbbTR.Size = new System.Drawing.Size(85, 24);
            this.cbbTR.TabIndex = 4;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(67, 272);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(69, 16);
            this.lblTR.TabIndex = 2;
            this.lblTR.Text = "Tram rang";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(206, 335);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // butTT
            // 
            this.butTT.Location = new System.Drawing.Point(277, 386);
            this.butTT.Name = "butTT";
            this.butTT.Size = new System.Drawing.Size(103, 26);
            this.butTT.TabIndex = 5;
            this.butTT.Text = "Tinh tien";
            this.butTT.UseVisualStyleBackColor = true;
            this.butTT.Click += new System.EventHandler(this.butTT_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(70, 386);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(103, 26);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butTT);
            this.Controls.Add(this.cbbTR);
            this.Controls.Add(this.cbCH);
            this.Controls.Add(this.cbTT);
            this.Controls.Add(this.cbCV);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbCV;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbCH;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbbTR;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button butTT;
        private System.Windows.Forms.Button butExit;
    }
}

