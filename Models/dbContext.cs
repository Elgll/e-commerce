using Microsoft.EntityFrameworkCore;
namespace galli.mingucci._5i.Progetto_E_Commerce.Data;
using System.ComponentModel.DataAnnotations;
public class dbContext : DbContext
{

     public dbContext(DbContextOptions<dbContext> options)
       : base(options)
	 {
	 }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite(@"Data Source=ECommerce.db");


    public DbSet<Bike> Bikes { get; set;}
    public DbSet<Circuit> Circuits {get; set;}
    public DbSet<Login> Logins {get; set;}
    public DbSet<Prenotation> Prenotations { get; set;}
    public DbSet<ApplicationUser> ApplicationUsers { get; set;}
    



}