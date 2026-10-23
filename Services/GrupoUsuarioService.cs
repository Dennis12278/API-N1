using DreamApi.Data;
using DreamApi.Models;

namespace DreamApi.Services
{
    public class GrupoUsuarioService
    {
        private DreamDbContext context;

        public GrupoUsuarioService(DreamDbContext context)
        {
            this.context = context;
        }

        public List<GrupoUsuario> Listar()
        {
            return context.GruposUsuarios.ToList();
        }

        public void Adicionar(GrupoUsuario grupoUsuario)
        {
            context.GruposUsuarios.Add(grupoUsuario);
            context.SaveChanges();
        }

        public void Editar(GrupoUsuario grupoUsuario)
        {
            GrupoUsuario grupoUsuarioExistente = context.GruposUsuarios.Find(grupoUsuario.Id);

            if (grupoUsuarioExistente != null)
            {
                grupoUsuarioExistente.IdGrupo = grupoUsuario.IdGrupo;
                grupoUsuarioExistente.IdUsuario = grupoUsuario.IdUsuario;

                context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            GrupoUsuario grupoUsuario = context.GruposUsuarios.Find(id);

            if (grupoUsuario != null)
            {
                context.GruposUsuarios.Remove(grupoUsuario);
                context.SaveChanges();
            }
        }
    }
}