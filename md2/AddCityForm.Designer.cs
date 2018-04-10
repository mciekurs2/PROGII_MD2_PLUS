namespace md2
{
    partial class AddCity
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
            this.texBoxFavorite = new System.Windows.Forms.TextBox();
            this.labelInfoFavorite = new System.Windows.Forms.Label();
            this.confirmButtonFavorite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texBoxFavorite
            // 
            this.texBoxFavorite.Location = new System.Drawing.Point(21, 40);
            this.texBoxFavorite.Name = "texBoxFavorite";
            this.texBoxFavorite.Size = new System.Drawing.Size(100, 20);
            this.texBoxFavorite.TabIndex = 0;
            // 
            // labelInfoFavorite
            // 
            this.labelInfoFavorite.AutoSize = true;
            this.labelInfoFavorite.Location = new System.Drawing.Point(18, 9);
            this.labelInfoFavorite.Name = "labelInfoFavorite";
            this.labelInfoFavorite.Size = new System.Drawing.Size(196, 13);
            this.labelInfoFavorite.TabIndex = 1;
            this.labelInfoFavorite.Text = "Enter city name to add to FAVORITE list";
            // 
            // confirmButtonFavorite
            // 
            this.confirmButtonFavorite.Location = new System.Drawing.Point(139, 38);
            this.confirmButtonFavorite.Name = "confirmButtonFavorite";
            this.confirmButtonFavorite.Size = new System.Drawing.Size(75, 23);
            this.confirmButtonFavorite.TabIndex = 2;
            this.confirmButtonFavorite.Text = "Confirm";
            this.confirmButtonFavorite.UseVisualStyleBackColor = true;
            this.confirmButtonFavorite.Click += new System.EventHandler(this.ConfirmButtonFavorite_Click);
            // 
            // Add_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 83);
            this.Controls.Add(this.confirmButtonFavorite);
            this.Controls.Add(this.labelInfoFavorite);
            this.Controls.Add(this.texBoxFavorite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texBoxFavorite;
        private System.Windows.Forms.Label labelInfoFavorite;
        private System.Windows.Forms.Button confirmButtonFavorite;
    }
}