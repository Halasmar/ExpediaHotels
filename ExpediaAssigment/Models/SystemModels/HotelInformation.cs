using System;

namespace Hotels.Models.SystemModels
{
    public class HotelInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string LocalizedName { get; set; }

        public string Destination { get; set; }

        public string DestinationRegionID { get; set; }

        public string LongDestination { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string CountryCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string StarRating { get; set; }

        public double GuestReviewRating { get; set; }

        public int ReviewTotal { get; set; }

        public Uri Image { get; set; }

        public bool VipAccess { get; set; }

        public bool IsOfficialRating { get; set; }

        public Uri LocationUrl => new Uri($"https://www.google.com/maps/?q={Latitude},{Longitude}");
    }
}
