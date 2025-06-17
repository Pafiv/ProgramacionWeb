namespace FRMAlgoritmos
{
    partial class Algoritmos
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuDeAlgoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoBreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoCircunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeAlgoritmosToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 28);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuDeAlgoritmosToolStripMenuItem
            // 
            this.menuDeAlgoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDDAToolStripMenuItem,
            this.algoritmoBreToolStripMenuItem,
            this.algoritmoCircunferenciaToolStripMenuItem});
            this.menuDeAlgoritmosToolStripMenuItem.Name = "menuDeAlgoritmosToolStripMenuItem";
            this.menuDeAlgoritmosToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.menuDeAlgoritmosToolStripMenuItem.Text = "Menu de algoritmos";
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoBreToolStripMenuItem
            // 
            this.algoritmoBreToolStripMenuItem.Name = "algoritmoBreToolStripMenuItem";
            this.algoritmoBreToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.algoritmoBreToolStripMenuItem.Text = "Algoritmo Bresenham";
            this.algoritmoBreToolStripMenuItem.Click += new System.EventHandler(this.algoritmoBreToolStripMenuItem_Click);
            // 
            // algoritmoCircunferenciaToolStripMenuItem
            // 
            this.algoritmoCircunferenciaToolStripMenuItem.Name = "algoritmoCircunferenciaToolStripMenuItem";
            this.algoritmoCircunferenciaToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.algoritmoCircunferenciaToolStripMenuItem.Text = "Algoritmo Circunferencia";
            this.algoritmoCircunferenciaToolStripMenuItem.Click += new System.EventHandler(this.algoritmoCircunferenciaToolStripMenuItem_Click);
            // 
            // Algoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "Algoritmos";
            this.Text = "Algoritmos";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuDeAlgoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoBreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoCircunferenciaToolStripMenuItem;
    }
}

