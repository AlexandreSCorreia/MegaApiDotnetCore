using System.Collections.Generic;
using Api.Domain.Models;

namespace Api.Infrastructure.Database
{
    public interface IRobotRepository
    {
        bool SaveChanges();

        IEnumerable<Robot> GetAllRobots();
        
        Robot GetRobotById(int id);

        void AddRobot(Robot robot);
        
    }
}