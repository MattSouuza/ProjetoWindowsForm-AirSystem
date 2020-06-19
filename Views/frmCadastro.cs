using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void bttAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog AlterarFoto = new OpenFileDialog();

            AlterarFoto.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";

            if (AlterarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(AlterarFoto.FileName);
            }
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttRemover_Click(object sender, EventArgs e)
        {
            if (pictureBoxFoto.Image != null)
            {
                pictureBoxFoto.Image.Dispose();
                pictureBoxFoto.Image = null;
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                txtBoxNome.Text = usuario.Nome;
                txtBoxSobrenome.Text = usuario.Sobrenome;
                txtBoxEndereco.Text = usuario.Endereco;
                txtBoxNumero.Text = usuario.Numero;
                dateNascimento.Text = usuario.Nascimento;
                txtBoxUsuario.Text = usuario.NomeUsuario;
                txtBoxSenha.Text = usuario.Senha;
                txtBoxConfirmarSenha.Text = usuario.ConfirmarSenha;
                checkBoxAdmin.Checked = usuario.IsAdmin;
            }
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            if (!Utils.TemCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        Nome = txtBoxNome.Text,
                        Sobrenome = txtBoxSobrenome.Text,
                        Endereco = txtBoxEndereco.Text,
                        Numero = txtBoxNumero.Text,
                        Nascimento = dateNascimento.Text,
                        NomeUsuario = txtBoxUsuario.Text,
                        Senha = txtBoxSenha.Text,
                        ConfirmarSenha = txtBoxConfirmarSenha.Text,
                        IsAdmin = checkBoxAdmin.Checked
                    };

                    repository.Adicionar(usuario);

                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    this.usuario.Nome = txtBoxNome.Text;
                    this.usuario.Sobrenome = txtBoxSobrenome.Text;
                    this.usuario.Endereco = txtBoxEndereco.Text;
                    this.usuario.Numero = txtBoxNumero.Text;
                    this.usuario.Nascimento = dateNascimento.Text;
                    this.usuario.NomeUsuario = txtBoxUsuario.Text;
                    this.usuario.Senha = txtBoxSenha.Text;
                    this.usuario.ConfirmarSenha = txtBoxConfirmarSenha.Text;
                    this.usuario.IsAdmin = checkBoxAdmin.Checked;

                    repository.Editar(usuario);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }
    }
}
