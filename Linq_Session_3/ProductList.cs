public class ProductList
{
    public int PdId { get; set; }
    //Public string PdName {  get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int Price { get; set; }
    public int Discount { get; set; }

    public static List<ProductList> GetAll()

        {
        return new List<ProductList>()
        {
            new ProductList(){PdId=1,ProductName="mobile",ProductDescription="Electronics",Price=10000,Discount=5 },
           new ProductList(){PdId=2,ProductName="Tv",ProductDescription="Electronics",Price=10000,Discount=20 },
           new ProductList(){PdId=3,ProductName="Doll",ProductDescription="Toy",Price=100,Discount=0 },
           new ProductList(){PdId=4,ProductName="table",ProductDescription="Household",Price=1000,Discount=0 },
           new ProductList(){PdId=5,ProductName="Bag",ProductDescription="Household,",Price=700,Discount=10 },
           new ProductList(){PdId=6,ProductName="Calculator",ProductDescription="Electronics",Price=1300,Discount=0 },
             new ProductList(){PdId=7,ProductName="Cube",ProductDescription="Toy",Price=50,Discount=0 },
               

        };

}


}
