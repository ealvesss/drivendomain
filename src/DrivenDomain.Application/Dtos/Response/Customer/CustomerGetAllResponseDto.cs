namespace DrivenDomain.Application.Dtos.Response.Customer;

public class CustomerGetAllResponseDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Document { get; set; }
    public string Address { get; set; }
    public string Type { get; set; }
}