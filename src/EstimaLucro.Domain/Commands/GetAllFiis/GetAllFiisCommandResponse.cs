using EstimaLucro.Domain.Models;
using System.Collections.Generic;

namespace EstimaLucro.Domain.Commands.GetAllFiis
{
    public class GetAllFiisCommandResponse
    {
        public IList<Fii> Fiis;

        public GetAllFiisCommandResponse(IList<Fii> fiis)
        {
            Fiis = fiis;
        }
    }
}
