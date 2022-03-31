using EstimaLucro.Domain.Models;
using EstimaLucro.Infra.Data.Repositories.Contrants;
using EstimaLucro.Infra.Data.Repositories.Fii.GetAll;
using System.Collections.Generic; 
using System.Threading.Tasks;

namespace EstimaLucro.Infra.Data
{
    public class FiiRepository : IFiiRepository
    {
        private readonly IGetAll _getAll;

        public FiiRepository(IGetAll getAll)
        {
            _getAll = getAll;
        }

        public async Task<IList<Fii>> GetAllAsync() => await _getAll.GetAllAsync();
    }
}
