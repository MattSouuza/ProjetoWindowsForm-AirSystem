namespace AirSystem.Views
{
    partial class frmPrincipal
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
            this.bttListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttListar
            // 
            this.bttListar.Location = new System.Drawing.Point(44, 36);
            this.bttListar.Name = "bttListar";
            this.bttListar.Size = new System.Drawing.Size(75, 23);
            this.bttListar.TabIndex = 0;
            this.bttListar.Text = "Listar";
            this.bttListar.UseVisualStyleBackColor = true;
            this.bttListar.Click += new System.EventHandler(this.bttListar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttListar);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttListar;
    }
}