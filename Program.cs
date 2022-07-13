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
            //List<Product> products = db.Product.ToList();
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product.Name);
            //}


            ////CREAZIONE UTENTI
            //Customer customer1 = new Customer("Mattia", "Puglisi", "mattia@hotmail.it");
            //Customer customer2 = new Customer("Mario", "Rossi", "mariorossi@gmail.com");
            //db.Add(customer1);
            //db.Add(customer2);
            //db.SaveChanges();
            //CREAZIONE ORDINI
            //Order order1 = new Order { CustomerId = 3, Date = DateTime.Now, Status = true};
            //db.Add(order);
            //Order order2 = new Order { CustomerId = 3, Date = DateTime.Now, Status = true};
            //db.Add(order2);
            //Order order3 = new Order { CustomerId = 3, Date = DateTime.Now, Status = true };
            //db.Add(order3);
            //db.SaveChanges();

            ////Aggiunto ordini di prodotti di un customer
            //OrderProduct pivot1 = new OrderProduct(4,1,3);
            //db.Add(pivot1);
            //OrderProduct pivot2 = new OrderProduct(6,6,2);
            //db.Add(pivot2);
            //OrderProduct pivot3 = new OrderProduct(5,2,1);
            //db.Add(pivot3);
            //db.SaveChanges();


            //STAMPA ORDINI DI UN CLIENTE
            //List<Order> orders = db.Order.Where(order=>order.CustomerId == 3).ToList();
            //foreach (Order order in orders)
            //{
            //    Console.WriteLine(order.CustomerId);
            //    Console.WriteLine(order.Date);
            //    Console.WriteLine(order.Status);
            //    Console.WriteLine();
            //}

            //MODIFICARE ORDINE DI UN CLIENTE
            Order orderUpdate = db.Order.Where(order => order.CustomerId == 3).First();
            orderUpdate.Amount = 50;
            db.SaveChanges();



        }




    }
}