using System.Linq;

namespace TestHomework
{
    internal class Program
    {
        #region ClothesSearchByKeyWord

        public interface IProduct
        {
            string Name { get; }
            int Price { get; }
            string Type { get; }
            string[] KeyWords { get; }
        }

        public class Clothes : IProduct
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Type { get; set; }
            public int Size { get; set; }
            public string[] KeyWords { get; set; }

        }

        public class Shoes : IProduct
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Type { get; set; }
            public int Size { get; set; }
            public string Season { get; set; }
            public string[] KeyWords { get; set; }
        }

        public class SearchForProduct
        {

            private List<IProduct> products;

            public SearchForProduct(List<IProduct> products)
            {
                this.products = products;
            }

            public List<IProduct> SearchProducts(string keyword)
            {
                List<IProduct> results = new List<IProduct>();

                foreach (IProduct product in products)
                {
                    if (product.KeyWords.Contains(keyword))
                    {
                        results.Add(product);
                    }
                }

                return results;

            }
        }

        #endregion

        #region NestedTypes

        public class ClothesElement
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public Producer Producer { get; set; }

        }

        public class Producer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }


        #endregion

        public class Stack<T>
        {
            private int index;
            public T[] elements = new T[10];

            public void Push(T item)
            {
                elements[index++] = item;
            }


            public T Pop(T item)
            {
                return elements[--index];
            }

            public T Peek(T item)
            {
                return elements[index - 1];
            }

            public void Clear()
            {

            }

            public int Count
            {
                get { return elements.Length; }
            }


        }

        static void Main(string[] args)
        {

            Stack<int> updatedStack = new Stack<int>();

            updatedStack.Push(5);
            updatedStack.Pop(5);
            updatedStack.Peek(10);
            updatedStack.Clear();
            int countStack = updatedStack.Count;
            Console.WriteLine(countStack);





            #region NestedTypes

            Producer designer = new Producer { FirstName = "Karl", LastName = "Lagerfeld" };
            ClothesElement dress = new ClothesElement { Type = "Classic", Name = "Wedding dress", Producer = designer };
            Console.WriteLine(dress.Producer.FirstName);
            Console.WriteLine(dress.Producer.LastName);


            #endregion

            #region MainImplementationOfClotherSearch

            Clothes jeans = new Clothes
            {
                Name = "Jeans",
                Price = 10,
                Type = "Skinny",
                Size = 38,
                KeyWords = new string[] { "Skinny", "Black", "High-waist" }

            };
            Shoes sandals = new Shoes
            {
                Name = "Sandals",
                Price = 30,
                Type = "Low-Heels",
                Size = 39,
                Season = "Summer",
                KeyWords = new string[] { "Flat", "Yellow" }
            };

            var products = new List<IProduct>
            {
                jeans,
                sandals
            };

            SearchForProduct productSearch = new SearchForProduct(products);

            var result = productSearch.SearchProducts("Black");

            foreach (var product in result)
            {
                Console.WriteLine(product.Name);
            }

            #endregion


        }
    }
}
        