namespace Ejemplo_por_valor;

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            int c = Sumar(ref a, b);
            Console.WriteLine($"La suma de {a} y {b} es {c}");
        }

        static int Sumar(ref int a, int b)
        {
            a = 2;
        b = 4;
            return a + b;
        }
    }
