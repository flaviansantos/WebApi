using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities
{
    public class Client 
    {
        [Key]
        public int Id { get; set; }
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
