namespace Hierarchy
{
    abstract class Food
    {
        public int Quantity;
        public string Name;

        public Food()
        {

        }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
