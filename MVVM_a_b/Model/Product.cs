namespace MVVM_a_b.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} - {Count}";
        }
    }
}
