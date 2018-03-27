namespace md2
{
    partial class AboutLogs
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
            this.nosaukumsLabel = new System.Windows.Forms.Label();
            this.veidotajsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nosaukumsLabel
            // 
            this.nosaukumsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nosaukumsLabel.AutoSize = true;
            this.nosaukumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosaukumsLabel.Location = new System.Drawing.Point(39, 71);
            this.nosaukumsLabel.Name = "nosaukumsLabel";
            this.nosaukumsLabel.Padding = new System.Windows.Forms.Padding(10);
            this.nosaukumsLabel.Size = new System.Drawing.Size(203, 40);
            this.nosaukumsLabel.TabIndex = 0;
            this.nosaukumsLabel.Text = "Laikapstākļu programma";
            // 
            // veidotajsLabel
            // 
            this.veidotajsLabel.AutoSize = true;
            this.veidotajsLabel.Location = new System.Drawing.Point(76, 172);
            this.veidotajsLabel.Name = "veidotajsLabel";
            this.veidotajsLabel.Size = new System.Drawing.Size(120, 13);
            this.veidotajsLabel.TabIndex = 1;
            this.veidotajsLabel.Text = "Veidoja: Mārtiņš Ciekurs";
            // 
            // AboutLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 194);
            this.Controls.Add(this.veidotajsLabel);
            this.Controls.Add(this.nosaukumsLabel);
            this.Name = "AboutLogs";
            this.Text = "AboutLogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nosaukumsLabel;
        private System.Windows.Forms.Label veidotajsLabel;
    }
}