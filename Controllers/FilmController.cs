using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP_MODUL10_103022400028.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        // daftar film statis
        public static List<Film> films = new List<Film>
        {
            new Film("Inception", "Christopher Nolan", "2010", "Sci-Fi", "9.0"),
            new Film("Interstellar", "Christopher Nolan", "2014", "Sci-Fi", "8.7"),
            new Film("Parasite", "Bong Joon-ho", "2019", "Thriller", "8.6")
        };
        // mengembalikan semua film
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return films;
        }
        // mengembalikan film berdasarkan index
        [HttpGet("{index}")]
        public Film Get(int index)
        {
            return films[index];
        }
        // menambahkan film baru
        [HttpPost]
        public void Post([FromBody] Film film)
        {
            films.Add(film);
        }
        // mengupdate or hpus film berdasarkan index
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            films.RemoveAt(index);
        }
    }
}