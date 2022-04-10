using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_booking_system.Model;

namespace Simple_booking_system.Data
{
    public interface IResourceService
    {
        Task<IList<Resource>> GetResourcesAsync();
        Task<Resource> GetResourceAsync(int id);
        Task AddResourceAsync(Resource resource);
    }
}