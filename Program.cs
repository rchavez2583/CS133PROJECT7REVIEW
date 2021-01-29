using System;
using System.Collections.Generic;
using System.Linq;

namespace CS133PROJECT7
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageInventory Inventory = new ManageInventory();

            Code myCode = new Code();

            myCode.Section = "ABC123";
            myCode.Products = "3/4 Nails";
            myCode.Section = "ABC543";
            myCode.Products = "1 Nails";
            myCode.Section = "ABC890";
            myCode.Products = "7/8 Nails";
            myCode.Section = "ABC213";
            myCode.Products = "1/2 Nails";
            myCode.Section = "ABC387";
            myCode.Products = "6/4 Nails";
            myCode.Section = "ABC503";
            myCode.Products = "1 1/2 Nails";
            myCode.Section = "ABC990";
            myCode.Products = "1 7/8 Nails";
            myCode.Section = "ABC293";
            myCode.Products = "2 1/2 Nails";
            myCode.Section = "DEF123";
            myCode.Products = "3/4 Nails";
            myCode.Section = "DEF543";
            myCode.Products = "1 Nails";
            myCode.Section = "DEF890";
            myCode.Products = "7/8 Nails";
            myCode.Section = "DEF213";
            myCode.Products = "1/2 Nails";
            myCode.Section = "DEF387";
            myCode.Products = "6/4 Nails";
            myCode.Section = "DEF503";
            myCode.Products = "1 1/2 Nails";
            myCode.Section = "DEF990";
            myCode.Products = "1 7/8 Nails";
            myCode.Section = "DEF293";
            myCode.Products = "2 1/2 Nails";
            myCode.Section = "ASD387";
            myCode.Products = "6/4 Nails";
            myCode.Section = "ASD503";
            myCode.Products = "1 1/2 Nails";
            myCode.Section = "ASD990";
            myCode.Products = "1 7/8 Nails";
            myCode.Section = "ASD293";
            myCode.Products = "2 1/2 Nails";

            Inventory.ShowMeTheRacksNotAvailable(myCode);

            Inventory.ShowMeTheRacksAvailable();

            
            




        }
    }
}

public class ManageInventory
{

    Dictionary<int, Code> MyInventory = new Dictionary<int, Code>();

    public void ShowMeTheRacksNotAvailable(Code newCode)
    {
        int count = MyInventory.Count;

        bool doesMyInventoryAreRight = MyInventory.ContainsKey(count);

        if (!doesMyInventoryAreRight)
        {
            MyInventory.Add(count, newCode);
        }
        
    }

    public void ShowMeTheRacksAvailable()
    {
        Console.WriteLine("The Product in the section are:");
        foreach(var item in MyInventory)
        {
            Console.WriteLine("{0} has a section number of: {1}",
                              item.Value.Products,
                              item.Value.Section);
        }
    }


}
public class Code
{
    public string Products { get; set; }
    public string Section { get; set; }
}
    


