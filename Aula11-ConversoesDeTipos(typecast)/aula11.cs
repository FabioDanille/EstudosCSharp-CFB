using System;

class Aula11{
    static void Main(){

        // caso 1
        // int n1=10;
        // float n2=n1; // conversao implicita


        // caso 2
        // float n1=10.5f;
        // int n2=(int)n1; // type cast... se não fosse assim daria erro

        // Console.WriteLine(n2);

        int vInt=10;
        short vShort=(short)vInt; // type cast

        Console.WriteLine(vShort);
    }
}