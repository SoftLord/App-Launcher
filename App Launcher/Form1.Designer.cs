namespace App_Launcher
{
    partial class AppLauncher
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLauncher));
            this.Tittle = new System.Windows.Forms.Label();
            this.ConchiButton = new System.Windows.Forms.Button();
            this.WordFinderButton = new System.Windows.Forms.Button();
            this.RaspiButton = new System.Windows.Forms.Button();
            this.MIXButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tittle.Font = new System.Drawing.Font("Victor Mono", 50F);
            this.Tittle.ForeColor = System.Drawing.Color.White;
            this.Tittle.Location = new System.Drawing.Point(0, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(984, 131);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "/App Launcher";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            // 
            // ConchiButton
            // 
            this.ConchiButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConchiButton.BackgroundImage = global::App_Launcher.Properties.Resources.conchi_logo;
            this.ConchiButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConchiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConchiButton.Location = new System.Drawing.Point(360, 399);
            this.ConchiButton.MaximumSize = new System.Drawing.Size(250, 250);
            this.ConchiButton.MinimumSize = new System.Drawing.Size(250, 250);
            this.ConchiButton.Name = "ConchiButton";
            this.ConchiButton.Size = new System.Drawing.Size(250, 250);
            this.ConchiButton.TabIndex = 4;
            this.ConchiButton.UseVisualStyleBackColor = true;
            this.ConchiButton.Click += new System.EventHandler(this.ConchiButton_Click);
            // 
            // WordFinderButton
            // 
            this.WordFinderButton.BackgroundImage = global::App_Launcher.Properties.Resources.word_finder_logo;
            this.WordFinderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.WordFinderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WordFinderButton.Location = new System.Drawing.Point(360, 134);
            this.WordFinderButton.MaximumSize = new System.Drawing.Size(250, 250);
            this.WordFinderButton.MinimumSize = new System.Drawing.Size(250, 250);
            this.WordFinderButton.Name = "WordFinderButton";
            this.WordFinderButton.Size = new System.Drawing.Size(250, 250);
            this.WordFinderButton.TabIndex = 3;
            this.WordFinderButton.UseVisualStyleBackColor = true;
            this.WordFinderButton.Click += new System.EventHandler(this.WordFinderButton_Click);
            // 
            // RaspiButton
            // 
            this.RaspiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RaspiButton.BackgroundImage = global::App_Launcher.Properties.Resources.raspiConnectionlogo;
            this.RaspiButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RaspiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RaspiButton.Location = new System.Drawing.Point(722, 134);
            this.RaspiButton.MaximumSize = new System.Drawing.Size(250, 250);
            this.RaspiButton.Name = "RaspiButton";
            this.RaspiButton.Size = new System.Drawing.Size(250, 250);
            this.RaspiButton.TabIndex = 2;
            this.RaspiButton.UseVisualStyleBackColor = true;
            this.RaspiButton.Click += new System.EventHandler(this.RaspiButton_Click);
            // 
            // MIXButton
            // 
            this.MIXButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MIXButton.BackgroundImage = global::App_Launcher.Properties.Resources.MIX_logo;
            this.MIXButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MIXButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MIXButton.Location = new System.Drawing.Point(12, 134);
            this.MIXButton.MaximumSize = new System.Drawing.Size(250, 250);
            this.MIXButton.MinimumSize = new System.Drawing.Size(250, 250);
            this.MIXButton.Name = "MIXButton";
            this.MIXButton.Size = new System.Drawing.Size(250, 250);
            this.MIXButton.TabIndex = 1;
            this.MIXButton.UseVisualStyleBackColor = true;
            this.MIXButton.Click += new System.EventHandler(this.MIXButton_Click);
            // 
            // AppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ConchiButton);
            this.Controls.Add(this.WordFinderButton);
            this.Controls.Add(this.RaspiButton);
            this.Controls.Add(this.MIXButton);
            this.Controls.Add(this.Tittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "AppLauncher";
            this.Text = "App Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button MIXButton;
        private System.Windows.Forms.Button RaspiButton;
        private System.Windows.Forms.Button WordFinderButton;
        private System.Windows.Forms.Button ConchiButton;
    }
}

