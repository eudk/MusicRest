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
        public ActionResult<Record> Get()
        {
            IEnumerable<Record> result = _recordsRepository.GetAll();
            if (result.Any()) { return Ok(result); }
            return NoContent();
        }
    }
}
