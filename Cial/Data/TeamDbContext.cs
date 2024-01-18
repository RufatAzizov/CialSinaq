using Cial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Cial.Data
{
    public class TeamDbContext : DbContext 
    {
                     
        public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
        {
        }

        public DbSet<OurTeam> TeamData { get; set; }
        public DbSet<ClientsSlider> SliderData { get; set; }
    }

    



    //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //{
    //    IEnumerable<>
    //}
}
