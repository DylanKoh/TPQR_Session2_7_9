﻿namespace TPQR_Session2_7_9
{
    partial class BookSponsorship
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOnline = new System.Windows.Forms.CheckBox();
            this.cbFlyer = new System.Windows.Forms.CheckBox();
            this.cbBanner = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 47);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(711, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 59);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By Tier: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By Budget: ";
            // 
            // cbTier
            // 
            this.cbTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier.FormattingEnabled = true;
            this.cbTier.Location = new System.Drawing.Point(373, 160);
            this.cbTier.Name = "cbTier";
            this.cbTier.Size = new System.Drawing.Size(190, 33);
            this.cbTier.TabIndex = 7;
            this.cbTier.SelectedIndexChanged += new System.EventHandler(this.cbTier_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter By Benefits: ";
            // 
            // cbOnline
            // 
            this.cbOnline.AutoSize = true;
            this.cbOnline.Location = new System.Drawing.Point(373, 256);
            this.cbOnline.Name = "cbOnline";
            this.cbOnline.Size = new System.Drawing.Size(100, 29);
            this.cbOnline.TabIndex = 10;
            this.cbOnline.Text = "Online";
            this.cbOnline.UseVisualStyleBackColor = true;
            this.cbOnline.CheckedChanged += new System.EventHandler(this.cbOnline_CheckedChanged);
            // 
            // cbFlyer
            // 
            this.cbFlyer.AutoSize = true;
            this.cbFlyer.Location = new System.Drawing.Point(479, 256);
            this.cbFlyer.Name = "cbFlyer";
            this.cbFlyer.Size = new System.Drawing.Size(85, 29);
            this.cbFlyer.TabIndex = 11;
            this.cbFlyer.Text = "Flyer";
            this.cbFlyer.UseVisualStyleBackColor = true;
            this.cbFlyer.CheckedChanged += new System.EventHandler(this.cbFlyer_CheckedChanged);
            // 
            // cbBanner
            // 
            this.cbBanner.AutoSize = true;
            this.cbBanner.Location = new System.Drawing.Point(570, 256);
            this.cbBanner.Name = "cbBanner";
            this.cbBanner.Size = new System.Drawing.Size(107, 29);
            this.cbBanner.TabIndex = 12;
            this.cbBanner.Text = "Banner";
            this.cbBanner.UseVisualStyleBackColor = true;
            this.cbBanner.CheckedChanged += new System.EventHandler(this.cbBanner_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Desired Quantity: ";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(212, 601);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 32);
            this.nudQuantity.TabIndex = 15;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(850, 597);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(92, 37);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F);
            this.label6.Location = new System.Drawing.Point(324, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Book Sponsorship Packages";
            // 
            // nudBudget
            // 
            this.nudBudget.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBudget.Location = new System.Drawing.Point(373, 210);
            this.nudBudget.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(120, 32);
            this.nudBudget.TabIndex = 18;
            this.nudBudget.ValueChanged += new System.EventHandler(this.nudBudget_ValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PackageID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tier";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value ($)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Available Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 161;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Online";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 107;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Flyer";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 92;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Banner";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 114;
            // 
            // BookSponsorship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 726);
            this.Controls.Add(this.nudBudget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbBanner);
            this.Controls.Add(this.cbFlyer);
            this.Controls.Add(this.cbOnline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BookSponsorship";
            this.Text = "Book Sponsorship";
            this.Load += new System.EventHandler(this.BookSponsorship_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbOnline;
        private System.Windows.Forms.CheckBox cbFlyer;
        private System.Windows.Forms.CheckBox cbBanner;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}