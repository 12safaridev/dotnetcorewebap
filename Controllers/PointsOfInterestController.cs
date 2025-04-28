using CityInfo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {

        [HttpGet()]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterest(int cityId)
        {
            var city = CityDataStore.current.Cities
                .Where(c => c.Id == cityId).FirstOrDefault();
           
            if (city == null)
            {
                return NotFound();
            }           

            return Ok(city.PointOfInterest);
        }

        [HttpGet("{pointofinterestid}")]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            var city = CityDataStore.current.Cities
                .Where(c => c.Id == cityId).FirstOrDefault();

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointOfInterest
                .Where(p => p.Id == pointOfInterestId);
            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }


    }
}
