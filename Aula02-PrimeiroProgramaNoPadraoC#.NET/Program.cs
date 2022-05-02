using System;

namespace Aula02{
    class Program{
        static void Main(String[] args){ // args = parametro
            Console.WriteLine("Hello World!");
            if(args.GetLength(0)>0){
            Console.Write(args.GetValue(0)); // isso ja e array, pegando o indice 0..
                                             // o qual sera 'b', pois foi jogado no terminal a frase 'program b'
            }
        }
    }
}
