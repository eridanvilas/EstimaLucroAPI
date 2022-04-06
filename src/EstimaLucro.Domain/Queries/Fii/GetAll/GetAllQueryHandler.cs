using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EstimaLucro.Infra.Data.Repositories.Contrants;

namespace EstimaLucro.Infra.Data.Queries.Fii.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, GetAllQueryResponse>
    {
        private readonly IFiiRepository _fiiRepository;

        public GetAllQueryHandler(IFiiRepository fiiRepository)
        {
            _fiiRepository = fiiRepository;
        }

        public async Task<GetAllQueryResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var response = new GetAllQueryResponse((Domain.Models.Fii)await _fiiRepository.GetAllAsync());

            return response;
        }
    }
}
