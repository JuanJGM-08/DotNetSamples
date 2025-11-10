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
