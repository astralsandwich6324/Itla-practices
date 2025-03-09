using System;
using System.Threading.Tasks;

class Program4
{/*
    static async Task Main()
    {
        
        Task parentTask = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Chef: Iniciando la preparación del plato...");

            
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Chef: Cortando las verduras...");
                Task.Delay(2000).Wait(); 
                Console.WriteLine("Chef: Verduras cortadas.");
            }, TaskCreationOptions.AttachedToParent);

            
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Chef: Cocinando la pasta...");
                Task.Delay(3000).Wait(); 
                Console.WriteLine("Chef: Pasta cocinada.");
            }, TaskCreationOptions.AttachedToParent);

            
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Chef: Preparando la salsa...");
                Task.Delay(2500).Wait();
                Console.WriteLine("Chef: Salsa preparada.");
            }, TaskCreationOptions.AttachedToParent);

            Console.WriteLine("Chef: Todos los pasos de la receta han sido iniciados.");
        });

        
        await parentTask;
        Console.WriteLine("Chef: ¡El plato está listo para servir!");
    }*/
}