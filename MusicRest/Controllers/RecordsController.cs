using Microsoft.AspNetCore.Mvc;

namespace MusicRest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecordsController : Controller
    {
        private RecordsRepositoryList _recordsRepository;

        public RecordsController(RecordsRepositoryList recordsRepository)
        {
            _recordsRepository = recordsRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Record> Get([FromQuery] string? title = null, [FromQuery] string? artist = null, [FromQuery] int? duration = null, [FromQuery] int? publicationYear = null)
        {
            IEnumerable<Record> result = _recordsRepository.Get(title: title ?? "", artist:artist??"", duration:duration?? 0 ,publicationYear:publicationYear);

            if (result.Any()) { return Ok(result); }
            return NoContent();
            
        }


    }



}
