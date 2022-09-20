using DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.Repository;
using DeliveryRoutes.Domain.DeliveryRoutes.Model;
using DeliveryRoutes.Infrastructure;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.Repository
{
    public class DeliveryRoutesRepository : IDeliveryRoutesRepository
    {
        private readonly DeliveryRoutesDbContext _deliveryRoutesDBContext;
        public DeliveryRoutesRepository(DeliveryRoutesDbContext dbContextDeliveryRoutes)
        {
            _deliveryRoutesDBContext = dbContextDeliveryRoutes;
        }
        
        public DeliveryRoutesEntity GetAllDeliveryRoutes ()
        {
            return _deliveryRoutesDBContext.DeliveryRoutes.First(re => re.CompanyCode > 0);
        }
    }
}