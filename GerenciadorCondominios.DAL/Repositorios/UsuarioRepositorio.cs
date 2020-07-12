using System;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Usuario> _gerenciadorUsuarios;
         
        private readonly SignInManager<Usuario> _gerenciadorLogin;
        public UsuarioRepositorio(Contexto contexto,UserManager<Usuario> gerenciadorUsuarios,SignInManager<Usuario> gerenciadorLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuarios;
            _gerenciadorLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await _gerenciadorUsuarios.CreateAsync(usuario,senha);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(Usuario usuario1, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(usuario1,funcao);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task LogarUsuario(Usuario usuario, bool lembrar)
        {
            try
            {
                await _gerenciadorLogin.SignInAsync(usuario,lembrar);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public int VerificaSeExisteRegistro()
        {
            try
            {
                return _contexto.Usuarios.Count();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}