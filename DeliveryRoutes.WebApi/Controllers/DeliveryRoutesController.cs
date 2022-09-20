using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryRoutes.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class DeliveryRoutesController : ControllerBase
    {
        private readonly IOperationsQueries _operationsQueries;
        private readonly IPositionsQueries _positionsQueries;
        private readonly IHttpContextHelper _httpContextHelper;
        private readonly IPointsBindingQueries _pointsBindingQueries;
        private readonly IUserData _userData;
        private readonly IMediator _mediator;

        public PointsBindingController(IOperationsQueries operationsQueries, IPositionsQueries positionsQueries, IHttpContextHelper httpContextHelper, IPointsBindingQueries pointsBindingQueries, IUserData userData, IMediator mediator)
        {
            _operationsQueries = operationsQueries;
            _positionsQueries = positionsQueries;
            _httpContextHelper = httpContextHelper;
            _pointsBindingQueries = pointsBindingQueries;
            _userData = userData;
            _mediator = mediator;
        }
    }

}