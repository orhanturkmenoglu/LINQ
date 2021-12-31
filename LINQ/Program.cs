using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ : LANGUAGE INTEGRATED QUERY : DILE YERLEŞMİŞ SORGU ANLAMINA GELİR.

            /*
             *Linq güçlü bir sorgulama dilidir. Farklı veri kaynaklarınından veri sorgulamak için 
             *C# vb. programlama dillerinde kullanılır. Açılımı LINQ (Language Integrated Query). 
             */

            /*
             *Farklı veri kaynaklarından veri işlemleri için kullanılan tek satırlık sorgudur.  
             */

            /*
             *Lınq veri tabanı ile c# yazılım dili arasındaki baglantıyı kurar. 
             */

            /*
             * SQL veritabanında ki veriler üzerindeki işlemleri LINQ ile yapılır.
             * Kaydet, Güncelle, Filtrele vb. sorgular yazılması sağlanır. 
             */


            /*
             * LINQ'nun Avantajları

            Farklı veri kaynaklarında ki veriler için ortak kullanımDaha az kodOkunabilir
            KodFarklı veri kaynaklarında ki ortak sorgulama standartıDerleme esnasında nesne verilerinin kontrolünün sağlanabilmesiVerileri
            farklı koleksiyonlara dönüştürme kolaylığı
             * 
             */

            // LINQ METHODS

            List<Product> products = new List<Product>()
            {
               new Product{ProductId=1,CategoryId=1,ProductName="Asus Laptop",UnitsInStock=10,UnitsPrice=10000},
               new Product{ProductId=2,CategoryId=2,ProductName="Samsung Note 8 Edge",UnitsInStock=3,UnitsPrice=2500},
               new Product{ProductId=3,CategoryId=3,ProductName="Buzdolabı",UnitsInStock=5,UnitsPrice=10000},
               new Product{ProductId=4,CategoryId=2,ProductName="Xiomi Redmi Note 10 Pro",UnitsInStock=100,UnitsPrice=6700},
               new Product{ProductId=5,CategoryId=3,ProductName="Çamaşır Makinesi",UnitsInStock=5 ,UnitsPrice=7800},
            };


            var departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    Name = "Muhasebe",
                    Address = "İstanbul"
                },
                new Department
                {
                    Id = 2,
                    Name = "Bilgi İşlem",
                    Address = "İstanbul"
                },
                new Department
                {
                    Id = 5,
                    Name = "Hukuk",
                    Address = "İstanbul"
                }
            };


            // WhereTest(products);

            //OrderByTest(products);

            // ThenByTest(products);

            // ReverseTest();

            // GroupByTest();

            // AnyTest(products);

            //ContainsTest(products);


            // AllTest(products);

            // JoinTest(products, departments);


            //SelectTest(products);


            // ElementAtTest(products);

            // LastTest(products);

            // SingleTest(products);

            // TakeTest();

            // SkipTest();

            // TakeWhileTest(products);

            // SkipWhileTest();

            // DistinctTest(products);
            // UnionTest();

            // IntersectTest();
            // ExceptTest();

        }

        private static void ExceptTest()
        {

            // Except() Anahtar sözcüğü, iki koleksiyonda bulunan verilerin sadece ilk koleksiyonda olup ikinci koleksiyonda olmayan kayıtları listeler.

            string[] numbers1 = { "a", "b", "c", "d" };
            string[] numbers2 = { "c", "d", "e", "f" };

            var result = numbers1.Except(numbers2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void IntersectTest()
        {
            // Intersect() anahtar sözcüğü iki koleksiyonda bulunan tekrarlayan kayıtların listelenmesini sağlar.
            int[] numbers1 = { 5, 10, 20 };
            int[] numbers2 = { 20, 25, 30 };

            var result = numbers1.Intersect(numbers2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void UnionTest()
        {

            // Union() anahtar sözcüğü iki koleksiyonda bulunan verilerin tekrarlayanları olmadan, koleksiyon verilerini geri döner.

            var days1 = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            var days2 = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Sunday", "Saturday" };

            var result = days1.Union(days2);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void DistinctTest(List<Product> products)
        {
            // Distinct() anahtar sözcüğü koleksiyon içerisinde bulunan tekrarlayan kayıtların gösterilmesini engeller.

            var result = products.Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item.UnitsPrice);
            }
        }

        private static void SkipWhileTest()
        {

            // SkipWhile() anahtar sözcüğü koleksiyonda bulunan verilerin,
            // belirtilen koşul neticesinde başlangıç index'ine göre listelenmesini sağlar.

            var months = new List<string>
            {
                "February", "March", "May", "June", "July", "August", "September", "October", "November",
                "December"
            };

            var result = months.SkipWhile(x => x.Length < 9);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void TakeWhileTest(List<Product> products)
        {
            // TakeWhile() anahtar sözcüğü Koleksiyon da bulunan verilerin, belirlenen koşul neticesinde listelenmesini sağlar.

            var result = products.TakeWhile(p => p.UnitsPrice > 2500);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void SkipTest()
        {
            // Skip() anahtar sözcüğü koleksiyon içerisinde bulunan verilerin başlangıç index'ini belirler.
            // Belirlenen index numarasından sonraki verileri getirir.

            string[] months =
           {
                "February", "March", "May", "June", "July", "August", "September", "October", "November",
                "December"
            };

            var result = months.Skip(5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void TakeTest()
        {
            /*
              Take() anahtar sözcüğü koleksiyon içerisinden listelenecek olan veri adedini belirtir.
              Sql Sorgu cümleciğinde Top() anahtar sözcüğüne eş değerdir. 
             */
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numbers.Take(5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void SingleTest(List<Product> products)
        {
            // SingleOrDefault() anahtar sözcüğü koleksiyon içerisinde bulunan öğelerden tek öğe döndürür.
            // Koleksiyon boş ise varsayılan değer döner.
            // Single() anahtar sözcüğü koleksiyonda bulunan bir öğeyi alır.

            var singleOrDefault = products.SingleOrDefault(p => p.UnitsPrice == 2500);
            Console.WriteLine(singleOrDefault.ProductName);

            var single = products.Single(p => p.UnitsPrice == 2500);
            Console.WriteLine(single.ProductName);
        }

        private static void LastTest(List<Product> products)
        {

            // Last() anahtar sözcüğü bir koleksiyonda bulunan son elemanı alır. Koleksiyon boş ise null döner.
            // LastOrDefault() anahtar sözcüğü bir koleksiyonda bulunan elemanların son öğesini alır.
            // Koleksiyon boş ise varsayılan değeri döner.
            var valueLast = products.Last();
            Console.WriteLine(valueLast.ProductName);

            var result = products.LastOrDefault();
            Console.WriteLine(result.ProductName);
        }

        private static void ElementAtTest(List<Product> products)
        {

            // ElementAt() anahtar sözcüğü bir koleksiyonda bulunan verilerin index değerine göre listelenmesini sağlanır.
            // ElementAtOrDefault() anahtar sözcüğü, bir koleksiyonda bulunan verilerin index değerine göre getirilmesini sağlar.
            // Ancak verilen index değeri koleksiyon aralığı dışında ise varsayılan değeri döner.


            var result = products.ElementAt(1);
            Console.WriteLine(result.ProductName);

            var result2 = products.ElementAtOrDefault(5);
            Console.WriteLine(result2.ProductName);
        }

        private static void FirstTest(List<Product> products)
        {
            // First() anahtar sözcüğü ile koleksiyonda bulunan ilk veri geriye döner.
            // FirstOrDefault() anahtar sözcüğü koleksiyonda bulunan verilerin ilk değerini döner.
            // Eğer koleksiyonda veri yok ise Default olarak varsayılan değeri döner.
            var valueFirst = products.First(p => p.UnitsPrice == 10000);
            Console.WriteLine(valueFirst.ProductName);

            var result = products.First();
            Console.WriteLine(result.ProductName);

            var result2 = products.FirstOrDefault(p => p.UnitsPrice == 100000);
            Console.WriteLine(result2.ProductName);
        }

        private static void SelectTest(List<Product> products)
        {
            // Select() anahtar sözcüğü ile koleksiyonda bulunan elementler kullanılarak yeni bir koleksiyon oluşturulur. 
            // Select Many(): araştır.
            var result2 = products.Select(p => p.UnitsPrice * 2);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }

        private static void JoinTest(List<Product> products, List<Department> departments)
        {

            // Join() anahtar kelimesi en az iki koleksiyonun birbirleri ile matche(birleştirme) edilmesi için kullanılır.
            // Oluşan matche(birleştirme) sonucunda yeni bir koleksiyon oluşur.

            // Gruop join araştır.
            var result = products.Join(departments,
                    p => p.ProductName,
                    d => d.Name,
                    (p, d) => p.ProductName);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void AllTest(List<Product> products)
        {
            // All() anahtar sözcüğü ile koleksiyonda bulunan tüm veriler içerisinde belirlenen koşullara göre kayıt olup olmadığını döner.
            // Geriye dönen değer true ise kayıt var, false ise kayıt yok anlamındadır.


            var result = products.All(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(result);
        }

        private static void ContainsTest(List<Product> products)
        {

            // Contains() anahtar sözcüğü koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.
            // System.Linq namespace kütüphanesinde bulunur. Dönen değer tipi boolean'dır(true, false). 

            var doesContains = products.Where(p => p.ProductName.Contains("s"));
            foreach (var contain in doesContains)
            {
                Console.WriteLine(contain.ProductName);
            }
        }

        private static void AnyTest(List<Product> products)
        {
            // Any() anahtar sözcüğü koleksiyonda bulunan verilerin olup olmadığını kontrol eder.
            // Koşula uygun değer var ise True, yok ise False sonucu döner.
            var any = products.Any();
            var any2 = products.Any(p => p.UnitsPrice == 10000);
        }

        private static void GroupByTest()
        {

            // GroupBy() anahtar sözcüğü koleksiyondaki verilerin gruplanması için kullanılır.
            // System.Linq namespace kütüphanesinde bulunur.
            // lambda ile sorguları yazılır. GroupBy() metodu ile birden fazla parametre tanımlayarak gruplama yapılabilir.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var groups = numbers.GroupBy(x => x % 2);
            foreach (var group in groups)
            {
                Console.WriteLine("Group: {0}", group.Key);

                foreach (var item in group)
                    Console.WriteLine("Group Item: {0}", item);
            }
        }

        private static void ReverseTest()
        {
            // Reverse() anahtar sözcüğü System.Linq kütüphanesinde bulunur.
            // Koleksiyon içerisinde bulunan verilerin listelenme sırasını değiştirme özelliğine sahiptir.
            // Koleksiyondaki verilerin tersine sıralanmasını sağlar.
            char[] numbers = { '1', '3', '4', '2', '6', '5' };

            var result = numbers.Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void ThenByTest(List<Product> products)
        {
            // ThenBy() anahtar sözcüğü ile bir koleksiyon içerisinde çoklu sıralama yapılması için sağlanır.
            // ThenByDescending(): sıralamayı azalandan artana dogru gerçekleştirir.
            var result = products.Where(p => p.ProductName.Contains("a")).OrderBy(p => p.ProductId).ThenBy(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("******************");

            // ThenByDescending(): sıralamayı azalandan artana dogru gerçekleştirir.
            var result2 = products.Where(p => p.ProductName.Contains("a")).OrderBy(p => p.ProductId).ThenByDescending(p => p.ProductName);
            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("*************************");

            var result3 = from p in products
                          where p.ProductName.Contains("a")
                          orderby p.ProductId descending
                          select p;

            foreach (var item in result3)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void OrderByTest(List<Product> products)
        {
            // OrderBy(): bir koleksiyondaki ögelerin artan ya da azalan sıraya göre listelenmesini saglar.
            // OrderByDescending(); sıralamayı azalandan artana dogru yapar.

            var result = products.Where(p => p.CategoryId > 1).OrderBy(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


            var result2 = from p in products
                          where p.CategoryId > 1
                          orderby p.CategoryId
                          select p;

            foreach (var product in result2)
            {
                Console.WriteLine("CategoryId: " + product.CategoryId + " " + product.ProductName);
            }

            var result3 = products.Where(p => p.CategoryId > 5).OrderByDescending(p => p.ProductName);
            foreach (var product in result3)
            {
                Console.WriteLine("CategoryId: " + product.CategoryId + " " + product.ProductName);
            }
        }

        private static void WhereTest(List<Product> products)
        {
            // Where () : sorgularda filtreleme yapmak için kullanılır.Şarta uyan verileri getirir.
            // liste biçiminde geri deger dönderir.

            // lambda method
            var result = products.Where(p => p.ProductName.Contains("top"));
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("******************");

            // query syntax normal sözdizimi.
            var result2 = from p in products
                          where p.ProductName.Contains("top")
                          select p;

            foreach (var item in result2)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("********************");

            var result3 = products.Where(p => p.ProductId > 1 && p.UnitsInStock > 5);
            foreach (var item in result3)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("**********************");

            var result4 = from p in products
                          where p.ProductId > 1 && p.UnitsInStock > 5
                          select p;
            foreach (var item in result4)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("*************************");

            var result5 = products.Where(p => p.CategoryId > 5);
            foreach (var item in result5)
            {
                Console.WriteLine(item.ProductName); // null pointer expection hatası verir.
            }

        }
    }
}
