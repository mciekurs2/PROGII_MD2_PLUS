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
            this.nedelasTempGridView = new System.Windows.Forms.DataGridView();
            this.currentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valstsLabel = new System.Windows.Forms.Label();
            this.pilsetaLabel = new System.Windows.Forms.Label();
            this.apstiprinatButton = new System.Windows.Forms.Button();
            this.grafiskiButton = new System.Windows.Forms.Button();
            this.weatherDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilsetaComboBox = new System.Windows.Forms.ComboBox();
            this.valstsKods = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nedelasTempGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
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
            this.fileExitMenu.Size = new System.Drawing.Size(180, 22);
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
            this.nedelasTempGridView.Location = new System.Drawing.Point(0, 27);
            this.nedelasTempGridView.Name = "nedelasTempGridView";
            this.nedelasTempGridView.Size = new System.Drawing.Size(743, 378);
            this.nedelasTempGridView.TabIndex = 1;
            // 
            // currentTime
            // 
            this.currentTime.HeaderText = "Time";
            this.currentTime.Name = "currentTime";
            // 
            // temp
            // 
            this.temp.HeaderText = "Temp";
            this.temp.Name = "temp";
            // 
            // wDesc
            // 
            this.wDesc.HeaderText = "Desc";
            this.wDesc.Name = "wDesc";
            // 
            // humidity
            // 
            this.humidity.HeaderText = "Humidity";
            this.humidity.Name = "humidity";
            // 
            // wind
            // 
            this.wind.HeaderText = "Wind";
            this.wind.Name = "wind";
            // 
            // valstsLabel
            // 
            this.valstsLabel.AutoSize = true;
            this.valstsLabel.Location = new System.Drawing.Point(12, 421);
            this.valstsLabel.Name = "valstsLabel";
            this.valstsLabel.Size = new System.Drawing.Size(46, 13);
            this.valstsLabel.TabIndex = 4;
            this.valstsLabel.Text = "Country:";
            // 
            // pilsetaLabel
            // 
            this.pilsetaLabel.AutoSize = true;
            this.pilsetaLabel.Location = new System.Drawing.Point(129, 421);
            this.pilsetaLabel.Name = "pilsetaLabel";
            this.pilsetaLabel.Size = new System.Drawing.Size(27, 13);
            this.pilsetaLabel.TabIndex = 4;
            this.pilsetaLabel.Text = "City:";
            // 
            // apstiprinatButton
            // 
            this.apstiprinatButton.Location = new System.Drawing.Point(509, 415);
            this.apstiprinatButton.Name = "apstiprinatButton";
            this.apstiprinatButton.Size = new System.Drawing.Size(75, 23);
            this.apstiprinatButton.TabIndex = 5;
            this.apstiprinatButton.Text = "Confirm";
            this.apstiprinatButton.UseVisualStyleBackColor = true;
            this.apstiprinatButton.Click += new System.EventHandler(this.ApstiprinatButton_Click);
            // 
            // grafiskiButton
            // 
            this.grafiskiButton.Location = new System.Drawing.Point(600, 415);
            this.grafiskiButton.Name = "grafiskiButton";
            this.grafiskiButton.Size = new System.Drawing.Size(131, 23);
            this.grafiskiButton.TabIndex = 5;
            this.grafiskiButton.Text = "Show graph";
            this.grafiskiButton.UseVisualStyleBackColor = true;
            this.grafiskiButton.Click += new System.EventHandler(this.GrafiskiButton_Click);
            // 
            // pilsetaComboBox
            // 
            this.pilsetaComboBox.FormattingEnabled = true;
            this.pilsetaComboBox.Location = new System.Drawing.Point(162, 418);
            this.pilsetaComboBox.Name = "pilsetaComboBox";
            this.pilsetaComboBox.Size = new System.Drawing.Size(121, 21);
            this.pilsetaComboBox.TabIndex = 6;
            // 
            // valstsKods
            // 
            this.valstsKods.AutoSize = true;
            this.valstsKods.Location = new System.Drawing.Point(56, 421);
            this.valstsKods.Name = "valstsKods";
            this.valstsKods.Size = new System.Drawing.Size(54, 13);
            this.valstsKods.TabIndex = 7;
            this.valstsKods.Text = "\'temp text\'";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.valstsKods);
            this.Controls.Add(this.pilsetaComboBox);
            this.Controls.Add(this.grafiskiButton);
            this.Controls.Add(this.apstiprinatButton);
            this.Controls.Add(this.pilsetaLabel);
            this.Controls.Add(this.valstsLabel);
            this.Controls.Add(this.nedelasTempGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Laikapstākļu plānotājs";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nedelasTempGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExitMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpAboutMenu;
        private System.Windows.Forms.DataGridView nedelasTempGridView;
        private System.Windows.Forms.Label valstsLabel;
        private System.Windows.Forms.Label pilsetaLabel;
        private System.Windows.Forms.Button apstiprinatButton;
        private System.Windows.Forms.Button grafiskiButton;
        private System.Windows.Forms.BindingSource weatherDataBindingSource;
        private System.Windows.Forms.ComboBox pilsetaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn wind;
        private System.Windows.Forms.Label valstsKods;
    }
}

