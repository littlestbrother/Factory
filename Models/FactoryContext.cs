using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models {
  public class ToDoListContext: DbContext {
    public DbSet <Engineer> Engineers {get; set;}
    public DbSet <Machine> Machines {get; set;}
    public DbSet <EngineerMachine> EngineerMachine {get; set;}

    public ToDoListContext(DbContextOptions options): base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}