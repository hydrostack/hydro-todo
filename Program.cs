using Hydro.Configuration;
using HydroTodo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Database>(o => {
    o.UseSqlite("Data Source=app.db");
});

builder.Services.AddRazorPages();
builder.Services.AddHydro();

var app = builder.Build();

app.MapRazorPages();
app.UseStaticFiles();
app.UseRouting();
app.UseHydro(app.Environment);

app.Run();
