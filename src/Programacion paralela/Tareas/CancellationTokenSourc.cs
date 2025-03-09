using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
/**jose manuel santillan**/
class CarreraTortugas
{
    //static async Task Main(string[] args)
    //{
    //    Console.WriteLine("¡La Carrera de Tortugas Programadoras!");
    //    Console.WriteLine("¡Que comience la carrera!");

        
    //    var cts = new CancellationTokenSource();
    //    var token = cts.Token;

        
    //    var tortugas = new Dictionary<string, int>
    //    {
    //        { "Tortuga 1", 5000 },
    //        { "Tortuga 2", 7000 },
    //        { "Tortuga 3", 6000 }
    //    };

        
    //    var tareas = new List<Task>();
    //    foreach (var tortuga in tortugas)
    //    {
    //        tareas.Add(AvanzarTortuga(tortuga.Key, tortuga.Value, token));
    //    }

       
    //    var cancelTask = Task.Run(() =>
    //    {
    //        Console.WriteLine("Presiona 'c' para cancelar la carrera.");
    //        while (true)
    //        {
    //            if (Console.ReadKey(true).KeyChar == 'c')
    //            {
    //                cts.Cancel();
    //                Console.WriteLine("\n¡Carrera cancelada!");
    //                break;
    //            }
    //        }
    //    });

        
    //    await Task.WhenAll(tareas);
    //    cts.Dispose();

    //    Console.WriteLine("Presiona cualquier tecla para salir.");
    //    Console.ReadKey();
    //}

    //static async Task AvanzarTortuga(string nombreTortuga, int tiempoLimite, CancellationToken token)
    //{
    //    try
    //    {
    //        Console.WriteLine($"{nombreTortuga} está avanzando...");
    //        for (int i = 0; i <= 100; i += 20)
    //        {
    //            token.ThrowIfCancellationRequested();
    //            Console.WriteLine($"{nombreTortuga} ha avanzado {i}%...");
    //            await Task.Delay(tiempoLimite / 5, token); 
    //        }
    //        Console.WriteLine($"{nombreTortuga} ha llegado a la meta.");
    //    }
    //    catch (OperationCanceledException)
    //    {
    //        Console.WriteLine($"{nombreTortuga} ha sido eliminada de la carrera.");
    //    }
    //}
}
