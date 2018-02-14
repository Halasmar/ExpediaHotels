﻿using Newtonsoft.Json;

namespace Hotels.Models.ExpediaModels
{
    public class HotelUrgencyInfo
    {
        [JsonProperty("airAttachRemainingTime")]
        public int AirAttachRemainingTime { get; set; }

        [JsonProperty("numberOfPeopleViewing")]
        public int NumberOfPeopleViewing { get; set; }

        [JsonProperty("numberOfPeopleBooked")]
        public int NumberOfPeopleBooked { get; set; }

        [JsonProperty("numberOfRoomsLeft")]
        public int NumberOfRoomsLeft { get; set; }

        [JsonProperty("lastBookedTime")]
        public object LastBookedTime { get; set; }

        [JsonProperty("almostSoldStatus")]
        public string AlmostSoldStatus { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("airAttachEnabled")]
        public bool AirAttachEnabled { get; set; }
    }
}
