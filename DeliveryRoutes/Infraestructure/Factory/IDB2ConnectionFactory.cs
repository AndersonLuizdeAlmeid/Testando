using IBM.Data.DB2.Core;
using DeliveryRoutes.Infrastructure.Factory;

namespace DeliveryRoutes.Infrastructure.Factory
{
    public interface IDB2ConnectionFactory
    {
        string ConnectionString { get; }
        DB2Connection Create();
    }

}
