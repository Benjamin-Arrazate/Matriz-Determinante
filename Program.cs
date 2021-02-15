using System;

namespace Matriz_Determinante
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,] { { 1, 3, 5 }, { 2, 4, 6 }, { 3, 5, 9}  };

            for (int i = 0; i <= 2; i++)
            {
                string line = "";

                for (int j = 0; j <= 2; j++)
                {
                    line = line + array2D[i, j] + " ";
                }    

                Console.WriteLine(line);
            }

                int Operacion1 = array2D[0,0] * array2D[1,1] * array2D[2,2];
                int Operacion2 = array2D[0,1] * array2D[1,2] * array2D[2,0];
                int Operacion3 = array2D[0,2] * array2D[1,0] * array2D[2,1];
                
                int Operacion4 = array2D[2,0] * array2D[1,1] * array2D[0,2];
                int Operacion5 = array2D[2,1] * array2D[1,2] * array2D[0,0];
                int Operacion6 = array2D[2,2] * array2D[1,0] * array2D[0,1];

                int SumaNumero1 = Operacion1 + Operacion2 + Operacion3;
                int sumaNumero2 = Operacion4 + Operacion5 + Operacion6; 

                Console.WriteLine("El determinante de la Matriz es " + (SumaNumero1 - sumaNumero2)); 


        }
    }
}
