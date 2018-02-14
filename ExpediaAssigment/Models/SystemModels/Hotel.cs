namespace Hotels.Models.SystemModels
{
    public class Hotel
    {
        public OfferDate OfferDate { get; set; }

        public Destination Destination { get; set; }

        public HotelInfo HotelInfo { get; set; }

        public HotelUrgencyInfo UrgencyInfo { get; set; }

        public HotelPricingInfo PricingInfo { get; set; }

        public HotelUrls Urls { get; set; }
    }
}
