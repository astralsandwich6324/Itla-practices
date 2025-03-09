using System;
using System.Threading.Tasks;

class Program5
{/*
    static async Task Main()
    {
       
        Task task = Task.Factory.StartNew(async () =>
        {
            Console.WriteLine("Tarea principal ejecutándose.");
            await Task.Delay(1000); 
            Console.WriteLine("Tarea principal terminada.");
        }).Unwrap(); 

        
        Task siblingTask = task.ContinueWith(t =>
        {
            Console.WriteLine("Tarea hermana ejecutándose.");
            Task.Delay(500).Wait(); 
            Console.WriteLine("Tarea hermana terminada.");
        });

        
        task.ContinueWith(t =>
        {
            Console.WriteLine("Tarea0 de continuación ejecutándose.");
        });

        
        await task.ContinueWith(t =>
        {
            Console.WriteLine("Tarea1 de continuación ejecutándose.");
        });

        
        await task.ContinueWith(t =>
        {
            Console.WriteLine("Tarea2 de continuación ejecutándose.");
        }, TaskContinuationOptions.OnlyOnRanToCompletion);

        
        await Task.WhenAll(task, siblingTask).ContinueWith(t =>
        {
            Console.WriteLine("Nueva tarea de continuación ejecutándose después de la tarea principal y la tarea hermana.");
        });

        Console.WriteLine("Todas las tareas han terminado.");
    }*/
}