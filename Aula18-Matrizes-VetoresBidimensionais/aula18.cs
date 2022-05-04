using System;
class Aula18{
    static void Main(){
        //1º modo
        int[,] n=new int[3,5]; // 3 linhas e 5 colunas... a , atrás significa que é bidimensional

        /* int[,] transforma em 2 dimensões
        10 20 30 40 50 
        60 70 80 90 15
        25 35 45 55 65
        */

        n[0,0] = 10;
        n[0,1] = 20;
        n[0,2] = 30;
        n[0,3] = 40;
        n[0,4] = 50;
        
        n[1,0] = 60;
        n[1,1] = 70;
        n[1,2] = 80;
        n[1,3] = 90;
        n[1,4] = 15;

        n[2,0] = 25;
        n[2,1] = 35;
        n[2,2] = 45;
        n[2,3] = 55;
        n[2,4] = 65;
       
        Console.WriteLine(n[1,3]);
        
        //2º modo
        int[,] num = new int[2,2]{{10,20},{30,40}}; // aplicando direto as linhas e colunas

        /*
            10 20
            30 40
        */

        Console.WriteLine(num[0,1]);
        Console.WriteLine(num[0,0]);
    }
}