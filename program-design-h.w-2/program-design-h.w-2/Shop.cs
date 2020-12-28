using Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Shop
    {
        public MyQueue<Product>[] AllProducts;

        public Shop(MyQueue<Product>[] products)
        {
            if (products == null)
            {
                this.AllProducts = new MyQueue<Product>[30];
            }
            else
            {
                this.AllProducts = products;
            }
        }

        public void ArrangeProducts(DateTime date)
        {
            for (int i = 0; i < AllProducts.Length; i++)
            {
                AllProducts[i] = SortQueue(AllProducts[i], date);
            }
            Console.WriteLine("finished");
            
        }

        private MyQueue<Product> SortQueue(MyQueue<Product> products, DateTime date)
        {
            RemoveOutdated(date,products);

            MyQueue<Product> arrangedQueue = new MyQueue<Product>();
            while (!products.IsEmpty())
            {
                int queueSize = GetSize(products);
                Product minProduct = new Product(DateTime.MaxValue, "minProduct");

                for (int j = 0; j < queueSize; j++)
                {
                    Product product = products.Remove();
                    if (product.ExperationDate <= minProduct.ExperationDate)
                    {
                        minProduct = product;
                    }
                    products.Insert(product);
                }

                for (int j = 0; j < queueSize; j++)
                {
                    Product product = products.Remove();
                    if (product.ExperationDate != minProduct.ExperationDate)
                    {
                        products.Insert(product);
                    }

                }

                arrangedQueue.Insert(minProduct);
            }
             return arrangedQueue;
        }

        private void RemoveOutdated(DateTime date,MyQueue<Product> products)
        {
            MyQueue<Product> temp = new MyQueue<Product>();

            while (!products.IsEmpty())
            {
                Product product = products.Remove();
                if (product.ExperationDate.Date >= date.Date)
                {
                    temp.Insert(product);
                }
            }
            while (!temp.IsEmpty())
            {
                products.Insert(temp.Remove());
            }
        }

        public int GetSize(MyQueue<Product> queue)

        {
            int count = 0;
            MyQueue<Product> temp = new MyQueue<Product>();
            while (!queue.IsEmpty())
            {
                temp.Insert(queue.Remove());
                count++;
            }
            while (!temp.IsEmpty())
            {
                queue.Insert(temp.Remove());
            }
            return count;
        }

    }
}
