using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeetChatnim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchmakersController : ControllerBase
    {
        private readonly DataContext _context;

        public MatchmakerController(DataContext context)
        {
            _context = context;
        }

        public static List<Matchmaker> turns = new List<Matchmaker>
        {
            new Matchmaker { Id = "1", Name = "Avi", PhoneNumber = "123" },
            new Matchmaker { Id = "2", Name = "Michael", PhoneNumber = "456" }
        };

        // GET: api/Matchmaker
        //[HttpGet]
        //public IEnumerable<Matchmaker> Get()
        //{
        //    return ;
        //}

        // GET api/Matchmaker/5
        [HttpGet("{id}")]
        public ActionResult<Matchmaker> GetById(string id)
        {
            var mm = turns.Find(x => x.Id == id);
            if (mm != null)
            {
                return Ok(mm);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/Matchmaker
        [HttpPost]
        public ActionResult<Matchmaker> Post([FromBody] Matchmaker value)
        {
            turns.Add(new Matchmaker { Id = value.Id, Name = value.Name, PhoneNumber = value.PhoneNumber });
            return CreatedAtAction(nameof(GetById), new { id = value.Id }, value);
        }
    }
}
