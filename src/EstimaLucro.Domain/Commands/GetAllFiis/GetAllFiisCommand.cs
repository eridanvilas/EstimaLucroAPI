using MediatR;

namespace EstimaLucro.Domain.Commands.GetAllFiis
{
    public class GetAllFiisCommand : IRequest<GetAllFiisCommandResponse>
    {
        public GetAllFiisCommand()
        {
        }
    }
}
