namespace ZeroMissionWebApi.Models {
    public class Business {
        public string Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Image_url { get; set; }
        public bool Is_closed { get; set; }
        public string Url { get; set; }
        public int Review_count { get; set; }
        public List<Category> Categories { get; set; }
        public double Rating { get; set; }
        public Coordinates Coordinates { get; set; }
        public List<object> Transactions { get; set; }
        public string Price { get; set; }
        public Location Location { get; set; }
        public string Phone { get; set; }
        public string Display_phone { get; set; }
        public double Distance { get; set; }
        //------------------
        public List<string> Photos { get; set; }
        public List<Hour> Hours { get; set; }
    }

}
