namespace AirSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.bttEntrar = new System.Windows.Forms.Button();
            this.bttSair = new System.Windows.Forms.Button();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(445, 144);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(449, 171);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(261, 22);
            this.txtBoxUsuario.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(447, 221);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 24);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(449, 248);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(261, 22);
            this.txtBoxSenha.TabIndex = 7;
            this.txtBoxSenha.TextChanged += new System.EventHandler(this.txtBoxSenha_TextChanged);
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(449, 306);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(147, 24);
            this.comboBoxIdioma.TabIndex = 8;
            this.comboBoxIdioma.Text = "Idiomas";
            // 
            // bttEntrar
            // 
            this.bttEntrar.Location = new System.Drawing.Point(449, 368);
            this.bttEntrar.Name = "bttEntrar";
            this.bttEntrar.Size = new System.Drawing.Size(77, 33);
            this.bttEntrar.TabIndex = 10;
            this.bttEntrar.Text = "Entrar";
            this.bttEntrar.UseVisualStyleBackColor = true;
            this.bttEntrar.Click += new System.EventHandler(this.bttEntrar_Click);
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(633, 368);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(77, 33);
            this.bttSair.TabIndex = 11;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Location = new System.Drawing.Point(609, 105);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(101, 33);
            this.bttCadastrar.TabIndex = 12;
            this.bttCadastrar.Text = "Cadastrar-se";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AirSystem.Properties.Resources._45db3c3e;
            this.pictureBox2.Location = new System.Drawing.Point(73, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirSystem.Properties.Resources.e70a6296c2a79dc7a56ab05b103f38e8_sinal_de_usu__rio_com_fundo_by_vexels;
            this.pictureBox1.Location = new System.Drawing.Point(449, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.bttEntrar);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Button bttEntrar;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Button bttCadastrar;
    }
}

