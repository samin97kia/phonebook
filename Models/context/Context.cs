
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
   public DbSet<Tbl_Phonebook> Tbl_Phonebooks { get ; set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=dbphonebook;Trusted_Connection=True;");
    }



}