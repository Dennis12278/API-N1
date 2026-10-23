using DreamApi.Models;
using DreamApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DreamApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarioController : ControllerBase
    {
        private CalendarioService calendarioService;

        public CalendarioController(CalendarioService calendarioService)
        {
            this.calendarioService = calendarioService;
        }

        [HttpGet]
        public List<Calendario> Listar()
        {
            return calendarioService.Listar();
        }

        [HttpPost]
        public void Adicionar(Calendario calendario)
        {
            calendarioService.Adicionar(calendario);
        }

        [HttpPut]
        public void Editar(Calendario calendario)
        {
            calendarioService.Editar(calendario);
        }

        [HttpDelete("{id}")]
        public void Excluir(int id)
        {
            calendarioService.Excluir(id);
        }
    }
}