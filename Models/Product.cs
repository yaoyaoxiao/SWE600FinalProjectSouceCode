using System;
namespace BigPandaBakery.Models
{
    public class Product
    {
        public int Category { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public Product(int cat, int id, string name, string image, decimal p)
        {
            Category = cat;
            ID = id;
            Name = name;
            Price = p;
            Image = image;
        }
        public Product(){}
    }

    public class ProductBread : Product
    {
        public ProductBread(int cat, int id, string name, string image, decimal p) : base(cat, id, name, image, p){} 
        public ProductBread() : base(){}
    }

    public class ProductTea : Product
    {
        public int Size { get; set; }

        public ProductTea(int cat, int id, string name, string image, decimal p, int size) : base(cat, id, name, image, p)
        {
            Size = size;
        }
        public ProductTea() : base() { }
    }

    public class ProductCake : Product
    {
        public int Size { get; set; }
        public string Color { get; set; }

        public ProductCake(int cat, int id, string name, string image, decimal p, int size, string color) : base(cat, id, name, image, p)
        {
            Size = size;
            Color = color;
        }
        public ProductCake() : base() { }
    }
}
