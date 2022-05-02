using System;

class Aula14{
    static void Main(){

        //SE(E_L){}
        //  > < >= <= == !=
        // 10 < 5 = false;
        // 10 > 5 = true;

        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0; // boa prática de programação, inicializar com 0
        
        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine()); // operação cast' para ler a string e armazenar no variável inteira

        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());
        
        string resultado;

        res=n1+n2+n3+n4;

        // >= 60 - Aprovado
        // 59 e 40 - Recuperação
        // <40 - Reprovado

        if(res >= 60){
            if(res >= 90){ // estrutura de aninhamento
                if(res >= 99){
                    resultado="Aprovado com super louvor";
                }else{
                    resultado="Aprovado com louvor";
                }
            }else{
                resultado="Aprovado";
            }
        } else{
            if(res >= 40){
                resultado="Recuperação";
            }else{
                resultado="Reprovado";
            }
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);

    }
}