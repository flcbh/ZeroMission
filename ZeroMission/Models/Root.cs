namespace ZeroMissionWebApi.Models {
    public class Root {
        public List<Business> Businesses { get; set; }
        public int Total { get; set; }
        public Region Region { get; set; }
    }
}
