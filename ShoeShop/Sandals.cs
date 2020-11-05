namespace ShoeShpe
{
    public class Sandals : IShoe
    {
        private string _size;
        public string Type
        {
            get
            {
                return "Sandals";
            }
        }

        public string Colour
        {
            get
            {
                return "Purple";
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
                return 19;
            }
        }

        public Sandals(string selectedSize)
        {
            _size = selectedSize;
        }
    }
}