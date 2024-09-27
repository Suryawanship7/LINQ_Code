
public class Sellproducts {
    public int idNo { get; set; }
    public string Productname { get; set; }
    public string Productdescription { get; set; }
    public static List<Sellproducts> GetAll()
    {
        return new List<Sellproducts>()
        {
            new Sellproducts() { idNo = 0, Productname = "Mobile", Productdescription = "Electronics" },
            new Sellproducts() { idNo = 1, Productname = "Laptop", Productdescription = "Electronics" },
            new Sellproducts() { idNo = 2, Productname = "Zadu", Productdescription = "Household" },
            new Sellproducts() { idNo = 3, Productname = "doll", Productdescription = "toy" },
            new Sellproducts() { idNo = 4, Productname = "Table", Productdescription = "Household" }

        };

    }

    internal object Count()
    {
        throw new NotImplementedException();
    }
}

