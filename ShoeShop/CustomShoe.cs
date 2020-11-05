namespace ShoeShpe
{
    public class CustomShoe : IShoe
    {
        private string _type;
        private string _colour;
        private string _size;
        private decimal _price;

        public string Type
        {
            get
            {
                return _type;
            }
        }

        public string Colour
        {
            get
            {
                return _colour;
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
                return 29;
            }
        }

        public CustomShoe(string type, string colour, string size)
        {
            _type = type;
            _colour = colour;
            _size = size;
        }
    }
}