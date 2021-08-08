namespace Hierarchy
{
    class Vegetables : Food
    {       
        public Vegetables()
        { }

        public Vegetables(int quantity) : base(quantity)
        {
            Name = "Vegetables";
        }
    }
}
