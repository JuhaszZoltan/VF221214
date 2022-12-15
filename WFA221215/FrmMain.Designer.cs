namespace WFA221215
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUI01 = new System.Windows.Forms.GroupBox();
            this.link = new System.Windows.Forms.LinkLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUI01 = new System.Windows.Forms.Label();
            this.lblUI02 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.gbUI01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUI01
            // 
            this.gbUI01.BackColor = System.Drawing.Color.PaleGreen;
            this.gbUI01.Controls.Add(this.cb);
            this.gbUI01.Controls.Add(this.tb);
            this.gbUI01.Controls.Add(this.lblUI02);
            this.gbUI01.Controls.Add(this.lblUI01);
            this.gbUI01.Location = new System.Drawing.Point(12, 12);
            this.gbUI01.Name = "gbUI01";
            this.gbUI01.Size = new System.Drawing.Size(560, 95);
            this.gbUI01.TabIndex = 0;
            this.gbUI01.TabStop = false;
            this.gbUI01.Text = "search";
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.PaleGreen;
            this.link.LinkColor = System.Drawing.Color.Black;
            this.link.Location = new System.Drawing.Point(12, 355);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(560, 47);
            this.link.TabIndex = 1;
            this.link.TabStop = true;
            this.link.Text = "### GOOGLE search url  ###";
            this.link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 126);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 214);
            this.dgv.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 5F;
            this.Column2.HeaderText = "title";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 2F;
            this.Column3.HeaderText = "year";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 2F;
            this.Column4.HeaderText = "genre";
            this.Column4.Name = "Column4";
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(16, 42);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(39, 21);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "title:";
            // 
            // lblUI02
            // 
            this.lblUI02.AutoSize = true;
            this.lblUI02.Location = new System.Drawing.Point(309, 42);
            this.lblUI02.Name = "lblUI02";
            this.lblUI02.Size = new System.Drawing.Size(53, 21);
            this.lblUI02.TabIndex = 0;
            this.lblUI02.Text = "genre:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(61, 39);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(226, 29);
            this.tb.TabIndex = 1;
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(368, 39);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(173, 29);
            this.cb.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.link);
            this.Controls.Add(this.gbUI01);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Best Video Games of All Time";
            this.gbUI01.ResumeLayout(false);
            this.gbUI01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbUI01;
        private ComboBox cb;
        private TextBox tb;
        private Label lblUI02;
        private Label lblUI01;
        private LinkLabel link;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}