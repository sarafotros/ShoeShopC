namespace ShoeShpe
{
    public class Sneakers : IShoe
    {
        private string _size;
        public string Type
        {
            get
            {
                return "Sneakers";
            }
        }

        public string Colour
        {
            get
            {
                return "White";
            }
        }

        public string Size
        {
            get
            {
                return _size;
            }
        }

        public decimal Price
        {
            get
            {
                return 49;
            }
        }
        public Sneakers(string selectedSize)
        {
            _size = selectedSize;
        } 
    }
}