using Business.Concrete;
using Entities.Concrete;
using Entities.Enums;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Id=1,Title = "Kurk Mantolu Madonna ", Author = "Sabahattin Ali",Price=99.90M,Quantity=12 };
            Book book2 = new Book { Id = 2, Title = "Sefiller ", Author = "Victor Hugo", Price = 100.10M, Quantity = 10 };



            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Title);
            //}


            PurchaseRequest purchaseRequest = new PurchaseRequest();
            purchaseRequest.CustomerType = Entities.Enums.CustomerType.Employee;
            purchaseRequest.Books = books;
            purchaseRequest.TotalAmount = book1.Price + book2.Price;


            BookStoreManager bookStoreManager = new BookStoreManager();
            // bookStoreManager.CalculateDiscount(Entities.Enums.CustomerType.Regular, purchaseRequest.TotalAmount);
            // Console.WriteLine(bookStoreManager.CalculateDiscount(Entities.Enums.CustomerType.Regular, purchaseRequest.TotalAmount));

            // bookStoreManager.HandlePurchase(purchaseRequest);
            // Console.WriteLine(bookStoreManager.HandlePurchase(purchaseRequest));
            PurchaseResponse response = bookStoreManager.HandlePurchase(purchaseRequest);

            Console.WriteLine("Original Price: " + response.OriginalPrice);
            Console.WriteLine("Discounted Amount: " + response.DiscountedAmount);
            Console.WriteLine("Final Price: " + response.FinalPrice);

            Console.ReadLine();
        }
    }
}
