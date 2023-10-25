Stack<string> cliente = new Stack<string>();
cliente.Push("Cliente 10");
cliente.Push("Cliente 9");
cliente.Push("Cliente 8");
cliente.Push("Cliente 7");
cliente.Push("Cliente 6");
cliente.Push("Cliente 5");
cliente.Push("Cliente 4");
cliente.Push("Cliente 3");
cliente.Push("Cliente 2");
cliente.Push("Cliente 1");
var funcionario = new List<string>();
funcionario.Add("Funcionario 1");
funcionario.Add("Funcionario 2");
funcionario.Add("Funcionario 3");
funcionario.Add("Funcionario 4");
funcionario.Add("Funcionario 5");
funcionario.Add("Funcionario 6");
funcionario.Add("Funcionario 7");
funcionario.Add("Funcionario 8");
funcionario.Add("Funcionario 9");
funcionario.Add("Funcionario 10");


foreach(var clientes in cliente)
{
    Console.WriteLine(DateTime.Now + " : {0} entrou na fila de espera.",clientes);
}

Random random = new Random();

foreach(var clientes in cliente)
{
    int timeout = random.Next(1,10);

    Console.WriteLine(DateTime.Now + " : Atendendo {0}.",clientes);
    System.Threading.Thread.Sleep(1000*timeout);
    Console.WriteLine(DateTime.Now + " : {0} está sendo atendido pelo {1} com o tempo de {2} segundos.",clientes,funcionario[random.Next(10)],timeout);}

Console.WriteLine("Todos os clientes foram atendidos.");
Console.ReadLine();
