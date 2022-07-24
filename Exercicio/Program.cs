using Exercicio.Entities; //NET 6.0
using Exercicio.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data: "); // DADOS P/ INICIO DA CLASSE CLIENT
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());  

Client cliente = new Client(name, email, date); // INSTANCIADA A CLASSE CLIENT.

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, status, cliente); // INSTANCIAÇÃO + LIGAÇÃO DO OBJETO CLIENTE AO OBJETO ORDER

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string productname = Console.ReadLine();
    Console.Write("Product price: ");
    double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productquantity = int.Parse(Console.ReadLine());

    Product product = new Product(productname, productprice); // INSTANCIAÇÃO DO PRODUTO

    OrderItem orderitem = new OrderItem(productquantity, productprice, product); //INSTANCIAÇÃO DO ORDEM ITEM + LIGAÇÃO DO OBJT PRODUCT AO ORDERITEM

    order.AddItem(orderitem); // Adicionando objetos orderitem na lista do order(Que vai fazer uma ligação dos objetos ao order)
}

Console.WriteLine("");
Console.WriteLine("Order Sumary: ");
Console.WriteLine(order);