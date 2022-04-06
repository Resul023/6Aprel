using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
         Product[] _products = new Product[0];
        public Product[] Products { get; set; }

        public void AddProduct(Product Product) 
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length-1]= Product;
            

        }
        public void RemoveProductByNo(int RemoveNo) 
        {
            int count = 0;
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == RemoveNo)
                {
                    for (int j = i;  j< _products.Length-1; j++)
                    {
                        _products[j] = _products[j + 1];
                    }
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Your number is not exist this array ");
            }
            else
            {
                for (int i = 0; i < _products.Length-1 ; i++)
                {
                    Console.WriteLine($"{_products[i].Name}-{_products[i].No}-{_products[i].Price}-{_products[i].Type}");
                }
            }  
        
        }
        public Product[] FilteredProductsByType(StoreType Type) 
        {
            Product[] newProductForType = new Product[0];

            foreach (var product in _products)
            {
                if (product.Type == Type )
                {
                    Array.Resize(ref newProductForType, newProductForType.Length + 1);
                    newProductForType[newProductForType.Length - 1] = product; 
                }
            }
             return newProductForType;

        }

        public Product[] FilteredProductsByName(string Name)
        {
            Product[] newProductForName = new Product[0];

            foreach (var product in _products)
            {
                if (product.Name == Name)
                {
                    Array.Resize(ref newProductForName, newProductForName.Length + 1);
                    newProductForName[newProductForName.Length - 1] = product;
                }
            }
            return newProductForName;

        }


    }
}
