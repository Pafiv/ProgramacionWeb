namespace FRMAlgoritmos
{
    partial class FormDibujoDDA
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
            this.pictureBoxDDA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDDA
            // 
            this.pictureBoxDDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDDA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDDA.Name = "pictureBoxDDA";
            this.pictureBoxDDA.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxDDA.TabIndex = 0;
            this.pictureBoxDDA.TabStop = false;
            this.pictureBoxDDA.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDDA_Paint);
            // 
            // FormDibujoDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDDA);
            this.Name = "FormDibujoDDA";
            this.Text = "FormDibujoDDA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDDA;
    }
}