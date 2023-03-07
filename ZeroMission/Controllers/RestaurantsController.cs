using Microsoft.AspNetCore.Mvc;
using ZeroMissionWebApi.Models;
using ZeroMissionWebApi.Services;

namespace ZeroMissionWebApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase {

        IRestaurantService _services;
        public RestaurantsController(IRestaurantService services) {
            _services = services;
        }

        /// <summary>
        /// Endpoint get restaurants list
        /// </summary>
        /// <param name="location"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        [HttpGet("location={location}&term={term}")]
        public IActionResult Get(string location, string? term) {

            if (string.IsNullOrEmpty(location)) {
                throw new ArgumentNullException("location");
            }

            try {

                var result = _services.GetRestaurants(location, term).Result;

                if (result.Count == 0) { return NotFound(); }

                return Ok(result);
            }
            catch (Exception ex) {
                throw new Exception("There was a failure in response from this endpoint.", ex.InnerException);
            }
        }

        /// <summary>
        /// Endpoint get restaurant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        [HttpGet("{id}")]
        public IActionResult Get(string id) {

            if (string.IsNullOrEmpty(id)) {
                throw new ArgumentNullException("id");
            }

            try {

                var result = _services.GetRestaurantById(id).Result;

                return Ok(result);
            }
            catch (Exception ex) {
                throw new Exception("There was a failure in response from this endpoint.", ex.InnerException);
            }
        }
    }
}
