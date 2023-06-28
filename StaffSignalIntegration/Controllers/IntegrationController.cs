using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StaffSignalsIntegration.Model;
using StaffSignalsIntegration.Repository;

namespace StaffSignalsIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IntegrationController : ControllerBase
    {
        private readonly IIntegrationRepository _integrationRepository;

        public IntegrationController(IIntegrationRepository integrationRepository)
        {
            _integrationRepository = integrationRepository;
        }

        [HttpGet("active-employees")]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _integrationRepository.GetEmployees();
            return Ok(employees);
        }

        [HttpGet("clients")]
        public ActionResult<IEnumerable<Client>> GetClients()
        {
            var clients = _integrationRepository.GetClients();
            return Ok(clients);
        }

        [HttpGet("assigments")]
        public ActionResult<IEnumerable<Assigment>> GetAssigments()
        {
            var assigments = _integrationRepository.GetAssigments();
            return Ok(assigments);
        }
    }
}

