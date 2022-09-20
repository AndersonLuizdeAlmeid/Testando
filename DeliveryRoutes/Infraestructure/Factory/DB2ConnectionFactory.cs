using IBM.Data.DB2.Core;
using DeliveryRoutes.Infrastructure.Factory;

namespace DeliveryRoutes.Infrastructure.Factory
{
    public class DB2ConnectionFactory : IDB2ConnectionFactory
    {
        private readonly string _connectionString;

        public DB2ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString => _connectionString;

        public DB2Connection Create()
        {
            return new DB2Connection(ConnectionString);
        }
    }
}
