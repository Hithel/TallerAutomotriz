using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrse la Fila de la posicion");
        int filaInicial = Convert.ToInt32(Console.ReadLine()); // Coordenada fila del punto de partida

        Console.WriteLine("Ingterese la Colomna de la posicion");
        int columnaInicial = Convert.ToInt32(Console.ReadLine()); // Coordenada columna del punto de partida

        List<(int, int)> movimientosCaballo = new List<(int, int)>
        {
            (-2, 1), (-1, 2), (1, 2), (2, 1),
            (2, -1), (1, -2), (-1, -2), (-2, -1)
        };

        Console.WriteLine($"Posibles movimientos del caballo desde la posición ({filaInicial}, {columnaInicial}):");

        foreach (var movimiento in movimientosCaballo)
        {
            int nuevaFila = filaInicial + movimiento.Item1;
            int nuevaColumna = columnaInicial + movimiento.Item2;

            if (EsMovimientoValido(nuevaFila, nuevaColumna))
            {
                Console.WriteLine($"({nuevaFila}, {nuevaColumna})");
            }
        }
    }

    public static bool EsMovimientoValido(int fila, int columna)
    {
        return fila >= 0 && fila <= 7 && columna >= 0 && columna <= 7;
    }
}
