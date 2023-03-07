using ZeroMissionWebApi.Models;

namespace ZeroMissionWebApi.Services {
    public interface IRestaurantService 
    {
        public Task<List<Business>> GetRestaurants(string location, string term);  
        public Task<Business> GetRestaurantById(string id);   
    }
}
