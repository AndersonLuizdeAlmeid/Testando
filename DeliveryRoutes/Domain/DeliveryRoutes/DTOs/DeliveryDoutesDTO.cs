using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryRoutes.Domain.DeliveryRoutes.DTOs
{
    public class DeliveryDoutesDTO
    {
        public short CompanyCode { get; private set; }
        public short DeliveryRouteCode { get; private set; }

        public DeliveryDoutesDTO(short companyCode, short deliveryRouteCode)
        {
            CompanyCode = companyCode;
            DeliveryRouteCode  = deliveryRouteCode;
        }
    }
}