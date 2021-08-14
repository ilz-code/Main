namespace Hierarchy
{
    public abstract class Animal
    {
        public string _name;
        public double _weight;
        public int _foodEaten;        

        public Animal() { }

        public Animal(string name, double weight)
        {
            _name = name;
            _weight = weight;
            _foodEaten = 0;
        }

        public virtual string MakeSound()
        {
            return "";
        }

        public virtual string Eat(Food food)
        {
            _foodEaten = food.Quantity;
            return " " + food.Name + " " + food.Quantity;
        }

        public virtual string Output()
        {
            return $" {_name} {_weight} ";
        }
    }
}
