using Dapper;
using EstimaLucro.Domain.Models;
using EstimaLucro.Infra.Data.Repositories.Contrants;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstimaLucro.Infra.Data
{
    public class FiiRepository : IFiiRepository
    {
        private readonly IConfiguration _configuration;
        private string _connectionString => _configuration.GetConnectionString("DefaultConnection");

        public FiiRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IList<Fii>> GetAllAsync()
        {
            using var connection = new MySqlConnection(_connectionString);

            var result = await connection.QueryAsync<Fii>(
                sql: @"SELECT * FROM tb_fii;",
                null);

            return result.ToList();
        }
    }
}
