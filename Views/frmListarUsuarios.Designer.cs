namespace AirSystem.Views
{
    partial class frmListarUsuarios
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
            this.dgvListarUsuarios = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtBoxBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarUsuarios
            // 
            this.dgvListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvListarUsuarios.Name = "dgvListarUsuarios";
            this.dgvListarUsuarios.RowHeadersWidth = 51;
            this.dgvListarUsuarios.RowTemplate.Height = 24;
            this.dgvListarUsuarios.Size = new System.Drawing.Size(615, 426);
            this.dgvListarUsuarios.TabIndex = 0;
            this.dgvListarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarUsuarios_CellContentClick);
            this.dgvListarUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListarUsuarios_CellMouseClick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(642, 421);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(16, 17);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0";
            // 
            // txtBoxBusca
            // 
            this.txtBoxBusca.Location = new System.Drawing.Point(645, 35);
            this.txtBoxBusca.Name = "txtBoxBusca";
            this.txtBoxBusca.Size = new System.Drawing.Size(143, 22);
            this.txtBoxBusca.TabIndex = 2;
            this.txtBoxBusca.TextChanged += new System.EventHandler(this.txtBoxBusca_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(641, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(66, 24);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBoxBusca);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dgvListarUsuarios);
            this.Name = "frmListarUsuarios";
            this.Text = "frmListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarUsuarios;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtBoxBusca;
        private System.Windows.Forms.Label lblBuscar;
    }
}