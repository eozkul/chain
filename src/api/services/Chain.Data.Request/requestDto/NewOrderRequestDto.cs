namespace Chain.Data.Request.requestDto
{
    public class NewOrderRequestDto
    {
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        //public Guid ProductId { get; set; }
        public int Stock { get; set; }
        public string Adress { get; set; }
    }
}
