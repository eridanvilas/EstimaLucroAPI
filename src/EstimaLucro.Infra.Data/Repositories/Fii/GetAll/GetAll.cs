using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;

namespace EstimaLucro.Infra.Data.Repositories.Fii.GetAll
{
    public class GetAll : IGetAll
    {
        private readonly IConfiguration _configuration;
        private string _connectionString => _configuration.GetConnectionString("DefaultConnection");
        
        public GetAll(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IList<Domain.Models.Fii>> GetAllAsync()
        {
            using var connection = new MySqlConnection(_connectionString);

            return (IList<Domain.Models.Fii>)await connection.QueryAsync<Domain.Models.Fii>(
                sql: @"SELECT * FROM tb_fii;",
                null
                );
        }
    }
}
