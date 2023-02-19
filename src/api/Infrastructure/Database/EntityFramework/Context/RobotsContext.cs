using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Database
{
    public class RobotsContext: DbContext
    {
        public RobotsContext(DbContextOptions<RobotsContext> options):base(options){

        }

        public DbSet<Robot> Robots { get; set; }

    }
}