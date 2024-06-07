using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HydroTodo.Models;

public class Database(DbContextOptions<Database> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>(); 
}

public class Todo
{
    public int Id { get; set; }
    [MaxLength(300)]
    public string Content { get; set; } = "";
    public bool Done { get; set; }
}