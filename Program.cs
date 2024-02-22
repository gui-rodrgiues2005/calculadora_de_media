float  nota1, nota2, nota3, media;

while (true)
{ 

    Console.WriteLine("Irforme a 'Nota1':");
    nota1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Irforme a 'Nota2':");
    nota2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Irforme a 'Nota3':");
    nota3 = float.Parse(Console.ReadLine());

    media = nota1 + nota2 + nota3/(3);

    Console.WriteLine("A sua Média É:"  +  media.ToString("0.00"));


    Console.WriteLine("Digite 'Sair' para encerrar ou 'ENTER' para  continuar:");
    string opcao = Console.ReadLine();
    if(opcao.ToLower() == "Sair")
    {
        break;
    }
}