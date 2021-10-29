using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductsExample
{
    class DesignDemo
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Brown, Size.Huge);
            var house = new Product("House", Color.Green, Size.Large);
            var skyScraper = new Product("Skyscraper", Color.Red, Size.Huge);
            var footballPitch = new Product("Football pitch", Color.Green, Size.Large);

            Product[] products = {apple, tree, house, skyScraper, footballPitch};

            // Filter by color
            Console.WriteLine("Filter products by color (green)");
            var productFilter = new ProductFilter();
            foreach (var p in productFilter.Filter(products,
                new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(p);
            }

            // Filter by size
            Console.WriteLine("Filter products by size (Huge)");

            foreach (var p in productFilter.Filter(products, new SizeSpecification(Size.Huge)))
            {
                Console.WriteLine(p);
            }
            
            // Filter by size and color
            Console.WriteLine("Filter products by color and size (green and large)");
            foreach (var p in productFilter.Filter(products,
                new AndSpecification(
                        new ColorSpecification(Color.Green), 
                        new SizeSpecification(Size.Large))))
            {
                Console.WriteLine(p);
            }
        }
    }
}