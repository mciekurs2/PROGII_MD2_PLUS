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
            this.valstsTextBox = new System.Windows.Forms.TextBox();
            this.pilsetaTextBox = new System.Windows.Forms.TextBox();
            this.valstsLabel = new System.Windows.Forms.Label();
            this.pilsetaLabel = new System.Windows.Forms.Label();
            this.apstiprinatButton = new System.Windows.Forms.Button();
            this.grafiskiButton = new System.Windows.Forms.Button();
            this.weatherDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.fileExitMenu.Size = new System.Drawing.Size(92, 22);
            this.fileExitMenu.Text = "Exit";
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
            this.nedelasTempGridView.AllowUserToOrderColumns = true;
            this.nedelasTempGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nedelasTempGridView.Location = new System.Drawing.Point(0, 27);
            this.nedelasTempGridView.Name = "nedelasTempGridView";
            this.nedelasTempGridView.Size = new System.Drawing.Size(743, 378);
            this.nedelasTempGridView.TabIndex = 1;
            // 
            // valstsTextBox
            // 
            this.valstsTextBox.Location = new System.Drawing.Point(56, 418);
            this.valstsTextBox.Name = "valstsTextBox";
            this.valstsTextBox.Size = new System.Drawing.Size(132, 20);
            this.valstsTextBox.TabIndex = 2;
            // 
            // pilsetaTextBox
            // 
            this.pilsetaTextBox.Location = new System.Drawing.Point(271, 418);
            this.pilsetaTextBox.Name = "pilsetaTextBox";
            this.pilsetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pilsetaTextBox.TabIndex = 3;
            // 
            // valstsLabel
            // 
            this.valstsLabel.AutoSize = true;
            this.valstsLabel.Location = new System.Drawing.Point(12, 421);
            this.valstsLabel.Name = "valstsLabel";
            this.valstsLabel.Size = new System.Drawing.Size(38, 13);
            this.valstsLabel.TabIndex = 4;
            this.valstsLabel.Text = "Valsts:";
            // 
            // pilsetaLabel
            // 
            this.pilsetaLabel.AutoSize = true;
            this.pilsetaLabel.Location = new System.Drawing.Point(224, 421);
            this.pilsetaLabel.Name = "pilsetaLabel";
            this.pilsetaLabel.Size = new System.Drawing.Size(41, 13);
            this.pilsetaLabel.TabIndex = 4;
            this.pilsetaLabel.Text = "Pilsēta:";
            // 
            // apstiprinatButton
            // 
            this.apstiprinatButton.Location = new System.Drawing.Point(510, 416);
            this.apstiprinatButton.Name = "apstiprinatButton";
            this.apstiprinatButton.Size = new System.Drawing.Size(75, 23);
            this.apstiprinatButton.TabIndex = 5;
            this.apstiprinatButton.Text = "Apstiprinat";
            this.apstiprinatButton.UseVisualStyleBackColor = true;
            this.apstiprinatButton.Click += new System.EventHandler(this.ApstiprinatButton_Click);
            // 
            // grafiskiButton
            // 
            this.grafiskiButton.Location = new System.Drawing.Point(600, 416);
            this.grafiskiButton.Name = "grafiskiButton";
            this.grafiskiButton.Size = new System.Drawing.Size(131, 23);
            this.grafiskiButton.TabIndex = 5;
            this.grafiskiButton.Text = "Parādīt grafiski";
            this.grafiskiButton.UseVisualStyleBackColor = true;
            this.grafiskiButton.Click += new System.EventHandler(this.GrafiskiButton_Click);
            // 
            // weatherDataBindingSource
            // 
            this.weatherDataBindingSource.DataSource = typeof(md2.WeatherData);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.grafiskiButton);
            this.Controls.Add(this.apstiprinatButton);
            this.Controls.Add(this.pilsetaLabel);
            this.Controls.Add(this.valstsLabel);
            this.Controls.Add(this.pilsetaTextBox);
            this.Controls.Add(this.valstsTextBox);
            this.Controls.Add(this.nedelasTempGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Laikapstākļu plānotājs";
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
        private System.Windows.Forms.TextBox valstsTextBox;
        private System.Windows.Forms.TextBox pilsetaTextBox;
        private System.Windows.Forms.Label valstsLabel;
        private System.Windows.Forms.Label pilsetaLabel;
        private System.Windows.Forms.Button apstiprinatButton;
        private System.Windows.Forms.Button grafiskiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource weatherDataBindingSource;
    }
}

