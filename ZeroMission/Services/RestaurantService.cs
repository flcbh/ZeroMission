using ZeroMissionWebApi.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ZeroMissionWebApi.Services {
    public class RestaurantService : IRestaurantService {

        IConfiguration _configuration;

        public RestaurantService(IConfiguration configuration) { 
            _configuration = configuration;
        }
        public async Task<Business> GetRestaurantById(string id) {

            Business business = new Business();

            Uri uriAssets = new Uri($"https://api.yelp.com/v3/businesses/{id}");

            var client = new HttpClient();

            client.BaseAddress = uriAssets;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_configuration.GetValue<string>("Token")}");

            var response = await client.GetAsync(uriAssets);

            if (response.IsSuccessStatusCode) {

                string result = await response.Content.ReadAsStringAsync();
                business = JsonConvert.DeserializeObject<Business>(result);
            }
            else {

                throw new KeyNotFoundException($"Could not execute search, try specifying a more exact ID. {response.StatusCode}");
            }

            return business;

        }

        /// <summary>
        /// Get restaurants list
        /// </summary>
        /// <param name="location">never can be null</param>
        /// <param name="term"></param>
        /// <returns>List</returns>
        public async Task<List<Business>> GetRestaurants(string location, string term) {


            List<Business> list = new List<Business>();
            Root root = new Root();


            Uri uriAssets = new Uri(MountUri(location, term));

            var client = new HttpClient();

            client.BaseAddress = uriAssets;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_configuration.GetValue<string>("Token")}");

            var response = await client.GetAsync(uriAssets);

            if (response.IsSuccessStatusCode) {

                string result = await response.Content.ReadAsStringAsync();
                root = JsonConvert.DeserializeObject<Root>(result);
            }
            else {

                throw new KeyNotFoundException($"Could not execute search, try specifying a more exact location. {response.StatusCode}");
            }

            return root.Businesses;
        }

        /// <summary>
        /// Assemble URL based on parameters.
        /// </summary>
        /// <param name="location">never can be null</param>
        /// <param name="term"></param>
        /// <returns>URL</returns>
        private string MountUri(string location, string term) {

            string url = string.Empty;

            if (!string.IsNullOrEmpty(term)) {

                url = $"https://api.yelp.com/v3/businesses/search?location={location}&term={term}&categories=Restaurants"; // &sort_by=best_match&limit=20";
            }
            else if (string.IsNullOrEmpty(term)) {

                url = $"https://api.yelp.com/v3/businesses/search?location={location}&categories=Restaurants"; // &sort_by=best_match&limit=20";
            }

            return url;
        }
    }
}
