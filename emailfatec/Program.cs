using System;

class Program
{

    static void Main(string[] args)
    {

        // Pedindo ao usuário o nome completo, para geração do projeto.

        Console.WriteLine("Olá, me diga seu nome completo: ");
        string nome = Console.ReadLine();

        // Criação do e-mail:

        string[] nomedividido = nome.Split(' ');
        string primeironome = nomedividido[0];
        string ultimonome = nomedividido[nomedividido.Length - 1];
        string email = $"{primeironome.ToLower()}.{ultimonome.ToLower()}@Fatec.sp.gov.br";

        // Resultado:

        Console.WriteLine($"Seu nome completo é {nome}");
        Console.WriteLine($"Seu email é {email}");

        // Botão apertado para finalizar o programa.

        Console.ReadKey();




    }


}