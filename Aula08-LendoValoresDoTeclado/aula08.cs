using System;

class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        // Console.Write("Digite seu nome: ");
        // nome=Console.ReadLine();
        // Console.WriteLine("O nome digitado foi: {0}",nome);

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine()); // int.Parse() converterá a string para inteiro
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine()); // Conver.ToInt32() converterá a string para inteiro
        soma=v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1, v2, soma);
    }
}