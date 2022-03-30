using EstimaLucroAPI.Application.Models;
using System.Collections.Generic;

namespace EstimaLucroAPI.Application.Commands.GetAllFiis
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
