using System.Collections.Generic;
using Api.Ui.Dtos;
using Api.Domain.Models;

namespace Api.Application.Services
{
    public interface IRobotServices
    {
         IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);
         

    }
}