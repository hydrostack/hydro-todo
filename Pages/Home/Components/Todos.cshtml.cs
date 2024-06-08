using System.ComponentModel.DataAnnotations;
using Hydro;
using HydroTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace HydroTodo.Pages.Home.Components;

public class Todos(Database db) : HydroComponent
{
    public override async Task RenderAsync()
    {
        Items = await db.Todos.ToListAsync();
    }

    [Required]
    public string NewItem { get; set; }

    public List<Todo> Items { get; set; }

    public async Task Add()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        var todo = new Todo { Content = NewItem };
        db.Todos.Add(todo);
        await db.SaveChangesAsync();

        NewItem = string.Empty;
    }

    public async Task Toggle(int id)
    {
        var todo = await db.Todos.FindAsync(id);
        if (todo is not null)
        {
            todo.Done = !todo.Done;
            await db.SaveChangesAsync();
        }
    }

    public async Task Delete(int id)
    {
        var todo = await db.Todos.FindAsync(id);
        if (todo is not null)
        {
            db.Todos.Remove(todo);
            await db.SaveChangesAsync();
        }
    }
}