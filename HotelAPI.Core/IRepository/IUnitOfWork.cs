using HotelAPI.Data;
using System.Threading.Tasks;

namespace HotelAPI.Core.IRepository
{
    public interface IUnitOfWork
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }

        Task Save();
    }
}
