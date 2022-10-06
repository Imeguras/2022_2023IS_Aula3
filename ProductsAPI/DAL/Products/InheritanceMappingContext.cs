using ProductsAPI.Models; 
using Microsoft.EntityFrameworkCore;
using MySQL.Data;
//using MySQL.Data.EntityFrameworkCore;
//Pomelo mysql
using Pomelo.EntityFrameworkCore.MySql;

using System.Configuration;
//using mysql drive
namespace ProductsAPI.DAL.Products
{
    public class InheritanceMappingContext : DbContext {
		public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
			var connectionString = "You wished not doing it even if it runs on localhost";
        	var serverVersion = ServerVersion.AutoDetect(connectionString);

			
			optionsBuilder.UseMySql(connectionString, serverVersion);
	
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
		}
	}
	
	
}
