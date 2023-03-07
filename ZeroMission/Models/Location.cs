﻿namespace ZeroMissionWebApi.Models {
    public class Location {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Zip_code { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public List<string> Display_address { get; set; }
    }
}
