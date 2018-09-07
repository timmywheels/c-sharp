namespace _Inheritance
{

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating(exludeOrders: true);
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}