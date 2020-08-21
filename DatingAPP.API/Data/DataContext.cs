using DatingAPP.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingAPP.API.Data
{
    public class DataContext : DbContext
    {
        internal object Values;

        public DataContext(DbContextOptions<DataContext>options) : base(options){}
        public DbSet<Value> values {get;set;}
         
    }
}