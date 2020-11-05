namespace ShoeShpe
{
    public class Oxford : IShoe
    {
        private string _size;
        public string Type
        {
            get
            {
                return "Oxford";
            }
        }

        public string Colour
        {
            get
            {
                return "Black";
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

        public Oxford(string selectedSize)
        {
            _size = selectedSize;
        }
    }
}