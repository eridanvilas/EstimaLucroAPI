using System.Collections.Generic;

namespace EstimaLucro.Infra.Data.Queries.Fii.GetAll
{
    public class GetAllQueryResponse
    {
        public GetAllQueryResponse(IList<Domain.Models.Fii> fiis) => Fiis = fiis;
        public IList<Domain.Models.Fii> Fiis;

    }
}
