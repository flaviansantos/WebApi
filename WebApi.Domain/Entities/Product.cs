
namespace WebApi.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal ProductValue { get; set; }
        public bool IsAvailable { get; set; }
    }
}
