using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstimaLucro.Infra.Data.Repositories.Fii.GetAll
{
    public interface IGetAll
    {
        Task<IList<Domain.Models.Fii>> GetAllAsync();
    }
}
