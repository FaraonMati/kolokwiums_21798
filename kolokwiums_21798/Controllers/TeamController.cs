using kolokwium_21798.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private IDbService _dbService;

        public TeamController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        [Route("{idTeam}")]
        public async Task<IActionResult> getTeam(int idTeam)
        {
            try
            {
                return Ok(await _dbService.getTeam(idTeam));
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }
    }
}
