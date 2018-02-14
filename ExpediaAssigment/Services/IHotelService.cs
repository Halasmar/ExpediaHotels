using System.Threading.Tasks;
using Hotels.Models.SystemModels;

namespace Hotels.Services
{
    public interface IHotelService
    {
        Task<Offers> GetOffersAsync(SearchFilters filters);

    }
}