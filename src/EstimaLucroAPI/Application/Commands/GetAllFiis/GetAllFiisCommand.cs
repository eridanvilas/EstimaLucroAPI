using MediatR;

namespace EstimaLucroAPI.Application.Commands.GetAllFiis
{
    public class GetAllFiisCommand : IRequest<GetAllFiisCommandResponse>
    {
        public GetAllFiisCommand()
        {
        }
    }
}
