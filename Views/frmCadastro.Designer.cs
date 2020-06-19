namespace AirSystem.Views
{
    partial class frmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxSobrenome = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.bttAlterar = new System.Windows.Forms.Button();
            this.bttRemover = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.bttCadastrar = new System.Windows.Forms.Button();
            this.bttVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(93, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(279, 41);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(109, 24);
            this.lblSobrenome.TabIndex = 4;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(93, 114);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(90, 24);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(279, 114);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(79, 24);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNascimento
            // 
            this.dateNascimento.Location = new System.Drawing.Point(97, 218);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(261, 22);
            this.dateNascimento.TabIndex = 7;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(93, 191);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(181, 24);
            this.lblNascimento.TabIndex = 8;
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(93, 260);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(93, 324);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 24);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(279, 324);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(153, 24);
            this.lblConfirmarSenha.TabIndex = 11;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            this.lblConfirmarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(97, 68);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(122, 22);
            this.txtBoxNome.TabIndex = 12;
            // 
            // txtBoxSobrenome
            // 
            this.txtBoxSobrenome.Location = new System.Drawing.Point(283, 68);
            this.txtBoxSobrenome.Name = "txtBoxSobrenome";
            this.txtBoxSobrenome.Size = new System.Drawing.Size(146, 22);
            this.txtBoxSobrenome.TabIndex = 13;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(97, 141);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(123, 22);
            this.txtBoxEndereco.TabIndex = 14;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(283, 141);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(70, 22);
            this.txtBoxNumero.TabIndex = 15;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(97, 287);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(123, 22);
            this.txtBoxUsuario.TabIndex = 16;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(97, 351);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(123, 22);
            this.txtBoxSenha.TabIndex = 17;
            // 
            // txtBoxConfirmarSenha
            // 
            this.txtBoxConfirmarSenha.Location = new System.Drawing.Point(283, 351);
            this.txtBoxConfirmarSenha.Name = "txtBoxConfirmarSenha";
            this.txtBoxConfirmarSenha.PasswordChar = '*';
            this.txtBoxConfirmarSenha.Size = new System.Drawing.Size(123, 22);
            this.txtBoxConfirmarSenha.TabIndex = 18;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(558, 68);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(149, 147);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 19;
            this.pictureBoxFoto.TabStop = false;
            // 
            // bttAlterar
            // 
            this.bttAlterar.Location = new System.Drawing.Point(558, 224);
            this.bttAlterar.Name = "bttAlterar";
            this.bttAlterar.Size = new System.Drawing.Size(75, 23);
            this.bttAlterar.TabIndex = 20;
            this.bttAlterar.Text = "Alterar";
            this.bttAlterar.UseVisualStyleBackColor = true;
            this.bttAlterar.Click += new System.EventHandler(this.bttAlterar_Click);
            // 
            // bttRemover
            // 
            this.bttRemover.Location = new System.Drawing.Point(632, 224);
            this.bttRemover.Name = "bttRemover";
            this.bttRemover.Size = new System.Drawing.Size(75, 23);
            this.bttRemover.TabIndex = 21;
            this.bttRemover.Text = "Remover";
            this.bttRemover.UseVisualStyleBackColor = true;
            this.bttRemover.Click += new System.EventHandler(this.bttRemover_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(283, 287);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(85, 21);
            this.checkBoxAdmin.TabIndex = 22;
            this.checkBoxAdmin.Text = "É admin.";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // bttCadastrar
            // 
            this.bttCadastrar.Location = new System.Drawing.Point(576, 290);
            this.bttCadastrar.Name = "bttCadastrar";
            this.bttCadastrar.Size = new System.Drawing.Size(112, 38);
            this.bttCadastrar.TabIndex = 23;
            this.bttCadastrar.Text = "Cadastrar";
            this.bttCadastrar.UseVisualStyleBackColor = true;
            this.bttCadastrar.Click += new System.EventHandler(this.bttCadastrar_Click);
            // 
            // bttVoltar
            // 
            this.bttVoltar.Location = new System.Drawing.Point(576, 335);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(112, 38);
            this.bttVoltar.TabIndex = 24;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = true;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttVoltar);
            this.Controls.Add(this.bttCadastrar);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.bttRemover);
            this.Controls.Add(this.bttAlterar);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.txtBoxConfirmarSenha);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.txtBoxSobrenome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxSobrenome;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxConfirmarSenha;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button bttAlterar;
        private System.Windows.Forms.Button bttRemover;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button bttCadastrar;
        private System.Windows.Forms.Button bttVoltar;
    }
}