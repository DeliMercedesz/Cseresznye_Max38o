using Cseresznye_Max38o.Mappa;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cseresznye_Max38o.Controllers
{
    [Route("api/szabadulo")]
    [ApiController]
    public class SzabaduloController : ControllerBase
    {
        // GET: api/<SzabaduloController>
        [HttpGet]
        public IActionResult Get()
        {
            context_Szabaduloszoba context = new context_Szabaduloszoba();
            return Ok(context.Szobaks.ToList());
        }

        // GET api/<SzabaduloController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            context_Szabaduloszoba context = new context_Szabaduloszoba();
            var keresettSzoba = (from x in context.Szobaks
                                 where x.SzobaId == id
                                 select x).FirstOrDefault();
            if (keresettSzoba == null)
            {
                return NotFound($"Nincs #{id} azonosítóval szoba");
            }
            else
            {
                return Ok(keresettSzoba);
            }
        }

        // POST api/<SzabaduloController>
        [HttpPost]
        public IActionResult Post([FromBody] Szobak ujSzoba)
        {
            context_Szabaduloszoba context = new context_Szabaduloszoba();
            if (ujSzoba.Nehezseg == 0)
            {
                return NotFound("A nehézségnek 0-nál nagyobbnak kell lennie");
            }
            context.Szobaks.Add(ujSzoba);
            context.SaveChanges();
            return Ok("Szoba Mentése");
        }

        // PUT api/<SzabaduloController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SzabaduloController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            context_Szabaduloszoba context = new context_Szabaduloszoba();
            var törlendőSzoba = (from x in context.Szobaks
                                 where x.SzobaId == id
                                 select x).FirstOrDefault();
            if (törlendőSzoba == null)
            {
                return NotFound("Nincs ilyen");
            }
            else
            {
                context.Remove(törlendőSzoba);

                context.SaveChanges();

                return Ok();

            }
        }
    }
}
