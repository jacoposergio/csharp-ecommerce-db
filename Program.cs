Console.WriteLine("ciao mondo");

EcommerceDbContext db = new EcommerceDbContext();

//Product product = new Product();

//product.Name = "Orologio";
//product.Description = "Un oggetto che serve per misurare il tempo";
//product.Price = 130.50;
//db.Products.Add(product);

Product orologio = new Product() { Name = "Orologio", Description = "Un oggetto che serve per misurare il tempo", Price = 150.50 };
Product sveglia = new Product() { Name = "Sveglia", Description = "Un oggetto che serve per svegliare le pesone", Price = 100 };
Product radio = new Product() { Name = "Radio", Description = "Se non hai la tv usi questa", Price = 120.50 };
Product forno = new Product() { Name = "Forno", Description = "Ci riscaldi le cose", Price = 76 };
Product telefono = new Product() { Name = "Telefono", Description = "Chiami la gente", Price = 80 };

db.Products.Add(orologio);
db.Products.Add(sveglia);    
db.Products.Add(radio);
db.Products.Add(forno);
db.Products.Add(telefono);

db.SaveChanges();
    