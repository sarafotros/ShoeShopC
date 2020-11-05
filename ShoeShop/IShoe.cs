namespace ShoeShpe
{
    public interface IShoe
    {
        public string Type { get; }
        public string Colour { get; }
        public string Size { get; }
        public decimal Price { get; }
    }
}