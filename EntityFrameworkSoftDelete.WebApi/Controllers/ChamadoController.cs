using EntityFrameworkSoftDelete.Data;
using EntityFrameworkSoftDelete.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkSoftDelete.Controllers
{
    [ApiController]
    [Route("/chamados")]
    public class ChamadoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ChamadoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IEnumerable<Chamado> Get()
        {
            return _dataContext.Chamados.AsNoTracking();
        }

        [HttpPost]
        public Chamado Post([FromBody]Chamado chamado)
        {
            _dataContext.Chamados.Add(chamado);
            _dataContext.SaveChanges();
            return chamado;
        }

    }
}
