using System;

namespace Hotels.Models.SystemModels
{
    public class OfferDate
    {
        public DateTime TravelStartDate { get; set; }

        public DateTime TravelEndDate { get; set; }

        public int LengthOfStay { get; set; }

        public string TravelStartDateString => TravelStartDate.ToString(ConstantData.DateFormat);

        public string TravelEndDateString => TravelEndDate.ToString(ConstantData.DateFormat);
    }
}
