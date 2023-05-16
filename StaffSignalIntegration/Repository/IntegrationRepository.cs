using System.Data;
using System.Data.SqlClient;
using StaffSignalsIntegration.Model;
using Dapper;

namespace StaffSignalsIntegration.Repository
{
    public class IntegrationRepository : IIntegrationRepository
    {
        private readonly string _connectionString;
        private readonly string _storedProcedureForEmployees;
        private readonly string _storedProcedureForClients;
        private readonly string _storedProcedureForAssignments;

        public IntegrationRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MyConnectionString");
            _storedProcedureForEmployees = configuration["StoredProcedureForEmployees"];
            _storedProcedureForClients = configuration["StoredProcedureForClients"];
            _storedProcedureForAssignments = configuration["StoredProcedureForAssignments"];
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<Employee>(_storedProcedureForEmployees, commandType: CommandType.StoredProcedure);
                employees = result.ToList();
            }

            return employees;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<Client>(_storedProcedureForClients, commandType: CommandType.StoredProcedure);
                clients = result.ToList();
            }

            return clients;
        }

        public List<Assigment> GetAssigments()
        {
            List<Assigment> assigments = new List<Assigment>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = connection.Query<Assigment>(_storedProcedureForAssignments, commandType: CommandType.StoredProcedure);
                assigments = result.ToList();
            }

            return assigments;
        }
    }
}

