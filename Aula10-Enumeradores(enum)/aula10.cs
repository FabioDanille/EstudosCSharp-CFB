using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}; // tipo?..
    static void Main(){

            // DiasSemana ds = DiasSemana.Quarta; 
            
            // ou...

            DiasSemana ds = (DiasSemana)3; // '3' é o índice que levará à quarta-feira

            // também poderia fazer a conversão para inteiro, nessa caso mostrará o número
            int ds1 = (int)DiasSemana.Quarta;

            Console.WriteLine(ds);
            Console.WriteLine(ds1);

    }
}