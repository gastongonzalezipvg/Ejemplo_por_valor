namespace Ejemplo_por_valor;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 5;
        int x;
        int c = Sumar(ref a, b, out x);
        Console.WriteLine($"La suma de {a} y {b} es {c} y x es {x}");
    }

    //la referencia a la variabla a es bidireccional.
    //la copia del valor de b es unidireccional como dato de entrada.
    //la variable x es de salida, por lo que no tiene valor inicial y se le asigna un valor dentro del método.
    static int Sumar(ref int a, int b, out int x)
    {
        a = 2;
        b = 4;

        x = 20;
        return a + b;
    }

    static bool mitryparse(string a, out int x)
    {

        try
        {
            x = int.Parse(a);
            return true;
        }
        catch (Exception e)
        {
            x = 0;

        }
        return false;
    }
}
