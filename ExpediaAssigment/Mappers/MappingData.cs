using System;
using AutoMapper;
using Hotels.Models.SystemModels;

namespace ExpediaAssigment.Mappers
{
    public class MappingData : Profile
    {
        public MappingData()
        {
            CreateMap<Hotels.Models.ExpediaModels.Destination, Destination>();
            CreateMap<Hotels.Models.ExpediaModels.Hotel, Hotel>();
            CreateMap<Hotels.Models.ExpediaModels.HotelPricingInfo, HotelPricingInfo>();
            CreateMap<Hotels.Models.ExpediaModels.OfferInfo, OfferInfo>();
            CreateMap<Hotels.Models.ExpediaModels.Offers, Offers>();
            CreateMap<Hotels.Models.ExpediaModels.Persona, Persona>();
            CreateMap<Hotels.Models.ExpediaModels.UserInfo, UserInfo>();

            CreateMap<Hotels.Models.ExpediaModels.HotelUrgencyInfo, HotelUrgencyInfo>()
                .ForMember(
                    dest => dest.LastBookedTime,
                    opts => opts.MapFrom(src => ((long)src.LastBookedTime).ToString()));

            CreateMap<Hotels.Models.ExpediaModels.HotelInfo, HotelInfo>()
                .ForMember(
                    dest => dest.Image,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.ImageUrl))));

            CreateMap<Hotels.Models.ExpediaModels.HotelUrls, HotelUrls>()
                .ForMember(
                    dest => dest.Infosite,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.InfositeUrl)))
                ).ForMember(
                    dest => dest.SearchResult,
                    opts => opts.MapFrom(src => new Uri(Uri.UnescapeDataString(src.SearchResultUrl)))
                );

            CreateMap<Hotels.Models.ExpediaModels.OfferDate, OfferDate>()
                .ForMember(
                    dest => dest.TravelEndDate,
                    opts => opts.MapFrom(src => new DateTime(src.TravelEndDate[0], src.TravelEndDate[1], src.TravelEndDate[2]))
                ).ForMember(
                    dest => dest.TravelStartDate,
                    opts => opts.MapFrom(src => new DateTime(src.TravelStartDate[0], src.TravelStartDate[1], src.TravelStartDate[2]))
                );
        }

    }
}
