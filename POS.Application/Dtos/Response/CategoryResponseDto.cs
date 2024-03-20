namespace POS.Application.Dtos.Response
{
    public class CategoryResponseDto
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime AuditCreateDate { get; set; }
        public int State { get; set; }
        public string? StateCategory {  get; set; }
    }
}
