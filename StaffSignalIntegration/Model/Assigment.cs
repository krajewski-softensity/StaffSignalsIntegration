namespace StaffSignalsIntegration.Model
{
    public class Assigment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AsignationStart { get; set; }
        public DateTime? AsignationEnd { get; set; }
        public string Role { get; set; }
        public ProjectType Type { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeEmail { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}
