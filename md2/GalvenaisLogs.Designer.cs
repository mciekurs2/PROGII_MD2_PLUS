namespace md2
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.valstsKods = new System.Windows.Forms.Label();
            this.pilsetaComboBox = new System.Windows.Forms.ComboBox();
            this.grafiskiButton = new System.Windows.Forms.Button();
            this.apstiprinatButton = new System.Windows.Forms.Button();
            this.pilsetaLabel = new System.Windows.Forms.Label();
            this.valstsLabel = new System.Windows.Forms.Label();
            this.nedelasTempGridView = new System.Windows.Forms.DataGridView();
            this.currentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nedelasTempGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // fileExitMenu
            // 
            this.fileExitMenu.Name = "fileExitMenu";
            this.fileExitMenu.Size = new System.Drawing.Size(92, 22);
            this.fileExitMenu.Text = "Exit";
            this.fileExitMenu.Click += new System.EventHandler(this.fileExitMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // helpAboutMenu
            // 
            this.helpAboutMenu.Name = "helpAboutMenu";
            this.helpAboutMenu.Size = new System.Drawing.Size(107, 22);
            this.helpAboutMenu.Text = "About";
            this.helpAboutMenu.Click += new System.EventHandler(this.HelpAboutMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.valstsKods);
            this.splitContainer1.Panel1.Controls.Add(this.pilsetaComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.grafiskiButton);
            this.splitContainer1.Panel1.Controls.Add(this.apstiprinatButton);
            this.splitContainer1.Panel1.Controls.Add(this.pilsetaLabel);
            this.splitContainer1.Panel1.Controls.Add(this.valstsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nedelasTempGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(976, 426);
            this.splitContainer1.SplitterDistance = 645;
            this.splitContainer1.TabIndex = 1;
            // 
            // valstsKods
            // 
            this.valstsKods.AutoSize = true;
            this.valstsKods.Location = new System.Drawing.Point(64, 401);
            this.valstsKods.Name = "valstsKods";
            this.valstsKods.Size = new System.Drawing.Size(54, 13);
            this.valstsKods.TabIndex = 14;
            this.valstsKods.Text = "\'temp text\'";
            // 
            // pilsetaComboBox
            // 
            this.pilsetaComboBox.FormattingEnabled = true;
            this.pilsetaComboBox.Location = new System.Drawing.Point(184, 397);
            this.pilsetaComboBox.Name = "pilsetaComboBox";
            this.pilsetaComboBox.Size = new System.Drawing.Size(121, 21);
            this.pilsetaComboBox.TabIndex = 13;
            // 
            // grafiskiButton
            // 
            this.grafiskiButton.Location = new System.Drawing.Point(511, 395);
            this.grafiskiButton.Name = "grafiskiButton";
            this.grafiskiButton.Size = new System.Drawing.Size(131, 23);
            this.grafiskiButton.TabIndex = 11;
            this.grafiskiButton.Text = "Show graph";
            this.grafiskiButton.UseVisualStyleBackColor = true;
            this.grafiskiButton.Click += new System.EventHandler(this.GrafiskiButton_Click);
            // 
            // apstiprinatButton
            // 
            this.apstiprinatButton.Location = new System.Drawing.Point(427, 395);
            this.apstiprinatButton.Name = "apstiprinatButton";
            this.apstiprinatButton.Size = new System.Drawing.Size(75, 23);
            this.apstiprinatButton.TabIndex = 12;
            this.apstiprinatButton.Text = "Confirm";
            this.apstiprinatButton.UseVisualStyleBackColor = true;
            this.apstiprinatButton.Click += new System.EventHandler(this.ApstiprinatButton_Click);
            // 
            // pilsetaLabel
            // 
            this.pilsetaLabel.AutoSize = true;
            this.pilsetaLabel.Location = new System.Drawing.Point(151, 401);
            this.pilsetaLabel.Name = "pilsetaLabel";
            this.pilsetaLabel.Size = new System.Drawing.Size(27, 13);
            this.pilsetaLabel.TabIndex = 9;
            this.pilsetaLabel.Text = "City:";
            // 
            // valstsLabel
            // 
            this.valstsLabel.AutoSize = true;
            this.valstsLabel.Location = new System.Drawing.Point(12, 401);
            this.valstsLabel.Name = "valstsLabel";
            this.valstsLabel.Size = new System.Drawing.Size(46, 13);
            this.valstsLabel.TabIndex = 10;
            this.valstsLabel.Text = "Country:";
            // 
            // nedelasTempGridView
            // 
            this.nedelasTempGridView.AllowUserToDeleteRows = false;
            this.nedelasTempGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nedelasTempGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentTime,
            this.temp,
            this.wDesc,
            this.humidity,
            this.wind});
            this.nedelasTempGridView.Location = new System.Drawing.Point(3, 0);
            this.nedelasTempGridView.Name = "nedelasTempGridView";
            this.nedelasTempGridView.ReadOnly = true;
            this.nedelasTempGridView.Size = new System.Drawing.Size(639, 390);
            this.nedelasTempGridView.TabIndex = 8;
            // 
            // currentTime
            // 
            this.currentTime.HeaderText = "Time";
            this.currentTime.Name = "currentTime";
            this.currentTime.ReadOnly = true;
            // 
            // temp
            // 
            this.temp.HeaderText = "Temp";
            this.temp.Name = "temp";
            this.temp.ReadOnly = true;
            // 
            // wDesc
            // 
            this.wDesc.HeaderText = "Desc";
            this.wDesc.Name = "wDesc";
            this.wDesc.ReadOnly = true;
            // 
            // humidity
            // 
            this.humidity.HeaderText = "Humidity";
            this.humidity.Name = "humidity";
            this.humidity.ReadOnly = true;
            // 
            // wind
            // 
            this.wind.HeaderText = "Wind";
            this.wind.Name = "wind";
            this.wind.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 390);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Laikapstākļu plānotājs";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nedelasTempGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpAboutMenu;
        private System.Windows.Forms.BindingSource weatherDataBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label valstsKods;
        private System.Windows.Forms.ComboBox pilsetaComboBox;
        private System.Windows.Forms.Button grafiskiButton;
        private System.Windows.Forms.Button apstiprinatButton;
        private System.Windows.Forms.Label pilsetaLabel;
        private System.Windows.Forms.Label valstsLabel;
        private System.Windows.Forms.DataGridView nedelasTempGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn wind;
        private System.Windows.Forms.ListView listView1;
    }
}

