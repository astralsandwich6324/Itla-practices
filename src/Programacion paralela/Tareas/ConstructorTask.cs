using System;
using System.Threading.Tasks;

class Program3
{/*
    static void Main()
    {
        
        Task<long> task1 = new Task<long>(() => CalcularSuma(1, 1000000));
        Task<long> task2 = new Task<long>(() => Multiplicar(10));
        Task<long> task3 = new Task<long>(() => CalcularPotencia(2, 20));

        
        task1.Start();
        task2.Start();
        task3.Start();

        
        Task.WaitAll(task1, task2, task3);

        
        long finalResult = task1.Result + task2.Result + task3.Result;

       
        Console.WriteLine($"El resultado final es: {finalResult}");
    }

   
    static long CalcularSuma(int start, int end)
    {
        long sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Suma calculada: {sum}");
        return sum;
    }

    
    static long Multiplicar(int n)
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Resultado de multiplicacion: {factorial}");
        return factorial;
    }

    
    static long CalcularPotencia(int baseNumber, int exponent)
    {
        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        Console.WriteLine($"Potencia calculada: {result}");
        return result;
    }*/
}