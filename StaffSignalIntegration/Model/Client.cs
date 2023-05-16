using System.Net;

namespace StaffSignalsIntegration.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string IndustryName { get; set; }
    }
}
