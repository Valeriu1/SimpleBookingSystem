using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simple_booking_system.DataAccess;
using Simple_booking_system.Model;

namespace Simple_booking_system.Data
{
    public class ResourceService : IResourceService
    {
        private BookingDbContext context;

        public ResourceService(BookingDbContext context)
        {
            this.context = context;
        }


        public async Task<IList<Resource>> GetResourcesAsync()
        {
            List<Resource> resources = context.Resources.ToList();
            return resources;
        }

        public async Task<Resource> GetResourceAsync(int id)
        {
            Resource resource =  context.Resources.FirstOrDefault(r => r.Id == id);
            return resource;
        }

        public async Task AddResourceAsync(Resource resource)
        {
            context.Resources.Add(resource);
             await SaveChanges();
        }


        private async Task SaveChanges()
        {
             context.SaveChangesAsync();
        }

       
    }
}