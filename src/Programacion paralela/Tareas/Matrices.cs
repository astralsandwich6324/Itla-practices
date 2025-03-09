using System.Text;
using System.Threading.Tasks;


namespace TareasEIteraciones{



    public class MatricesSDN{
        public static async Task Main(){
            var matrizA = new int[3,3] {{1,2,3},
                                        {4,5,6},
                                        {7,8,9}};

            var matrizB = new int[3,3] {{9,8,7},
                                        {6,5,4},
                                        {3,2,1}};

            List<Task> tareas = new List<Task>();
            for (int i=0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    tareas.Add(
                        Task.Run(() => 
                        {
                            int suma = 0;
                            for(int k = 0; k <3; k++)
                            {
                                Console.WriteLine($"fila={i}, columna={j}, k={k}");
                                suma += matrizA[i, k] * matrizB[k,j];
                            }
                        }));
                    
                }
            }

            await Task.WhenAll(tareas);
        }
    }

}