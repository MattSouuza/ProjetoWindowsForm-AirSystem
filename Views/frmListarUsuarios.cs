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
    public partial class frmListarUsuarios : Form
    {
        private UsuarioRepository repository = new UsuarioRepository();

        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        private void alterarId()
        {
            lblContador.Text = $"{dgvListarUsuarios.RowCount} itens de {repository.Listar().Count}";
        }

        private void carregarLista()
        {
            dgvListarUsuarios.DataSource = null;
            dgvListarUsuarios.DataSource = repository.Listar();
            alterarId();
        } 

        private void dgvListarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListarUsuarios.Rows[e.RowIndex];

            int Id = Convert.ToInt32(linha.Cells[0].Value.ToString());
            string Nome = linha.Cells[1].Value.ToString();
            string Sobrenome = linha.Cells[2].Value.ToString();
            string Endereco = linha.Cells[3].Value.ToString();
            string Numero = linha.Cells[4].Value.ToString();
            string Nascimento = linha.Cells[5].Value.ToString();
            string NomeUsuario = linha.Cells[6].Value.ToString();
            string Senha = linha.Cells[7].Value.ToString();
            string ConfirmarSenha = linha.Cells[8].Value.ToString();

            Usuario usuario = new Usuario
            {
                Id = Id,
                Nome = Nome,
                Sobrenome = Sobrenome,
                Endereco = Endereco,
                Numero = Numero,
                Nascimento = Nascimento,
                NomeUsuario = NomeUsuario,
                Senha = Senha,
                ConfirmarSenha = ConfirmarSenha,
            };

            new frmCadastro().ShowDialog();

            carregarLista();
        }

        private void dgvListarUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtBoxBusca_TextChanged(object sender, EventArgs e)
        {
            dgvListarUsuarios.DataSource = null;

            dgvListarUsuarios.DataSource = repository.Listar().FindAll(x =>
                x.Nome.ToUpper().Contains(txtBoxBusca.Text.ToUpper()) ||
                x.Sobrenome.ToUpper().Contains(txtBoxBusca.Text.ToUpper()));

            alterarId();
        }
    }
}
