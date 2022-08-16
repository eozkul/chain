using Chain.Common;
namespace Chain.Data.Request.requestDto
{
    public class ProductRequestDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Color Color { get; set; }
        public Dimension Dimension { get; set; }
        public int Stock { get; set; }
    }
}