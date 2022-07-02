using kolokwium_21798.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium_21798.Services
{
    public interface IDbService
    {
        Task<TeamDTO> getTeam(int idTeam)
    }
}
