public class Program
{
    static void Main() 
    {
        using (EcommerceContext db = new EcommerceContext())
        {

            //// Create in maniera statica di prova
            //Product prodotto1 = new Product { Name = "Scarpe Adidas", Description = "Scarpe comodissime", Price = 45 };
            //db.Add(prodotto1);
            //Product prodotto2 = new Product { Name = "Scarpe Nike", Description = "Scarpe bellissime", Price = 60 };
            //db.Add(prodotto2);
            //Product prodotto3 = new Product { Name = "Cappello Puma", Description = "Scarpe comodissime", Price = 30 };
            //db.Add(prodotto3);

            ////salvataggio prodotti nel database
            //db.SaveChanges();




            //Console.WriteLine("Recupero lista di Studenti");
            //List<Product> products = db.Product.OrderBy(student => student.Name).ToList();
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product.Name);
            //}

            Customer customer1 = new Customer("Puglisi", "Mattia", "mattia@hotmail.it");
            Customer customer2 = new Customer("Rossi", "Martio", "mariorossi@gmail.com");
            db.Add(customer1);
            db.Add(customer2);
            db.SaveChanges();


        }




    }
}