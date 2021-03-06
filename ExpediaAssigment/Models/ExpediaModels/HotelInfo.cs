﻿using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class HotelInfo
    {
        [JsonProperty("hotelId")]
        public string Id { get; set; }

        [JsonProperty("hotelName")]
        public string Name { get; set; }

        [JsonProperty("localizedHotelName")]
        public string LocalizedName { get; set; }

        [JsonProperty("hotelDestination")]
        public string Destination { get; set; }

        [JsonProperty("hotelDestinationRegionID")]
        public string DestinationRegionID { get; set; }

        [JsonProperty("hotelLongDestination")]
        public string LongDestination { get; set; }

        [JsonProperty("hotelStreetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("hotelCity")]
        public string City { get; set; }

        [JsonProperty("hotelProvince")]
        public string Province { get; set; }

        [JsonProperty("hotelCountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("hotelLatitude")]
        public double Latitude { get; set; }

        [JsonProperty("hotelLongitude")]
        public double Longitude { get; set; }

        [JsonProperty("hotelStarRating")]
        public string StarRating { get; set; }

        [JsonProperty("hotelGuestReviewRating")]
        public double GuestReviewRating { get; set; }

        [JsonProperty("hotelReviewTotal")]
        public int ReviewTotal { get; set; }

        [JsonProperty("hotelImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("vipAccess")]
        public bool VipAccess { get; set; }

        [JsonProperty("isOfficialRating")]
        public bool IsOfficialRating { get; set; }
    }
}
