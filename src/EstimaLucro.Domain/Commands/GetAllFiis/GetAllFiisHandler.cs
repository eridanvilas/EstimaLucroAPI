using EstimaLucro.Domain.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EstimaLucro.Domain.Commands.GetAllFiis
{
    public class GetAllFiisHandler : IRequestHandler<GetAllFiisCommand, GetAllFiisCommandResponse>
    {
        private readonly IMediator _mediator;
 

        //TODO REPOSITORY FII
        public GetAllFiisHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<GetAllFiisCommandResponse> Handle(GetAllFiisCommand request, CancellationToken cancellationToken)
        {
            IList<Fii> fiisList = _mediator.Send(GetAllQueryHandler)

            var response = new GetAllFiisCommandResponse(fiisList);
            return response;
        }
    }
}
