Console.WriteLine("ciao mondo");
EcommerceDbContext db = new EcommerceDbContext();

if (db.Products.Any() == false)
    GeneraOrdine();
if (db.Employees.Any() == false)
    GeneraDipendente();
if (db.Customers.Any() == false)
    GeneraCliente();


bool loop = true;
while (loop)
{
    Console.WriteLine("Scegli la sezione: ");
    Console.WriteLine("1. Dipendente");
    Console.WriteLine("2. Cliente");
    int risposta = Convert.ToInt32(Console.ReadLine());


    switch (risposta)
    {
        case 1:
            try
            {
                bool employeeLoop = true;
                while (loop)
                {
                    Console.WriteLine("Sezione Dipendente: ");
                    Console.WriteLine("1. Stampa tutti i prodotti");
                    Console.WriteLine("2. ");
                    int employeeResponse = Convert.ToInt32(Console.ReadLine());


                    switch (employeeResponse)
                    {
                        case 1:
                            try
                            {
                                if (db.Products.Any())
                                    stampaProdotti();
                                else
                                    Console.WriteLine("Non ci sono prodotti nel database");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error: {0}", e.Message);
                            }
                            break;
                        case 2:
                            try
                            {
                               
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error: {0}", e.Message);
                            }
                            break;
                        case 3:
                            employeeLoop = false;
                            break;
                        default:
                            Console.WriteLine("Sei capace di premere un tasto?");
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: {0}", e.Message);
            }
            break;
        case 2:
            try
            {
                //CercaDocumento();
            }
            catch (Exception e)
            {
                Console.WriteLine("error: {0}", e.Message);
            }
            break;
        case 3:
            loop = false;
            break;
        default:
            Console.WriteLine("Sei capace di premere un tasto?");
            break;

    }
}


void GeneraOrdine()
{
 
    Product product = new Product();

    product.Name = "Orologio";
    product.Description = "Un oggetto che serve per misurare il tempo";
    product.Price = 130.50;
    db.Products.Add(product);

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
}

void GeneraDipendente()
{
    Employee employee = new Employee();

    employee.Name = "Mario";
    employee.Surname = "Bianchi";
    employee.Level = "Buyer";
    db.Employees.Add(employee);
    db.SaveChanges();
}

void GeneraCliente()
{
    Customer customer = new Customer();

    customer.Name = "Alfonso";
    customer.Surname = "Rossi";
    customer.Email = "alfonso@mail.it";
    db.Customers.Add(customer);
    db.SaveChanges();
}


void stampaProdotti()
{
    List<Product> products = db.Products.ToList<Product>();
    foreach (Product item in products)
    {
        Console.WriteLine("nome prodotto: " + item.Name);
        Console.WriteLine("descrizione: " + item.Description);
        Console.WriteLine("Prezzo: " + item.Price + "$\r\n");
    }
}

