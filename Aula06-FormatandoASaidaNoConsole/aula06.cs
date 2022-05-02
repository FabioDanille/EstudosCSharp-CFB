using System;

class Aula06{
    static void Main(){

        int n1, n2, n3;

        n1=10; n2=20; n3=30;

        Console.Write(" n1={0} \n n2={1} \n n3={2}",n1,n2,n3); // uso de indices... 
                                                               // '\n' é o 'enter'
                                                               // '\t' é uma 'tabulacao'

        Console.Write("");

        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda=valorCompra+(valorCompra*lucro);

        Console.WriteLine();

        Console.WriteLine("Produto..........:{0,15}",produto); //'{0,15}' é o espacamento
        Console.WriteLine("Val.Compra.......:{0,15:c}",valorCompra); // ':c' é p R$ 
        Console.WriteLine("Lucro............:{0,15:p}",lucro); // ':p' é a %
        Console.WriteLine("Valor de Venda...:{0,15:c}",valorVenda);

    }
}