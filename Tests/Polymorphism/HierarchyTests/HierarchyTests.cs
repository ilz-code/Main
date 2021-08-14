using Hierarchy;
using Xunit;

namespace HierarchyTests
{
    public class HierarchyTests
    {
        [Fact]
        public void MakeAnimals_animals()
        {
            int result = Hierarhy.MakeAnimals().Length;
            int expect = 4;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void MakeFood_foods()
        {
            int result = Hierarhy.MakeFood().Length;
            int expect = 4;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void MakeSound_Cat()
        {
            Cat kate = new Cat("Kate", 2.78, "Home", "Tiger");
            string result = kate.MakeSound();
            string expect = " Meoww";
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Eat_correct()
        {
            Zebra zebra = new Zebra("Aty", 353.3, "Asia");
            Food food = new Vegetables(40);
            string result = zebra.Eat(food);
            string expect = " Vegetables 40";
            Assert.Equal(expect, result);
        }
        [Fact]
        public void Eat_wrong()
        {
            Zebra zebra = new Zebra("Aty", 353.3, "Asia");
            Food food = new Meat(5);
            string result = zebra.Eat(food);
            string expect = " Vegetables 5 Zebras are not eating that type of food!";
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Output_Cat()
        {
            Cat kate = new Cat("Kate", 2.78, "Home", "Tiger");
            string result = kate.Output();
            string expect = "\n Cat Home Tiger";
            Assert.Equal(expect, result);
        }
    }
}
