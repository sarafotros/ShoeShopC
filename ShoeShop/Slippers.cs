namespace ShoeShpe
{
    public class Slippers : IShoe
    {
        private string _size;
        public string Type
        {
            get
            {
                return "Slippers";
            }
        }

        public string Colour
        {
            get
            {
                return "Red";
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
                return 8;
            }
        }
        
        public Slippers(string selectedSize)
        {
            _size = selectedSize;
        }
    }
}