
namespace WebApi.Domain.Entities
{
    public class Client : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }
        public bool IsActive { get; set; }
        public string Document {  get; set; }
        public string DocumentType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
