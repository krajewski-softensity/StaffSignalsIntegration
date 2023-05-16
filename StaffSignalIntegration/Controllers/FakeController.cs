using Microsoft.AspNetCore.Mvc;

namespace StaffSignalIntegration.Controllers
{
    [ApiController]
    [Route("fake")]
    public class FakeController : ControllerBase
    {
        private static readonly string[] FirstNames = new[] { "Michal", "Anna", "John", "Donald", "Luis" };
        private static readonly string[] LastNames = new[] { "Smith", "Bush", "Kowalsky", "Ping", "Bolivar" };
        private static readonly string[] Emails = new[] { "stone@softensity.com", "employee1@softensity.com", "just.me@softensity.com", "not.me@softensity.com" };
        private static readonly string[] Countries = new[] { "USA", "Poland", "China", "Argentina", "Mexico" };

        private readonly ILogger<FakeController> _logger;

        public FakeController(ILogger<FakeController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<SoftensityStaff> Get()
        //{
        //    return Enumerable.Range(1, 15).Select(index => new SoftensityStaff
        //    {
        //        Id = Guid.NewGuid().ToString(),
        //        FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
        //        LastName = LastNames[Random.Shared.Next(LastNames.Length)],
        //        Email = Emails[Random.Shared.Next(Emails.Length)],
        //        Country = Countries[Random.Shared.Next(Countries.Length)],
        //        PhoneNumber = Random.Shared.Next(111, 999).ToString() + Random.Shared.Next(111, 999).ToString() + Random.Shared.Next(111, 999).ToString()
        //    })
        //    .ToArray();
        //}

        //[HttpGet("{id}")]
        //public IEnumerable<SoftensityStaff> GetEmployeeById(string id)
        //{
        //    return Enumerable.Range(1, 1).Select(index => new SoftensityStaff
        //    {
        //        Id = id,
        //        FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
        //        LastName = LastNames[Random.Shared.Next(LastNames.Length)],
        //        Email = Emails[Random.Shared.Next(Emails.Length)],
        //        Country = Countries[Random.Shared.Next(Countries.Length)],
        //        PhoneNumber = Random.Shared.Next(111, 999).ToString() + Random.Shared.Next(111, 999).ToString() + Random.Shared.Next(111, 999).ToString()
        //    })
        //    .ToArray();
        //}
    }
}