using Avalonia.Media.Imaging;

namespace GabrielShop
{
    public class Product
    {
        private string _name;
        private string _source;
        private Bitmap _image;
        private double _price;
        private int _quantity;
        private double _cost;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string source
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }

        public Bitmap image //по-нормальному разобраться
        {
            get
            {
                return ImageHelper.LoadFromResource(source);
            }
            set
            {
                _image = ImageHelper.LoadFromResource(source);
            }
        }

        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        public double cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
    }
}