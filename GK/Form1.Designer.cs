namespace GK
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLSH = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp SH";
            // 
            // cbbLSH
            // 
            this.cbbLSH.FormattingEnabled = true;
            this.cbbLSH.Location = new System.Drawing.Point(135, 34);
            this.cbbLSH.Name = "cbbLSH";
            this.cbbLSH.Size = new System.Drawing.Size(121, 28);
            this.cbbLSH.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(516, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 27);
            this.tbName.TabIndex = 2;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(653, 27);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(88, 31);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(46, 365);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(80, 39);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(695, 244);
            this.dataGridView1.TabIndex = 4;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(162, 365);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(80, 39);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(273, 365);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(80, 39);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(385, 365);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(80, 39);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(498, 365);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(80, 39);
            this.btSort.TabIndex = 3;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(620, 371);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(121, 28);
            this.cbbSort.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.cbbLSH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLSH;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}

