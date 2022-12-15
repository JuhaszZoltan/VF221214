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
            this.cb = new System.Windows.Forms.ComboBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.lblUI02 = new System.Windows.Forms.Label();
            this.lblUI01 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgvClm01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClm02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClm03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClm04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbUI01.Size = new System.Drawing.Size(560, 76);
            this.gbUI01.TabIndex = 0;
            this.gbUI01.TabStop = false;
            this.gbUI01.Text = "search";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(366, 28);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(173, 29);
            this.cb.TabIndex = 1;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(59, 28);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(226, 29);
            this.tb.TabIndex = 0;
            // 
            // lblUI02
            // 
            this.lblUI02.AutoSize = true;
            this.lblUI02.Location = new System.Drawing.Point(307, 31);
            this.lblUI02.Name = "lblUI02";
            this.lblUI02.Size = new System.Drawing.Size(53, 21);
            this.lblUI02.TabIndex = 0;
            this.lblUI02.Text = "genre:";
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(14, 31);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(39, 21);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "title:";
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.Color.PaleGreen;
            this.link.LinkColor = System.Drawing.Color.Black;
            this.link.Location = new System.Drawing.Point(12, 355);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(560, 47);
            this.link.TabIndex = 3;
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
            this.dgvClm01,
            this.dgvClm02,
            this.dgvClm03,
            this.dgvClm04});
            this.dgv.Location = new System.Drawing.Point(12, 108);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(560, 232);
            this.dgv.TabIndex = 2;
            // 
            // dgvClm01
            // 
            this.dgvClm01.FillWeight = 1F;
            this.dgvClm01.HeaderText = "ID";
            this.dgvClm01.Name = "dgvClm01";
            // 
            // dgvClm02
            // 
            this.dgvClm02.FillWeight = 5F;
            this.dgvClm02.HeaderText = "title";
            this.dgvClm02.Name = "dgvClm02";
            // 
            // dgvClm03
            // 
            this.dgvClm03.FillWeight = 2F;
            this.dgvClm03.HeaderText = "year";
            this.dgvClm03.Name = "dgvClm03";
            // 
            // dgvClm04
            // 
            this.dgvClm04.FillWeight = 2F;
            this.dgvClm04.HeaderText = "genre";
            this.dgvClm04.Name = "dgvClm04";
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DataGridViewTextBoxColumn dgvClm01;
        private DataGridViewTextBoxColumn dgvClm02;
        private DataGridViewTextBoxColumn dgvClm03;
        private DataGridViewTextBoxColumn dgvClm04;
    }
}