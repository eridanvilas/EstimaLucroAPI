using MediatR;

namespace EstimaLucro.Infra.Data.Queries.Fii.GetAll
{
    public class GetAllQuery : IRequest<GetAllQueryResponse>
    {
        public GetAllQuery(Domain.Models.Fii fii) => (Fii) = fii;

        public GetAllQuery()
        {
        }

        public Domain.Models.Fii Fii { get; set; }
    }
}
