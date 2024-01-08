using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Teste Nokia
Console.WriteLine("Numero:");
string numero = Console.ReadLine();
Console.WriteLine("modelo:");
string modelo = Console.ReadLine();
Console.WriteLine("Imei:");
string imei = Console.ReadLine();
Console.WriteLine("memoria:");
int memoria = int.Parse(Console.ReadLine());
Nokia n1 = new Nokia(numero, modelo,   imei,memoria);
n1.Ligar();
n1.ReceberLigacao();


n1.InstalarAplicativo(nomeApp:"Telegram...");


//Teste Iphone


Iphone i1 = new Iphone(numero:"988577299", modelo:"X", imei:"9885764TVGVH", memoria:8);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo(nomeApp:"ESPN...");