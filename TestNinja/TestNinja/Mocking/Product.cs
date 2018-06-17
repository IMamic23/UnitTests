namespace TestNinja.Mocking
{
    public class Product
    {
        private float ListPrice { get; set; }

        public float GetPrice(Customer customer)
        {
            if (customer.IsGold)
                return ListPrice * 0.7f;

            return ListPrice;
        }
    }

    public abstract class Customer
    {
        public bool IsGold { get; set; }
    }
}