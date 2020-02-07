using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first=0,second=1,A,i,n;
   
            Console.Write("Ingrese un nro: ");
            n = Convert.ToInt32(Console.ReadLine());    
            Console.Write("Estos son {0} números de la serie de Fibonacci : \n",n);
            Console.Write("{0}  {1}", first,second);
            
            for(i=3;i<=n;i++)
            {
                A=first+second;
                Console.Write(" {0} ",A);
                first=second;
                second=A;
            }
            Console.Write("\n");
            
        }
    }
}
