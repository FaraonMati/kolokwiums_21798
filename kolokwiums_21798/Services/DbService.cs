using kolokwium_21798.Models.DTOs;
using kolokwiums_21798.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Services
{
    public class DbService : IDbService
    {
        private MainDbContext _dbContext;
        public DbService(MainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<TeamDTO> getTeam(int idTeam)
        {
            throw new NotImplementedException();
        }

        //public async<Task>

    }
}
