

using Microsoft.EntityFrameworkCore;
//using TodoList.Model;

namespace TodoList.context
{
    partial class context : DbContext
    {
       // public virtual DbSet<Entity> Blazor_Db { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=172.22.2.12;initial catalog=TestPayroll;persist security info=True;user id=sa;password=sql2@16;MultipleActiveResultSets=True;App=EntityFramework;connect timeout=180;Trusted_Connection=true;integrated security=False;TrustServerCertificate=true");
        }
    }
}

