using System;

class Aula04{

    static int num=10; // variavel global
    static void Main(){ // por ser método static, requer que a variável global seja static também
        int num2=0; // variavel local
        Console.WriteLine("Teste no 'statis void Main()'... " + num);
    }
}