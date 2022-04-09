using Microsoft.EntityFrameworkCore;
using SecurityDataModel;

namespace SecuritySystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
        public DbSet<SecurityData> SecurityDatas{ get; set; }
        public DbSet<StoresData> StoresDatas { get; set; }
        public DbSet<OfficerData> OfficerDatas { get; set; }
    }
}
