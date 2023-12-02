using System.ComponentModel.DataAnnotations;
using Hydro;

namespace HydroTodo.Pages.Home.Components;

public class Todos : HydroComponent
{
    public List<Todo> Items { get; set; } = new();
    
    [Required]
    public string NewItem { get; set; }

    public void Add()
    {
        if (!ModelState.IsValid)
        {
            return;
        }
        
        Items.Add(new Todo(NewItem));
        NewItem = string.Empty;
    }

    public void Toggle(string id)
    {
        var todo = Items.First(i => i.Id == id);
        todo.Done = !todo.Done;
    }
}

public class Todo(string content, bool done = false)
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Content { get; set; } = content;
    public bool Done { get; set; } = done;
}
