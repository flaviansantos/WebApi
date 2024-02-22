using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities
{
    public class Product 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ProductValue { get; set; }
        public bool IsAvailable { get; set; }
    }
}
