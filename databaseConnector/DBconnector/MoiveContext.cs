using Microsoft.EntityFrameworkCore;
using databaseConnector.model;

namespace databaseConnector.dbconnector{
    public class MoiveConnector : DbContext{
        public DbSet<Moive> moives {get; set;}

        public MoiveConnector(DbContextOptions<MoiveConnector> options) : base(options){}

        async protected override void OnModelCreating(ModelBuilder modelBuilder){
            // Use Fluent API to configure  
  
            // Map entities to tables  
            modelBuilder.Entity<Moive>().ToTable("tb_moive");  

             // Configure Primary Keys  
            modelBuilder.Entity<Moive>().HasKey(ug => ug.Id).HasName("PK_Moives"); 

            modelBuilder.Entity<Moive>().Property(ug => ug.Id).HasColumnType("bigint").IsRequired();  
            modelBuilder.Entity<Moive>().Property(ug => ug.Name).HasColumnType("nvarchar(45)").IsRequired();  
            modelBuilder.Entity<Moive>().Property(ug => ug.Vote).HasColumnType("int").IsRequired();  
        }
    }
}