//Console.WriteLine("Entre com um número inteiro: ");
//int x = int.Parse(Console.ReadLine());

//if(x %2 == 0) {
//    Console.WriteLine("Par!");
//}
//else {
//    Console.WriteLine("Impar!");
//}

Console.WriteLine("Qual a hora atual? ");
int hora = int.Parse(Console.ReadLine());

if (hora < 12) {
    Console.WriteLine("Bom dia!");
}
else if (hora < 18) {
    Console.WriteLine("Boa Tarde");
}
else{
    Console.WriteLine("Boa Noite!");
}