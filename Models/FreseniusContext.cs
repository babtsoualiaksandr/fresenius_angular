using Microsoft.EntityFrameworkCore;  
namespace Fresenius_Angular.Models {     
public class FreseniusContext : DbContext     
  {   
    //static FreseniusContext() => NpgsqlConnection.GlobalTypeMapper.MapEnum<cat_color>();      
    public FreseniusContext(DbContextOptions<FreseniusContext> options): base(options)         
{         
}       
    public DbSet<Country> Countries { get; set; }
    public DbSet<Equipment> Equipments { get; set; }   
    public DbSet<IdentityCard> IdentityCards { get; set; }  
     public DbSet<Invoice> Invoices { get; set; }  
      public DbSet<Manufacturer> Manufacturers { get; set; }  
       public DbSet<ProductName> ProductNames { get; set; }  
        public DbSet<SparePart> Spareparts { get; set; }  
    
    
    
    
    
    
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cat_colors_info>().HasKey(b => b.Color);
            //Добавляется для того что бы перечесляемый тип появился в бд
           // modelBuilder.ForNpgsqlHasEnum<cat_color>();
        }
   } 
}