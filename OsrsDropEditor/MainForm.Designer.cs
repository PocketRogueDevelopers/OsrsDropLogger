﻿namespace OsrsDropEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.npcNameTextBox = new System.Windows.Forms.TextBox();
            this.npcNameLabel = new System.Windows.Forms.Label();
            this.npcListGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npcNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dropsPanel = new System.Windows.Forms.Panel();
            this.dropsListView = new System.Windows.Forms.ListView();
            this.userInteractionPanel = new System.Windows.Forms.Panel();
            this.loggedDropView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggedDropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.starButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopwatchUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcNameBindingSource)).BeginInit();
            this.dropsPanel.SuspendLayout();
            this.userInteractionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loggedDropView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedDropBindingSource)).BeginInit();
            this.buttonTableLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.npcNameTextBox);
            this.panel1.Controls.Add(this.npcNameLabel);
            this.panel1.Controls.Add(this.npcListGridView);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 343);
            this.panel1.TabIndex = 1;
            // 
            // npcNameTextBox
            // 
            this.npcNameTextBox.Location = new System.Drawing.Point(69, 0);
            this.npcNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.npcNameTextBox.Name = "npcNameTextBox";
            this.npcNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.npcNameTextBox.TabIndex = 3;
            // 
            // npcNameLabel
            // 
            this.npcNameLabel.Location = new System.Drawing.Point(6, 0);
            this.npcNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.npcNameLabel.Name = "npcNameLabel";
            this.npcNameLabel.Size = new System.Drawing.Size(65, 20);
            this.npcNameLabel.TabIndex = 2;
            this.npcNameLabel.Text = "NPC Name:";
            // 
            // npcListGridView
            // 
            this.npcListGridView.AllowUserToAddRows = false;
            this.npcListGridView.AllowUserToResizeRows = false;
            this.npcListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.npcListGridView.AutoGenerateColumns = false;
            this.npcListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.npcListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.npcListGridView.DataSource = this.npcNameBindingSource;
            this.npcListGridView.Location = new System.Drawing.Point(0, 22);
            this.npcListGridView.Margin = new System.Windows.Forms.Padding(1);
            this.npcListGridView.MultiSelect = false;
            this.npcListGridView.Name = "npcListGridView";
            this.npcListGridView.RowHeadersVisible = false;
            this.npcListGridView.RowTemplate.Height = 37;
            this.npcListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.npcListGridView.Size = new System.Drawing.Size(207, 321);
            this.npcListGridView.TabIndex = 1;
            this.npcListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.npcListGridView_CellMouseDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NPC Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // npcNameBindingSource
            // 
            this.npcNameBindingSource.DataSource = typeof(OsrsDropEditor.NpcName);
            // 
            // dropsPanel
            // 
            this.dropsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropsPanel.Controls.Add(this.dropsListView);
            this.dropsPanel.Location = new System.Drawing.Point(210, 25);
            this.dropsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.dropsPanel.Name = "dropsPanel";
            this.dropsPanel.Size = new System.Drawing.Size(270, 343);
            this.dropsPanel.TabIndex = 2;
            // 
            // dropsListView
            // 
            this.dropsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.dropsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropsListView.Location = new System.Drawing.Point(0, 0);
            this.dropsListView.Margin = new System.Windows.Forms.Padding(1);
            this.dropsListView.Name = "dropsListView";
            this.dropsListView.Size = new System.Drawing.Size(270, 343);
            this.dropsListView.TabIndex = 0;
            this.dropsListView.UseCompatibleStateImageBehavior = false;
            this.dropsListView.ItemActivate += new System.EventHandler(this.dropsListView_ItemActivate);
            // 
            // userInteractionPanel
            // 
            this.userInteractionPanel.Controls.Add(this.loggedDropView);
            this.userInteractionPanel.Controls.Add(this.totalValueLabel);
            this.userInteractionPanel.Controls.Add(this.buttonTableLayoutPanel);
            this.userInteractionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInteractionPanel.Location = new System.Drawing.Point(483, 24);
            this.userInteractionPanel.Margin = new System.Windows.Forms.Padding(1);
            this.userInteractionPanel.Name = "userInteractionPanel";
            this.userInteractionPanel.Size = new System.Drawing.Size(191, 344);
            this.userInteractionPanel.TabIndex = 3;
            // 
            // loggedDropView
            // 
            this.loggedDropView.AllowUserToAddRows = false;
            this.loggedDropView.AllowUserToResizeRows = false;
            this.loggedDropView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedDropView.AutoGenerateColumns = false;
            this.loggedDropView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedDropView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.loggedDropView.DataSource = this.loggedDropBindingSource;
            this.loggedDropView.Location = new System.Drawing.Point(0, 0);
            this.loggedDropView.Name = "loggedDropView";
            this.loggedDropView.ReadOnly = true;
            this.loggedDropView.RowHeadersVisible = false;
            this.loggedDropView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loggedDropView.Size = new System.Drawing.Size(192, 295);
            this.loggedDropView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "DisplayName";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Drop";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 75F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.FillWeight = 75F;
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loggedDropBindingSource
            // 
            this.loggedDropBindingSource.DataSource = typeof(OsrsDropEditor.LoggedDrop);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalValueLabel.Location = new System.Drawing.Point(3, 298);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(185, 16);
            this.totalValueLabel.TabIndex = 1;
            this.totalValueLabel.Text = "Total Value: ";
            // 
            // buttonTableLayoutPanel
            // 
            this.buttonTableLayoutPanel.ColumnCount = 3;
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.buttonTableLayoutPanel.Controls.Add(this.starButton, 0, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.pauseButton, 1, 0);
            this.buttonTableLayoutPanel.Controls.Add(this.resetButton, 2, 0);
            this.buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTableLayoutPanel.Location = new System.Drawing.Point(0, 317);
            this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            this.buttonTableLayoutPanel.RowCount = 1;
            this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTableLayoutPanel.Size = new System.Drawing.Size(191, 27);
            this.buttonTableLayoutPanel.TabIndex = 0;
            // 
            // starButton
            // 
            this.starButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.starButton.Location = new System.Drawing.Point(0, 0);
            this.starButton.Margin = new System.Windows.Forms.Padding(0);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(63, 27);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "Start";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pauseButton.Location = new System.Drawing.Point(63, 0);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(63, 27);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(126, 0);
            this.resetButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(65, 27);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // stopwatchUpdateTimer
            // 
            this.stopwatchUpdateTimer.Interval = 250;
            this.stopwatchUpdateTimer.Tick += new System.EventHandler(this.stopwatchUpdateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 368);
            this.Controls.Add(this.userInteractionPanel);
            this.Controls.Add(this.dropsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "OSRS Drop Logger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npcListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcNameBindingSource)).EndInit();
            this.dropsPanel.ResumeLayout(false);
            this.userInteractionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loggedDropView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedDropBindingSource)).EndInit();
            this.buttonTableLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource npcNameBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView npcListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label npcNameLabel;
        private System.Windows.Forms.TextBox npcNameTextBox;
        private System.Windows.Forms.Panel dropsPanel;
        private System.Windows.Forms.Panel userInteractionPanel;
        private System.Windows.Forms.ListView dropsListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resetButton;
        public System.Windows.Forms.DataGridView loggedDropView;
        public System.Windows.Forms.BindingSource loggedDropBindingSource;
        public System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer stopwatchUpdateTimer;
    }
}

