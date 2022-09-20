using DeliveryRoutes.Domain.DeliveryRoutes.Infrastructure.Repository;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Service
{
    public class DeliveryRoutesService
    {
        public DeliveryRoutesRepository _deliveryRoutesRepository { get; private set; }
        public DeliveryRoutesValidationService _deliveryRoutesValidationService { get; private set;}

        public DeliveryRoutesService(DeliveryRoutesRepository deliveryRoutesRepository, DeliveryRoutesValidationService deliveryRoutesValidationService)
        {
            _deliveryRoutesRepository = deliveryRoutesRepository;
            _deliveryRoutesValidationService = deliveryRoutesValidationService;
        }
    }
}