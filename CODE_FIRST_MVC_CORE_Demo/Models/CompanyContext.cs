using Microsoft.EntityFrameworkCore;

namespace CODE_FIRST_MVC_CORE_Demo.Models
{
    public class CompanyContext :DbContext
    {

        public CompanyContext(DbContextOptions<CompanyContext> options):base(options)
        {
                
        }

        public DbSet<Company> Companies { get; set; }


    }
}
