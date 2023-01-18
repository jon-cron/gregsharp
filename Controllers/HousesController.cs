namespace gregsharp.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _housesService;

        public HousesController(HousesService housesService)
        {
            _housesService = housesService;
        }
        [HttpGet]
        public ActionResult<List<House>> Get()
        {
            try 
            {
              List<House> houses = _housesService.Get();
              return Ok(houses);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
        [HttpPost]

        public ActionResult<House> Create([FromBody] House houseData)
        {
            try 
            {
              House house = _housesService.Create(houseData);
              return house;
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
