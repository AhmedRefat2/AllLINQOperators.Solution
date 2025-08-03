using AllLINQOperators.Data;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;
using static AllLINQOperators.ListGenerators;
using System.Text.RegularExpressions;
namespace AllLINQOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Please Uncommnet region by region and read the explaination of each topic
                then, run if needed 
             */


            // Aggregate Internally 
            // Empty Use Cases 


            #region 1. What Is LINQ
            //// LINQ : Stands for => Language Integrated Query
            //// SQl => DQL , C# => [Functions]
            //// LINQ +40 Extention Methods 
            //// Extention Methods For All Collections That Implement [IEnumerable]
            //// Name As {LINQ Operators}
            //// Existed At Enumrable Class

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// Use LinQ Operators Against Data {Sequence Data}
            //// Sequnce :  Object From any Class implement [IEnumrable]
            //// Local sequnece : Static Data => L2Object
            ////                  XML Data    => L2XML
            //// Remote Sequnce : Data Base L2EF   =>  LINQ against Entity Frame work

            //List<int> EvenNumbers = Numbers.Where(N => N % 2 == 0).ToList(); // return IEnumrable Of Even Numbers 

            //foreach (int number in EvenNumbers)
            //    Console.Write($"{number} "); 
            #endregion

            #region 2. LINQ Syntax

            //// Recommned is [FLuent Syntax] => Extention Methdos
            //// Query Syntax Is Easy at [Join and GroupBy] it is said that

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region 1. Fluent Syntax (C# Functions)

            //// 1.1 Call LinQ Operators as Static Methods [By Class Name]

            //var evenNumbers= Enumerable.Where(Numbers, N => N % 2 == 0);
            //Console.WriteLine("Even NUmbers");

            //foreach (var item in evenNumbers)
            //{
            //    Console.Write(item + " ");
            //}

            //// 1.2 Call LinQ Operators as Extention Mtehods [Object Member Methods ]
            //Console.WriteLine("\nOdd NUmbers");
            //var oddNumbers = Numbers.Where(N => N % 2 == 1);

            //foreach (var item in oddNumbers)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region 2. Query Syntax [Query Expression]

            //// Like SQl Style
            //// But Write by Excution Order [Not Query Order]

            ///* 
            //3 select *
            //1 from Numbers N 
            //2 where N % 2 == 0
            // */

            //var EvenNumbers = from N in Numbers
            //                  where N % 2 == 0
            //                  select N;


            //// Must be Begin With [from]
            //// Must be End With [select] Or [GroupBy]


            #endregion

            #endregion

            #region 3. LINQ Excution Wayes [Interview Question] [Defferd Excution, Immediate Excution]

            #region Deffered Excution "Latest Version Of Data " [All Linq categories Except [3]]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // 11 12 13 14 15 

            //var OddNumbers = Numbers.Where(N => N % 2 == 1); // 1 3 5 7 9
            //// Where Is Excuted With Deffered Excution : Excute when you use The oddNumbers [last]
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var o in OddNumbers)
            //{
            //    Console.WriteLine(o); 
            //}
            #endregion

            #region Immediate Excution "Excuted Immediate" [Elements Operators, Casting Operators, Aggregate Operators]


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(N => N % 2 == 1).ToList();
            //// Where Is Excuted With Deffered Excution But ToList Excuted Immediate => So Excute NOw
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var o in OddNumbers)
            //{
            //    Console.WriteLine(o); // 1 3 5 7 9
            //}


            #endregion


            #endregion

            #region 4. Data Setup

            // The Static Files Has been Added 

            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            #endregion

            // All Linq Operators [13 Categories]

            #region 1. Restriction [Filteration] Operators - Where (Deffered Excution)

            #region Example 01 : Products Out Of Stock
            ////1. Flunet Syntax : 
            //var products = ProductList.Where(Product => Product.UnitsInStock == 0);

            //foreach (var product in products)
            //    Console.WriteLine(product);
            //// 2. Query Syntax:

            //products = from Product in ProductList
            //           where Product.UnitsInStock == 0 
            //           select Product;

            //foreach (var product in products)
            //    Console.WriteLine(product);

            #endregion

            #region Example 02 : Products In Stock and Category is Meat/Poultry
            //// 1. Flunet syntax:
            //var result = ProductList.Where(p => p.UnitsInStock != 0 && (p.Category == "Meat/Poultry"));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //result = from p in ProductList
            //         where p.UnitsInStock != 0 && p.Category == "Meat/Poultry"
            //         select p;

            //foreach (var item in result)           
            //    Console.WriteLine(item);

            #endregion

            #region Example 03 : Products Out Of Stock at First 10 Products Only [Indexed Where] 2 Overload

            // Indexed Where Valid Only at Fluent Syntax

            //var Products = ProductList.Where((Product, Index) => Index < 10 && Product.UnitsInStock == 0);

            //foreach (var Product in Products)
            //    Console.WriteLine(Product);


            #endregion

            #endregion

            #region 2. Transformation [Projection Operators] - Select - Select many ( Deffered Excution)

            #region 01
            //// 1. Fluent Syntax
            //var Result = ProductList.Select(p => p.ProductName);
            //// 2. Query Syntax
            //Result = from p in ProductList
            //         select p.ProductName;

            //foreach (var item in Result) { Console.WriteLine(item); }
            #endregion

            #region Customers Names

            //var CustmerNames = CustomerList.Select(C => C.CustomerName);
            //foreach (var name in CustmerNames) { Console.WriteLine(name); }




            #endregion

            #region Custmer Orders [SelectMany] => Poroject Coulmns But this Coulmn is [for Example Array]

            //var result = CustomerList.SelectMany(C => C.Orders);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Query Syntax
            //result = from C in CustomerList
            //         from Order in C.Orders
            //         select Order;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ProductId && Name "Anonmous Object"

            //var Result = ProductList.Select(P =>
            //    new { ProductId = P.ProductID, ProductName = P.ProductName });

            //// Object => From Anonmous Type
            //// CLR will create class at run time and override on to string  

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Query Syntax 

            //Result = from P in ProductList
            //         select new 
            //         {
            //             ProductId = P.ProductID,ProductName = P.ProductName 
            //         };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Product id ProductName, Price after Discount where Product In stock != 1

            //var DisCountedProductList = ProductList.Where(p => p.UnitsInStock != 1)
            //                                       .Select(p => new
            //                                       {
            //                                           ProductId = p.ProductID,
            //                                           ProductName = p.ProductName,
            //                                           OldPrice = p.UnitPrice,
            //                                           NewPrice = p.UnitPrice * 0.9M,
            //                                           UnitInstock = p.UnitsInStock
            //                                       });

            //foreach (var product in DisCountedProductList)
            //{   
            //    Console.WriteLine(product);
            //}

            //DisCountedProductList = from p in ProductList
            //                        where p.UnitsInStock == 0
            //                        select new
            //                        {
            //                            ProductId = p.ProductID,
            //                            ProductName = p.ProductName,
            //                            OldPrice = p.UnitPrice,
            //                            NewPrice = p.UnitPrice * 0.9M,
            //                            UnitInstock = p.UnitsInStock
            //                        };

            //foreach (var product in DisCountedProductList)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region secound Overload [Indexed Select] Product Id ,Name of 10 Produtcs valid only with [Fluent]

            //var Result = ProductList.Where((p, i) => i < 10)
            //                        .Select((p, i) => new
            //                        {
            //                            Index = i,
            //                            Id = p.ProductID,
            //                            Name = p.ProductName,

            //                        }); 
            //foreach (var item in Result) 
            //    Console.WriteLine(item);
            #endregion

            #endregion

            #region 3. Ordering Operators - OrderBy - OrderByDescinding - Reverse ( Deffered Excution)

            //var result = ProductList.OrderBy(P => P.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //result = from P in ProductList
            //         orderby P.UnitPrice 
            //         select P;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //////////////////////////////////////////////////////////////////

            //var Result2 = ProductList.OrderByDescending(P => P.UnitPrice).ThenBy(P => P.ProductID);

            //foreach (var item in Result2)
            //{
            //    Console.WriteLine(item);
            //}

            //Result2 = from P in ProductList
            //          orderby P.UnitPrice descending, P.ProductID
            //          select P;

            //foreach (var item in Result2)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////

            //var Result2 = ProductList.Where(P => P.UnitsInStock == 0).Reverse();

            //foreach (var Product in Result2) { Console.WriteLine(Product); }

            #endregion

            #region 4. Elements Operators (Immediate Excution) valid Only With Fluent Syntax

            // {First, last, FisrtOrDefault, LastOrDefault, ElementAt, ElementAtOrDefault,
            // Single, SingleOrDefault}


            #region First and FirstOrDefault
            //var result = ProductList.First();
            //// get the First Element Of The List
            //// But make Exceptions If The List Is Empty
            //// System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
            //Console.WriteLine(result);

            //List<int> Numbers = new List<int>(); 

            //////Numbers.First(); // Exception

            //Console.WriteLine( Numbers.FirstOrDefault()); // No Exception 

            //////////////////////////////////////////////////////////////////////////////

            // 2. Secound Overload Of First => return First value that matck Condition [Func]

            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //// The First Product That Out Of Stock
            //Console.WriteLine(result);

            ///////////////////////////////////////////////////////////////////////////////////


            #endregion


            // 3. ElementAt : return value Of Index

            //var result = ProductList.ElementAt(0);
            //Console.WriteLine(result);
            ////result = ProductList.ElementAt(1000000); // System.ArgumentOutOfRangeException: Index was out of range 

            //Console.WriteLine( result = ProductList.ElementAtOrDefault(10000000)); // No Exception

            //////////////////////////////////////////////////////////////////////////////////////

            //// 4. Single : return Element if The Sequnece has 1 Elemnet Only
            //// if There is More than one or Null [Exception]

            ////var Result = ProductList.Single(); // Exception

            //List<int> Numbers = new List<int>() { 1 }; Console.WriteLine(Numbers.Single()); // return 1

            //var Result3 = ProductList.SingleOrDefault(); // No Exception if Null but Exception If there is more than One Elemnet 

            ////////////////////////////////////////////////////////////////////////////////////////////////

            //var Result2 = ProductList.SingleOrDefault(P => P.UnitPrice == 2.5M); 
            //// return Element After Filteration if Is One Lement Only




            #endregion

            #region Hybird => Mix Between Query Syntax and Fluent

            //var Result3 = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select new
            //              {
            //                  P.ProductID,
            //                  P.ProductName,
            //                  P.UnitsInStock
            //              }).FirstOrDefault();

            #endregion

            #region 5. Aggregate Operators (Immediate Excution)
            // Count - Max - Min - Average - Aggregate

            #region Count

            //var CountOfProducts = ProductList.Count(); // linq Operators [Extention Methods]

            //Console.WriteLine(CountOfProducts); // all = 77

            //var CountOfUnitInStockProducts = ProductList.Count(P => P.UnitsInStock != 0);
            //Console.WriteLine(CountOfUnitInStockProducts); // UnitInStock = 72 
            #endregion

            #region Max , Min , Avg
            ////Console.WriteLine( ProductList.Max()); // Exception :  At least one object must implement IComparable.

            //var MaxProductPrice = ProductList.Max(P => P.UnitPrice);
            //Console.WriteLine(MaxProductPrice); //263.5000


            #endregion

            #region Aggregate

            //string[] Names = { "Ahmed", "Refat", "Abdelnaby" };
            //var FullName = Names.Aggregate((str1, str2) => $"{str1} {str2}");

            //Console.WriteLine(FullName); // Ahmed Refat Abdelnaby

            #endregion


            #endregion

            #region 6. Catsing Operators (Immediate Excution)

            //// 1. ToList()  // Convert The result into list
            //List<Product> UnitOutStockProducts = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //// Note : tolist make it Excute Immediate

            //// 2. ToArray() // Convert The result into Array
            //Product[] array = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //// 3. ToDictionary(func(key)) // Convert result into Dectionary

            //Dictionary<int, Product> ProdutcDictionary = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID); // func = Dictionary key
            //Dictionary<int, string> productsNameDictionary = ProductList.ToDictionary(P => P.ProductID, P => P.ProductName);

            //foreach (var item in productsNameDictionary)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //// 4. TOHashSet()
            //HashSet<Product> hashSet = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in hashSet)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Generation Operators (Deffered Excution) valid only with [Fluent Syntax] as Static methods Only

            //// Range - Empty - Repeate
            //// Call them From Class ENumerable

            //// 1. Range : Generate A Sequnce Of int values from start to end 
            //var result = Enumerable.Range(0, 100); // 0, 99
            //foreach (var item in result) { Console.Write(item + " "); }
            //Console.WriteLine();
            //// 2. Repeat : generate IEnumrable<T> of the Reapeted Value
            //var result2 = Enumerable.Repeat(2, 10); // Generate A Sequnce {2 2 2 2 2 2 2 2 2 2}
            //foreach (var item in result2) { Console.Write(item + " "); }

            //var result3 = Enumerable.Repeat(new Product(), 10);
            //// return IEnumrable Of 100 product

            // 3. Empty : return Empty Sequnce of IENUmrable<T>

            //var arryProducts = Enumerable.Empty<Product>().ToArray();

            //Product[] products = new Product[0];
            //// Both Will return an Empty Array [Product]
            //foreach (var item in arryProducts) { Console.Write(item + " "); }

            //var ListProducts = Enumerable.Empty<Product>().ToList();
            //List<Product> products1 = new List<Product>();
            //// Both will return Empty List<Product>


            #endregion

            #region 8. Set Operators [Deffered Excution]

            // UnionFamily in Sql => Union - Concat, Except, Intersect, Disticit

            //var Seq1 = Enumerable.Range(0, 100); // 0 - 99
            //var Seq2 = Enumerable.Range(50, 100); // 50 - 149
            //// 1. Intersect : The Common elmenets in The 2 Seq
            //var result = Seq1.Intersect(Seq2);
            //foreach (var item in result) { Console.Write(item + " "); }



            //// 2. Union : All The Elements Without Intersection
            //var result2 = Seq1.Union(Seq2);
            //foreach (var item in result2) { Console.Write(item + " "); }

            //// 3. Except : In Seq1 but not in seq2
            //var result3 = Seq1.Except(Seq2);
            //foreach (var item in result3) { Console.Write(item + " "); }

            //// 4. Concat : return 2 Sequences (UnionAll)
            //var result4 = Seq1.Concat(Seq2);
            //foreach (var item in result4) { Console.Write(item + " "); }

            //// 5. Distincit : remove dublication

            //var result5 = result4.Distinct();
            //foreach (var item in result4) { Console.Write(item + " "); }


            #endregion

            #region 9. Quantifier Operators - Return Boolean - Deffered Excution

            //// Any, All, SequenceEqual

            //// 1. Any
            //Console.WriteLine(ProductList.Any()); // True => return if the sequnce has elemnts or not

            //Console.WriteLine(ProductList.Any(P => P.ProductName == "Chai")); // true according to condition
            //Console.WriteLine(ProductList.Any(P => P.ProductName == "Ahmed")); // false according to condition

            //// 2. All : return true If All Values match Condition
            //Console.WriteLine(ProductList.All(P => P.UnitsInStock == 0)); // False 

            //// 3. SequenceEqual : return true if 2 sequnces is equal
            //var Seq1 = Enumerable.Range(0, 100); // 0 - 99
            //var Seq2 = Enumerable.Range(50, 100); // 50 - 149

            //Console.WriteLine(Seq1.SequenceEqual(Seq1)); // true
            //Console.WriteLine(Seq1.SequenceEqual(Seq2)); // false


            #endregion

            #region 10. Zip Operators [Zipping] - Deffered Excution

            //string[] Names = { "Salma", "Aya", "Amr", "Omar" };

            //int[] Numbers = Enumerable.Range(1, 10).ToArray();

            //char[] Chars = { 'a', 'b', 'c', 'd', 'E' };

            //// Ineed To Zip all this Arrays

            //var result = Names.Zip(Numbers);

            //foreach (var item in result) { Console.WriteLine(item); }

            /*
                (Salma, 1)
                (Aya, 2)
                (Amr, 3)
                (Omar, 4)
            */

            //var result2 = Names.Zip(Numbers, (name, number) => new { Index = number, Name = name });
            //foreach (var item in result2) { Console.WriteLine(item); }

            /*
                { Index = 1, Name = Salma }
                { Index = 2, Name = Aya }
                { Index = 3, Name = Amr }
                { Index = 4, Name = Omar }
                */

            //var result3 = Names.Zip(Numbers, Chars); 
            //foreach (var item in result3) {  Console.WriteLine(item); }

            /*
                (Salma, 1, a)
                (Aya, 2, b)
                (Amr, 3, c)
                (Omar, 4, d)
                */

            #endregion

            #region 11. Grouping operators (Deffered Excution) - GroupBy

            // GroupBy return IGrouping = key and value

            #region Grouping Products Based On Category



            //// 1.Query Syntax:

            //var Result = from P in ProductList
            //             group P by P.Category;


            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////

            //// 2. Fluent Syntax:
            //var Result2 = ProductList.GroupBy(P => P.Category);
            //foreach (var Category in Result2)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            #endregion

            #region Ex02 : return Products out of stock group by [Category] : Category Must be cotain Than 10 Eelmensts

            //// 1.Flunet Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock != 0)
            //                        .GroupBy(P => P.Category)
            //                        .Where(Category => Category.Count() > 10)
            //                        .Select(C => new { CategoryName = C.Key, CountOfproducts = C.Count() });

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category);
            //}


            /////////////////////////////////////////////////////////////////////////////////////

            //// 2. Query Syntax : 

            //var Result2 = from P in ProductList
            //              where P.UnitsInStock != 0
            //              group P by P.Category
            //              into Category
            //              where Category.Count() > 10
            //              select new
            //              {
            //                  CategoryName = Category.Key,
            //                  CountOfProducts = Category.Count(),
            //              };



            //foreach (var Category in Result2)
            //{
            //    Console.WriteLine(Category);
            //}

            #endregion

            #endregion

            #region 12. Partioning Operators - Pagination For Example (Any Online Store : We Cima Films)
            // Divide The return sequnce into more Pages (1 : 10 Products, 2 : 10 Products ........... etc)

            // Take - Take Last - Take While - Skip - Skip Last - Skip While 

            #region Take - TakeLast - Skip - SkipLast
            //// 1. Take
            //var Result = ProductList.Where(P => P.UnitsInStock != 0).Take(5); // Take the First 5 elments
            //foreach (var Unit in Result) { Console.WriteLine(Unit); }
            //Console.WriteLine("-----------------------------------");

            //// 2. TakeLast
            //var Result2 = ProductList.Where(P => P.UnitsInStock != 0).TakeLast(5); // take The last 5 elments
            //foreach (var Unit in Result2) { Console.WriteLine(Unit); }
            //Console.WriteLine("-----------------------------------");

            //// 3. Skip

            //var Result3 = ProductList.Where(P => P.UnitsInStock != 0).Skip(5); // return elmenets after 5
            //foreach (var Unit in Result3) { Console.WriteLine(Unit); }
            //Console.WriteLine("-----------------------------------");

            //// 4. SkipLast

            //var Result4 = ProductList.Where(P => P.UnitsInStock != 0).SkipLast(5); // return elmenets after 5
            //foreach (var Unit in Result4) { Console.WriteLine(Unit); }

            //Console.WriteLine("-----------------------------------");

            //// 5. Skip then Take
            //var Result5 = ProductList.Where(P => P.UnitsInStock != 0).Skip(5).Take(5); // return 5 elmenets after 5
            //foreach (var Unit in Result5) { Console.WriteLine(Unit); }

            #endregion

            #region Take While - Skip While

            //int[] Numbers = { 5, 4, 1, 5, 8, 7, 1, 2, 1, 9, 6, 5, 4};

            //// take While : Condition 
            //var result = Numbers.TakeWhile((N, i) => N > i);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " "); 
            //}

            ////////////////////////////////////////////


            //var result2 = Numbers.SkipWhile((N) => N % 3 != 0);
            //foreach (var item in result2)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #endregion

            #region 13. Let and Into [Valid Only With Query Expression]

            #region INTO : restart query With Introducing A new Range
            //// we need To Import : using System.Text.RegularExpressions; To use Regex class

            //List<string> Names = new List<string>() { "Omar", "Ali", "Sara", "Ahmed", "Mahmoud", "Kawser" };
            //// Remove Vowel :  A, O, I, U, E 
            //// "[AOUIEaouie]"  => Reqular Expression

            //var result = from N in Names
            //             select Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             into newString
            //             where newString.Length > 3
            //             select newString; // I need The Lenght > 3

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Let = INTO but  => Continuo Query without adding new Range

            //List<string> Names = new List<string>() { "Omar", "Ali", "Sara", "Ahmed", "Mahmoud", "Kawser" };


            //var result = from N in Names
            //             let newString = Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //             where newString.Length > 3
            //             select newString; // I need The Lenght > 3

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

                /* 
                   لا تنسونا من دعائكم ولا تنسوا اخواننا فى فلسطين وغزه من الدعاء  
             */

        }
    }
}
