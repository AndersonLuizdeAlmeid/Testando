using DeliveryRoutes.Infrastructure.Factory;

namespace DeliveryRoutes.Infrastructure.Query
{
    public abstract class Query
    {
        protected readonly IDB2ConnectionFactory _connectionDB2Factory;

        protected Query(IDB2ConnectionFactory connectionDB2Factory)
        {
            _connectionDB2Factory = connectionDB2Factory;
        }
    }
}
