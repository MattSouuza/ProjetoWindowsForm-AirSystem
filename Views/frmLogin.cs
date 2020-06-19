using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            txtBoxSenha.PasswordChar = '*';
        }

        private void bttEntrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository repository = new UsuarioRepository();
            List<Usuario> listaUsuariosExistentes = repository.Listar();

            Usuario usuarioAtual = listaUsuariosExistentes.FirstOrDefault(u => u.NomeUsuario == txtBoxUsuario.Text && u.Senha == txtBoxSenha.Text);

            if (usuarioAtual != null)
            {
                MessageBox.Show("Bem-vindo!", "Entrada");
                new frmPrincipal().ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Informe o usuário e a senha", "Erro");
            }

            //foreach (var u in listaUsuariosExistentes)
            //{
            //    if (u.NomeUsuario == txtBoxUsuario.Text && u.Senha == txtBoxSenha.Text)
            //    {
            //        MessageBox.Show("Bem-vindo!", "Entrada");
            //        new frmPrincipal().ShowDialog(); 
            //    }
            //    else
            //    {
            //        MessageBox.Show("Informe o usuário e a senha", "Erro");
            //    }
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            this.lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
