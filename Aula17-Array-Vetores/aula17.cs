using System;
class Aula17{
    static void Main(){
        int n1,n2,n3,n4,n5;

        // 1ª maneira de declarar um array
        int[] n=new int[5]; // número de array indicado como 5

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;
       
        string[] veiculos=new string[3];

        veiculos[0]="Carro";
        veiculos[1]="Avião";
        veiculos[2]="Navio";

        Console.WriteLine(n[0]);
        Console.WriteLine(veiculos[2]);


        // 2ª maneira de declarar um array
        int[] num = new int[3]{55, 77, 88};
        Console.WriteLine(num[1]);

        // 3ª maneira de declarar um array
        int[] num2 = {100, 200, 300};
        Console.WriteLine(num2[2]);

    }
}