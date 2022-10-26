class Program
{
    static void Main(string[] args)
    {
        Random numero = new Random();

        int aleatorio = numero.Next(0, 100);

        int minumero;

        int intentos = 0;

        Console.WriteLine("Introduce un número entre 0 y 100:");


        do{
            intentos++;

            minumero = int.Parse(Console.ReadLine());

            if (minumero > aleatorio) Console.WriteLine("El número es más bajo");
            if (minumero < aleatorio) Console.WriteLine("El número es menos bajo");

        } while (aleatorio != minumero);
            Console.WriteLine($"Lo has conseguido en {intentos} intentos");
    }
}
