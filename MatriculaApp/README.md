# MatriculaApp

Pequeña aplicación web en C# con ASP.NET Core que permite capturar datos de una matrícula a través de un formulario HTML y guardarlos en un archivo JSON.

## 🚀 Requisitos previos

- Tener instalado [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code con la extensión **C# Dev Kit**
- Git (opcional para subir a GitHub)

---

## 🧩 Crear el proyecto desde cero (explicativo)

```bash
dotnet new web -n MatriculaApp
cd MatriculaApp
```

Crear las carpetas necesarias:

```bash
mkdir Controllers Models Pages
```

Agregar los archivos como se indica:

### `Models/Matricula.cs`
```csharp
namespace MatriculaApp.Models
{
    public class Matricula
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Curso { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
    }
}
```

### `Controllers/MatriculaController.cs`
```csharp
using Microsoft.AspNetCore.Mvc;
using MatriculaApp.Models;
using System.Text.Json;

namespace MatriculaApp.Controllers
{
    [Route("Matricula")]
    public class MatriculaController : Controller
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "Pages", "MatriculaForm.html"), "text/html");
        }

        [HttpPost("Guardar")]
        public IActionResult Guardar([FromForm] Matricula datos)
        {
            var json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText("matricula.json", json);
            return Content("Matrícula guardada correctamente en matricula.json");
        }
    }
}
```

### `Pages/MatriculaForm.html`
```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario de Matrícula</title>
</head>
<body>
    <h2>Formulario de Matrícula</h2>
    <form method="post" action="/Matricula/Guardar">
        <label>Nombre:</label><br>
        <input type="text" name="Nombre" required><br><br>

        <label>Documento:</label><br>
        <input type="text" name="Documento" required><br><br>

        <label>Curso:</label><br>
        <input type="text" name="Curso" required><br><br>

        <label>Edad:</label><br>
        <input type="number" name="Edad" required><br><br>

        <label>Email:</label><br>
        <input type="email" name="Email" required><br><br>

        <button type="submit">Guardar Matrícula</button>
    </form>
</body>
</html>
```

### `Program.cs`
```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
```

---

## ▶️ Ejecutar la aplicación

```bash
dotnet run
```

Abre en tu navegador:
👉 [http://localhost:5000/Matricula](http://localhost:5000/Matricula)

Llena el formulario y verifica que se crea el archivo `matricula.json` en la raíz del proyecto.

---

## 🧠 Subir a GitHub y ejecutar en Codespaces

```bash
git init
git add .
git commit -m "Proyecto MatriculaApp inicial"
git branch -M main
git remote add origin https://github.com/tuusuario/MatriculaApp.git
git push -u origin main
```

Luego, abre el repositorio en **GitHub Codespaces** y ejecuta:
```bash
dotnet run
```

¡Listo! Tu aplicación web estará funcionando.
