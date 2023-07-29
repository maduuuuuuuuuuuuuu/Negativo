int numero;
Console.WriteLine("Digite um número");
Console.WriteLine("Para saber se ele é negativo ou positivo");
numero = Convert.ToInt32(Console.ReadLine()!);
if (numero < 0){
    Console.WriteLine("Este número é negativo");
}
else {
    Console.WriteLine("Seu número é positivo");
}