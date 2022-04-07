using EstimaLucro.Domain.Models;
using EstimaLucro.Infra.Data.Repositories.Contrants;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EstimaLucro.Domain.Commands.GetAllFiis
{
    public class GetAllFiisHandler : IRequestHandler<GetAllFiisCommand, GetAllFiisCommandResponse>
    {
        private readonly IMediator _mediator;
        private readonly IFiiRepository _fiiRepository;


        //TODO REPOSITORY FII
        public GetAllFiisHandler(IMediator mediator, IFiiRepository fiiRepository)
        {
            _mediator = mediator;
            _fiiRepository = fiiRepository;
        }

        public async Task<GetAllFiisCommandResponse> Handle(GetAllFiisCommand request, CancellationToken cancellationToken)
        {
            IList<Fii> fiisList = await _fiiRepository.GetAllAsync();

            var response = new GetAllFiisCommandResponse(fiisList);
            return response;
        }
    }
}
