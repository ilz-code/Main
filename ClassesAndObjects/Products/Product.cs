namespace Products
{
    public class Product
    {
        string name;
        double price;
        int amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.price = priceAtStart;
            this.amount = amountAtStart;
        }

        public string PrintProduct()
        {
           return $"{name}, price {price}, amount {amount}";
        }

        public int ChangeQuantity(int quantityChanges)
        {
            amount += quantityChanges;
            return amount;
        }

        public double ChangePrice(double priceChanges)
        {
            price += priceChanges;
            return price;
        }
    }
}
