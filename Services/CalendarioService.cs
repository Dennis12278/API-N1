using DreamApi.Data;
using DreamApi.Models;

namespace DreamApi.Services
{
    public class CalendarioService
    {
        private DreamDbContext context;

        public CalendarioService(DreamDbContext context)
        {
            this.context = context;
        }

        public List<Calendario> Listar()
        {
            return context.Calendarios.ToList();
        }

        public void Adicionar(Calendario calendario)
        {
            context.Calendarios.Add(calendario);
            context.SaveChanges();
        }

        public void Editar(Calendario calendario)
        {
            Calendario calendarioExistente = context.Calendarios.Find(calendario.Id);

            if (calendarioExistente != null)
            {
                calendarioExistente.IdUsuario = calendario.IdUsuario;
                calendarioExistente.Data = calendario.Data;
                calendarioExistente.Descricao = calendario.Descricao;

                context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            Calendario calendario = context.Calendarios.Find(id);

            if (calendario != null)
            {
                context.Calendarios.Remove(calendario);
                context.SaveChanges();
            }
        }
    }
}