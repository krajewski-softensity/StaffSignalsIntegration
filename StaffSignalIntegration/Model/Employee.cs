using System.Diagnostics.Metrics;

namespace StaffSignalsIntegration.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CorrespondenceAddress { get; set; }
        public int CorrespondenceCountryId { get; set; }
        public string PermanentAddress { get; set; }
        public int PermanentCountryId { get; set; }
    }
}