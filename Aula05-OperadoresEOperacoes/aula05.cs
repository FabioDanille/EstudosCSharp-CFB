using System;

class Aula05{
    static void Main(){

        bool res=10<5;// tipo booleano, recebe VERDADEIRO ou FALSO

        Console.WriteLine(res); // irá retornar FALSE
        Console.WriteLine("");

        int num=10;

        //num++; num+=1; num=num+1;
        num+=10; //num=num+10; 

        // pode usar para + - / *

        Console.WriteLine(num); // irá retornar 20
        Console.WriteLine("");

                // & = AND / E
                // | = OR / OU
                bool res1=(5>3)|(10<5);

        Console.WriteLine(res1); // irá retornar TRUE
    }
}