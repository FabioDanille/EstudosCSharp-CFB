using System;

class Aula03{
    static void Main(){
        // tipos primitivos
        byte n1=10; //variavel que armazena 8 bytes, ou seja, entre 0 e 255
        int num=-10; // numero
        char letra='8'; // letra/número única
        float valor=5.3f; // ponto flutuante
        string nome="Bruno"; // string

        var aux=nome; // nao especifica o tipo da variavel

        // Também pode ser operado da seguinte forma
        int num1, num2, res;

        num1=10;
        num2=2;
        res = num1 * num2;

        // ou até mesmo assim:
        int num3=30,num5=200;

        Console.WriteLine("Valor da variável: " + aux);
        Console.WriteLine("");
        Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);
        Console.WriteLine("");
        Console.WriteLine("Testando. Primeiro valor é o: " + num3 + ". E o segundo valor é o: " + num5);
    }
}