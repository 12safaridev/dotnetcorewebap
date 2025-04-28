using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        //  [HttpGet("api/cities")]
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CityDataStore.current.Cities);
        }

        //[HttpGet("{id}")]
        //public JsonResult GetCities(int id)
        //{
        //    return new JsonResult(CityDataStore.current.Cities.
        //                            Where(c => c.Id == id).FirstOrDefault()
        //                            ?? new Models.CityDto() { Id =0, Name="Not Found"});
        //}

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCities(int id)
        {

            var cityToReturn = CityDataStore.current.Cities
                .Where(c => c.Id == id).FirstOrDefault();

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }


    }
}
