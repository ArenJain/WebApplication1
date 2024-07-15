namespace WebApplication1.Models
{
    public class Organisation
    {
 
        public Guid OrganisationId { get; set; }
        public string OrganisationName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string Owner { get; set; }
        public string ReportUrl { get; set; }
        public int? ReportProgress { get; set; }
        public string ReportCurrencyCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsArchived { get; set; }
    }
}
