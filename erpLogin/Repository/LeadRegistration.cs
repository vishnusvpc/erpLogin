using erpLogin.Model;
using System.Data.SqlClient;

namespace erpLogin.Repository
{
    public class LeadReg
    {
        private readonly IConfiguration _configuration;
        public LeadReg(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> RegisterLead(LeadRegister registration) 
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString") ?? "";
            using (SqlConnection connection  = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand("Upsertlead",connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LeadName",registration.)
            }
        }
    }

}
