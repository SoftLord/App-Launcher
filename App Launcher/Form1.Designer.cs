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
            this.SuspendLayout();
            // 
            // Tittle
            // 
            this.Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tittle.Font = new System.Drawing.Font("Victor Mono", 50F);
            this.Tittle.ForeColor = System.Drawing.Color.White;
            this.Tittle.Location = new System.Drawing.Point(0, 0);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(800, 131);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "/App Launcher";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            // 
            // AppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppLauncher";
            this.Text = "App Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Tittle;
    }
}

