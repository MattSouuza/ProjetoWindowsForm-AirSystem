using AirSystem.Models;
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

        private void bttCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
