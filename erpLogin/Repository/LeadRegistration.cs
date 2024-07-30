using System.Data.SqlClient;

namespace erpLogin.Repository
{
    public class LeadRegistration
    {
        private readonly IConfiguration _configuration;
        public LeadRegistration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> RegisterLead(LeadRegistration registration) 
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString") ?? "";
            using (SqlConnection connection  = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand("Upsertlead",connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LeadName",)
            }
        }
    }

}
