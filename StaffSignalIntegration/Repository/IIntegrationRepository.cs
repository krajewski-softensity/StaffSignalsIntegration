using StaffSignalsIntegration.Model;

namespace StaffSignalsIntegration.Repository
{
    public interface IIntegrationRepository
    {
        public List<Employee> GetEmployees();
        public List<Client> GetClients();
        public List<Assigment> GetAssigments();
    }
}