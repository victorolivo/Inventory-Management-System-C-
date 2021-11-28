using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VictorJOlivoRamirez_InventoryManagementSystem2
{
    static class Inventory
    {
        //List for Products and Parts
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        

        public static void AddProduct(Product a)
        {
            Products.Add(a);
        }

        public static bool RemoveProduct(int idx)
        {
            Products.RemoveAt(idx);
            return false;
        }

        public static Product LookupProduct(int idx)
        {
            return null;
        }

        public static void UpdateProduct(int a, Product b)
        {
            Products.RemoveAt(a);
            Products.Insert(a, b);
        }

        public static void AddPart(Part a)
        {
            AllParts.Add(a);
        }

        public static bool DeletePart(Part a)
        {
            AllParts.Remove(a);
            return false;
        }

        public static Part LookupPart(int a)
        {
            return null;
        }

        public static void UpdatePart(int a, Part b)
        {
            AllParts.RemoveAt(a);
            AllParts.Insert(a, b);
        }
    }
}
