using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstimaLucro.Infra.Data.Repositories.Contrants
{
    public interface IFiiRepository
    {
       Task<IList<Domain.Models.Fii>> GetAllAsync();
    }
}
