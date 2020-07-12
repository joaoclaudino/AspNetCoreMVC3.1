using System.Threading.Tasks;
using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IUsuarioRepositorio: IRepositorioGenerico<Usuario>
    {
         int VerificaSeExisteRegistro();
         Task LogarUsuario(Usuario usuario, bool lembrar);
         Task <IdentityResult> CriarUsuario(Usuario usuario, string senha);
         Task IncluirUsuarioEmFuncao(Usuario usuario1,string funcao);
         
    }
}