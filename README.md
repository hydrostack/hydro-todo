# Hydro Todo

This repository contains a sample Todo web application that uses Hydro, Razor Pages and Tailwind.

Hydro brings stateful and reactive components to ASP.NET Core without writing JavaScript.

- [Hydro repository](https://github.com/hydrostack/hydro)
- [Hydro documentation](https://usehydro.dev/)

## How to run

1. Clone the repository

```bash
git clone git@github.com:hydrostack/hydro-todo.git
cd hydro-todo
```

2. Restore EF Core and update the database

```bash
dotnet tool restore
dotnet ef database update
```

3. Run the project:

```bash
dotnet run
```

## License

Hydro is Copyright © Krzysztof Jeske and other contributors under the [MIT license](https://raw.githubusercontent.com/hydrostack/hydro-showcase/main/LICENSE)
