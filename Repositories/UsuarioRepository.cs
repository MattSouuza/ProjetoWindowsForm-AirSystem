using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int id = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    Id = 1,
                    Nome = "Matheus",
                    Sobrenome = "Souza Silva",
                    Endereco = "Rua Batata",
                    Numero = "10",
                    Nascimento = Convert.ToString("27/05/2002"),
                    NomeUsuario = "Souuza",
                    Senha = "123",
                    ConfirmarSenha = "123",
                    IsAdmin = true
                });
                id++;
                usuarios.Add(new Usuario
                {
                    Id = 1,
                    Nome = "Durevaldo",
                    Sobrenome = "Serra",
                    Endereco = "Rua Abacaxi",
                    Numero = "54",
                    Nascimento = Convert.ToString("04/07/1997"),
                    NomeUsuario = "valdinho",
                    Senha = "123",
                    ConfirmarSenha = "123",
                    IsAdmin = false
                });
                id++;

            }
        }

        public void Adicionar(Usuario usuario)
        {
            usuario.Id = id;

            usuarios.Add(usuario);
            id++;
        }

        public void Editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.Id == usuario.Id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public List<Usuario> Listar()
        {
            return usuarios;
        }
    }
}
