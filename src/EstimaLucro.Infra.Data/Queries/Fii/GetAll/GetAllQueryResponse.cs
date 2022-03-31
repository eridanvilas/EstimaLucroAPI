namespace EstimaLucro.Infra.Data.Queries.Fii.GetAll
{
    public class GetAllQueryResponse
    {
        public GetAllQueryResponse(Domain.Models.Fii fii) => Fii = fii;
        public Domain.Models.Fii Fii;

    }
}
