using System;
using ClassLibrary;
namespace _6Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How much product do you want to add?");
            int arrayCount = Convert.ToInt32(Console.ReadLine());
            Store store = new Store();
            for (int i = 0; i < arrayCount; i++)
            {
                Console.WriteLine("Write  name:");
                string productName = Console.ReadLine();

                Console.WriteLine("Write Price:");
                double productPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write No:");
                int productNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type sort");
                foreach (var item in Enum.GetValues(typeof(StoreType)))
                {
                    Console.WriteLine( (byte)item +" "+item);
                }
                byte typeName = Convert.ToByte(Console.ReadLine());
                StoreType selectedType = (StoreType) typeName;
                while (!Enum.IsDefined(typeof(StoreType), selectedType)) 
                {
                    Console.WriteLine("Value is not match with condition:");
                    typeName = Convert.ToByte(Console.ReadLine());
                     selectedType = (StoreType)typeName;

                } ;


                Product newProduct = new Product();
                newProduct.Name = productName;
                newProduct.No = productNo;
                newProduct.Price = productPrice;
                newProduct.Type = selectedType;



                store.AddProduct(newProduct);
            }
            Console.WriteLine("Selecet filiter 1-For Type 2-For Name");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Write your Type");
                byte typeNameTwo = Convert.ToByte(Console.ReadLine());
                StoreType selectedTypeTwo = (StoreType)typeNameTwo;
                while (!Enum.IsDefined(typeof(StoreType), selectedTypeTwo))
                {
                    Console.WriteLine("Value is not match with condition:");
                    typeNameTwo = Convert.ToByte(Console.ReadLine());
                    selectedTypeTwo = (StoreType)typeNameTwo;

                };
                foreach (var item in store.FilteredProductsByType(selectedTypeTwo))
                {
                    Console.WriteLine(item.Name+" "+item.No+" "+item.Price+" "+item.Type);
                }

            }
            else if (answer == 2)
            {
                Console.WriteLine("Write name:");
                string findName = Console.ReadLine();
                foreach (var item in store.FilteredProductsByName(findName))
                {
                    Console.WriteLine(item.Name + " " + item.No + " " + item.Price + " " + item.Type);
                }
            }
            else
            {
                Console.WriteLine("this choose is not match with condition");
            }
            


        }
         
    }
}
