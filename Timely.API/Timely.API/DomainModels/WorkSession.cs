namespace Timely.API.DomainModels
{
    public class WorkSession
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
