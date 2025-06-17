namespace FRMAlgoritmos
{
    partial class Bresenham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Yf = new System.Windows.Forms.TextBox();
            this.Yi = new System.Windows.Forms.TextBox();
            this.Xf = new System.Windows.Forms.TextBox();
            this.Xi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Yf);
            this.groupBox2.Controls.Add(this.Yi);
            this.groupBox2.Controls.Add(this.Xf);
            this.groupBox2.Controls.Add(this.Xi);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yf(punto final)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yi(punto inicial)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xf(punto final)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xi(punto inicial)";
            // 
            // Yf
            // 
            this.Yf.Location = new System.Drawing.Point(143, 126);
            this.Yf.Name = "Yf";
            this.Yf.Size = new System.Drawing.Size(100, 22);
            this.Yf.TabIndex = 3;
            // 
            // Yi
            // 
            this.Yi.Location = new System.Drawing.Point(143, 93);
            this.Yi.Name = "Yi";
            this.Yi.Size = new System.Drawing.Size(100, 22);
            this.Yi.TabIndex = 2;
            // 
            // Xf
            // 
            this.Xf.Location = new System.Drawing.Point(143, 67);
            this.Xf.Name = "Xf";
            this.Xf.Size = new System.Drawing.Size(100, 22);
            this.Xf.TabIndex = 1;
            // 
            // Xi
            // 
            this.Xi.Location = new System.Drawing.Point(143, 37);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(100, 22);
            this.Xi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Salir);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Location = new System.Drawing.Point(111, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Tomato;
            this.Salir.Location = new System.Drawing.Point(6, 123);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Turquoise;
            this.Reset.Location = new System.Drawing.Point(6, 74);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Resetear";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.LawnGreen;
            this.Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcular.Location = new System.Drawing.Point(6, 31);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tabla);
            this.groupBox3.Location = new System.Drawing.Point(291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 420);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla";
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(28, 27);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.Size = new System.Drawing.Size(819, 382);
            this.Tabla.TabIndex = 0;
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Bresenham";
            this.Text = "Bresenham";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Yf;
        private System.Windows.Forms.TextBox Yi;
        private System.Windows.Forms.TextBox Xf;
        private System.Windows.Forms.TextBox Xi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Tabla;
    }
}