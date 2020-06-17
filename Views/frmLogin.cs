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
            new frmPrincipal().ShowDialog();
        }
    }
}
