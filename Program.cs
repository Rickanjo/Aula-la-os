Console.WriteLine("Aula explicação laço");

Console.WriteLine("Inicio.");

Console.WriteLine("Digite um valor para a tabuada");
int numero = int.Parse(Console.ReadLine()!);

int contador = 1;

while (contador <= 10 ){
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado} ");
    contador = contador + 1;

}

Console.WriteLine("Fim.\n");

//---------------------------------------------------------------------------------------------------------------------------------------

string opção = "";
int tentativas = 0;



while (opção != "X" && tentativas < 3) // != Não for 
{
    Console .WriteLine("Oi!");

    Console.Write("Digite X para sair, ou ENTER para continuar: ");
    opção  = Console.ReadLine()! .ToLower().Trim();

    //break; // break = saida forçada ou continue ão só para usar em laços  
    //continue;
    Console.WriteLine($"Você escolheu [{opção}]");

    tentativas++;
}
Console.WriteLine("\nTchau!");

//--------------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("--- Calculadora ---");








