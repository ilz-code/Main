using Hierarchy;
using Xunit;

namespace HierarchyTests
{
    public class HierarchyTests
    {
        [Fact]
        public void MakeAnimals_CountOfAnimals()
        {
            int result = Hierarhy.MakeAnimals().Length;
            int expect = 4;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void MakeFood_CountOfFoods()
        {
            int result = Hierarhy.MakeFood().Length;
            int expect = 4;
            Assert.Equal(expect, result);
        }

        [Fact]
        public void MakeSound_Cat_Meoww()
        {
            //Arrange
            Cat kate = new Cat("Kate", 2.78, "Home", "Tiger");
            //Act
            string result = kate.MakeSound();
            //Assert
            string expect = " Meoww";
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Eat_Food_FoodEaten()
        {
            //Arrange
            Zebra zebra = new Zebra("Aty", 353.3, "Asia");
            Food food = new Vegetables(40);
            //Act
            string result = zebra.Eat(food);
            //Assert
            string expect = " Vegetables 40";
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Eat_WrongFood_NotEating()
        {
            //arrange
            Zebra zebra = new Zebra("Aty", 353.3, "Asia");
            Food food = new Meat(5);
            //Act
            string result = zebra.Eat(food);
            //Assert
            string expect = " Vegetables 5 Zebras are not eating that type of food!";
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Output_Cat_CatAsString()
        {
            //Arrange
            Cat kate = new Cat("Kate", 2.78, "Home", "Tiger");
            //Act
            string result = kate.Output();
            //Assert
            string expect = "\n Cat Home Tiger";
            Assert.Equal(expect, result);
        }
    }
}
