namespace Algoritmos
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoRadiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBresehamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algotirmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoFloodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoRadiusToolStripMenuItem,
            this.algoritmoDeBresehamToolStripMenuItem,
            this.algotirmoDDAToolStripMenuItem,
            this.algoritmoFloodFillToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // algoritmoRadiusToolStripMenuItem
            // 
            this.algoritmoRadiusToolStripMenuItem.Name = "algoritmoRadiusToolStripMenuItem";
            this.algoritmoRadiusToolStripMenuItem.Size = new System.Drawing.Size(464, 34);
            this.algoritmoRadiusToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoRadiusToolStripMenuItem.Click += new System.EventHandler(this.algoritmoRadiusToolStripMenuItem_Click);
            // 
            // algoritmoDeBresehamToolStripMenuItem
            // 
            this.algoritmoDeBresehamToolStripMenuItem.Name = "algoritmoDeBresehamToolStripMenuItem";
            this.algoritmoDeBresehamToolStripMenuItem.Size = new System.Drawing.Size(464, 34);
            this.algoritmoDeBresehamToolStripMenuItem.Text = "Algoritmo de Bresenham";
            this.algoritmoDeBresehamToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeBresehamToolStripMenuItem_Click);
            // 
            // algotirmoDDAToolStripMenuItem
            // 
            this.algotirmoDDAToolStripMenuItem.Name = "algotirmoDDAToolStripMenuItem";
            this.algotirmoDDAToolStripMenuItem.Size = new System.Drawing.Size(464, 34);
            this.algotirmoDDAToolStripMenuItem.Text = "Algotritmo Discretización de circunferencias ";
            this.algotirmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algotirmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoFloodFillToolStripMenuItem
            // 
            this.algoritmoFloodFillToolStripMenuItem.Name = "algoritmoFloodFillToolStripMenuItem";
            this.algoritmoFloodFillToolStripMenuItem.Size = new System.Drawing.Size(464, 34);
            this.algoritmoFloodFillToolStripMenuItem.Text = "Algoritmo FloodFill";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algotirmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoRadiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBresehamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoFloodFillToolStripMenuItem;
    }
}

