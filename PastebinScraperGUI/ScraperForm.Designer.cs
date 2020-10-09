namespace PastebinScraperGUI
{
    partial class ScraperForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.btnOpenWeb = new System.Windows.Forms.Button();
            this.txtPageFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.pnlJsonSave = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJsonFilename = new System.Windows.Forms.TextBox();
            this.chkSaveToJson = new System.Windows.Forms.CheckBox();
            this.pnlPageRange = new System.Windows.Forms.Panel();
            this.txtPageTo = new System.Windows.Forms.TextBox();
            this.pnlStartFromPage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartPage = new System.Windows.Forms.TextBox();
            this.rbPageRange = new System.Windows.Forms.RadioButton();
            this.rbStartFrom = new System.Windows.Forms.RadioButton();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlCol = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.pnlJsonSave.SuspendLayout();
            this.pnlPageRange.SuspendLayout();
            this.pnlStartFromPage.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSearchTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchTerm.ForeColor = System.Drawing.Color.White;
            this.txtSearchTerm.Location = new System.Drawing.Point(62, 12);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(726, 20);
            this.txtSearchTerm.TabIndex = 1;
            this.txtSearchTerm.TextChanged += new System.EventHandler(this.txtSearchTerm_TextChanged);
            this.txtSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchTerm_KeyDown);
            // 
            // btnOpenWeb
            // 
            this.btnOpenWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenWeb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOpenWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenWeb.ForeColor = System.Drawing.Color.White;
            this.btnOpenWeb.Location = new System.Drawing.Point(532, 14);
            this.btnOpenWeb.Name = "btnOpenWeb";
            this.btnOpenWeb.Size = new System.Drawing.Size(188, 23);
            this.btnOpenWeb.TabIndex = 2;
            this.btnOpenWeb.Text = "Open in Webrowser";
            this.btnOpenWeb.UseVisualStyleBackColor = true;
            this.btnOpenWeb.Click += new System.EventHandler(this.btnOpenWeb_Click);
            // 
            // txtPageFrom
            // 
            this.txtPageFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPageFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageFrom.ForeColor = System.Drawing.Color.White;
            this.txtPageFrom.Location = new System.Drawing.Point(70, 11);
            this.txtPageFrom.Name = "txtPageFrom";
            this.txtPageFrom.Size = new System.Drawing.Size(66, 20);
            this.txtPageFrom.TabIndex = 3;
            this.txtPageFrom.TextChanged += new System.EventHandler(this.txtPageFrom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Page From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Page To:";
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.btnLoadJson);
            this.gbOptions.Controls.Add(this.pnlJsonSave);
            this.gbOptions.Controls.Add(this.chkSaveToJson);
            this.gbOptions.Controls.Add(this.pnlPageRange);
            this.gbOptions.Controls.Add(this.pnlStartFromPage);
            this.gbOptions.Controls.Add(this.rbPageRange);
            this.gbOptions.Controls.Add(this.rbStartFrom);
            this.gbOptions.Controls.Add(this.btnOpenWeb);
            this.gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(62, 38);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(726, 116);
            this.gbOptions.TabIndex = 7;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // pnlJsonSave
            // 
            this.pnlJsonSave.Controls.Add(this.label5);
            this.pnlJsonSave.Controls.Add(this.txtJsonFilename);
            this.pnlJsonSave.Location = new System.Drawing.Point(301, 42);
            this.pnlJsonSave.Name = "pnlJsonSave";
            this.pnlJsonSave.Size = new System.Drawing.Size(144, 65);
            this.pnlJsonSave.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filename:";
            // 
            // txtJsonFilename
            // 
            this.txtJsonFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJsonFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtJsonFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJsonFilename.ForeColor = System.Drawing.Color.White;
            this.txtJsonFilename.Location = new System.Drawing.Point(6, 27);
            this.txtJsonFilename.Name = "txtJsonFilename";
            this.txtJsonFilename.Size = new System.Drawing.Size(135, 20);
            this.txtJsonFilename.TabIndex = 5;
            this.txtJsonFilename.TextChanged += new System.EventHandler(this.txtJsonFilename_TextChanged);
            // 
            // chkSaveToJson
            // 
            this.chkSaveToJson.AutoSize = true;
            this.chkSaveToJson.Checked = true;
            this.chkSaveToJson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveToJson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkSaveToJson.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkSaveToJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSaveToJson.Location = new System.Drawing.Point(301, 18);
            this.chkSaveToJson.Name = "chkSaveToJson";
            this.chkSaveToJson.Size = new System.Drawing.Size(85, 17);
            this.chkSaveToJson.TabIndex = 12;
            this.chkSaveToJson.Text = "Save to Json";
            this.chkSaveToJson.UseVisualStyleBackColor = true;
            this.chkSaveToJson.CheckedChanged += new System.EventHandler(this.JsonCheckboxChanged);
            // 
            // pnlPageRange
            // 
            this.pnlPageRange.Controls.Add(this.label2);
            this.pnlPageRange.Controls.Add(this.txtPageFrom);
            this.pnlPageRange.Controls.Add(this.label3);
            this.pnlPageRange.Controls.Add(this.txtPageTo);
            this.pnlPageRange.Location = new System.Drawing.Point(156, 42);
            this.pnlPageRange.Name = "pnlPageRange";
            this.pnlPageRange.Size = new System.Drawing.Size(139, 65);
            this.pnlPageRange.TabIndex = 11;
            // 
            // txtPageTo
            // 
            this.txtPageTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPageTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageTo.ForeColor = System.Drawing.Color.White;
            this.txtPageTo.Location = new System.Drawing.Point(70, 37);
            this.txtPageTo.Name = "txtPageTo";
            this.txtPageTo.Size = new System.Drawing.Size(66, 20);
            this.txtPageTo.TabIndex = 7;
            this.txtPageTo.TextChanged += new System.EventHandler(this.txtPageTo_TextChanged);
            // 
            // pnlStartFromPage
            // 
            this.pnlStartFromPage.Controls.Add(this.label4);
            this.pnlStartFromPage.Controls.Add(this.txtStartPage);
            this.pnlStartFromPage.Location = new System.Drawing.Point(6, 42);
            this.pnlStartFromPage.Name = "pnlStartFromPage";
            this.pnlStartFromPage.Size = new System.Drawing.Size(144, 65);
            this.pnlStartFromPage.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Page From:";
            // 
            // txtStartPage
            // 
            this.txtStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtStartPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartPage.ForeColor = System.Drawing.Color.White;
            this.txtStartPage.Location = new System.Drawing.Point(70, 9);
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(66, 20);
            this.txtStartPage.TabIndex = 5;
            this.txtStartPage.TextChanged += new System.EventHandler(this.txtStartPage_TextChanged);
            // 
            // rbPageRange
            // 
            this.rbPageRange.AutoSize = true;
            this.rbPageRange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rbPageRange.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbPageRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPageRange.Location = new System.Drawing.Point(156, 19);
            this.rbPageRange.Name = "rbPageRange";
            this.rbPageRange.Size = new System.Drawing.Size(79, 17);
            this.rbPageRange.TabIndex = 9;
            this.rbPageRange.TabStop = true;
            this.rbPageRange.Text = "Page range";
            this.rbPageRange.UseVisualStyleBackColor = true;
            this.rbPageRange.CheckedChanged += new System.EventHandler(this.HandleRadioButtonChange);
            // 
            // rbStartFrom
            // 
            this.rbStartFrom.AutoSize = true;
            this.rbStartFrom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rbStartFrom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbStartFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbStartFrom.Location = new System.Drawing.Point(6, 20);
            this.rbStartFrom.Name = "rbStartFrom";
            this.rbStartFrom.Size = new System.Drawing.Size(96, 17);
            this.rbStartFrom.TabIndex = 8;
            this.rbStartFrom.TabStop = true;
            this.rbStartFrom.Text = "Start from page";
            this.rbStartFrom.UseVisualStyleBackColor = true;
            this.rbStartFrom.CheckedChanged += new System.EventHandler(this.HandleRadioButtonChange);
            // 
            // pnlResults
            // 
            this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResults.Controls.Add(this.btnSaveOutput);
            this.pnlResults.Controls.Add(this.dgvResults);
            this.pnlResults.Location = new System.Drawing.Point(12, 160);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(776, 278);
            this.pnlResults.TabIndex = 8;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSaveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOutput.ForeColor = System.Drawing.Color.White;
            this.btnSaveOutput.Location = new System.Drawing.Point(732, 252);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(44, 23);
            this.btnSaveOutput.TabIndex = 13;
            this.btnSaveOutput.Text = "Save";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.titleCol,
            this.urlCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.Size = new System.Drawing.Size(776, 278);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.HeaderText = "ID";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 41;
            // 
            // titleCol
            // 
            this.titleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleCol.HeaderText = "Title";
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            // 
            // urlCol
            // 
            this.urlCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urlCol.HeaderText = "Url";
            this.urlCol.LinkColor = System.Drawing.Color.SteelBlue;
            this.urlCol.Name = "urlCol";
            this.urlCol.ReadOnly = true;
            this.urlCol.VisitedLinkColor = System.Drawing.Color.LightSeaGreen;
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadJson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnLoadJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadJson.ForeColor = System.Drawing.Color.White;
            this.btnLoadJson.Location = new System.Drawing.Point(651, 84);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(69, 23);
            this.btnLoadJson.TabIndex = 13;
            this.btnLoadJson.Text = "Load Json";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // ScraperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.label1);
            this.Name = "ScraperForm";
            this.ShowIcon = false;
            this.Text = "Pastebin Scraper";
            this.Load += new System.EventHandler(this.ScraperForm_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.pnlJsonSave.ResumeLayout(false);
            this.pnlJsonSave.PerformLayout();
            this.pnlPageRange.ResumeLayout(false);
            this.pnlPageRange.PerformLayout();
            this.pnlStartFromPage.ResumeLayout(false);
            this.pnlStartFromPage.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnOpenWeb;
        private System.Windows.Forms.TextBox txtPageFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TextBox txtPageTo;
        private System.Windows.Forms.RadioButton rbPageRange;
        private System.Windows.Forms.RadioButton rbStartFrom;
        private System.Windows.Forms.Panel pnlPageRange;
        private System.Windows.Forms.Panel pnlStartFromPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartPage;
        private System.Windows.Forms.Panel pnlJsonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJsonFilename;
        private System.Windows.Forms.CheckBox chkSaveToJson;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewLinkColumn urlCol;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.Button btnLoadJson;
    }
}

