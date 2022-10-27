using System.ComponentModel;

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
            try
            {
                minumero = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hubo un problema con el valor introducido. Se establecerá en 0");
                minumero = 0;
            }
           

            if (minumero > aleatorio) Console.WriteLine("El número es más bajo");
            if (minumero < aleatorio) Console.WriteLine("El número es más alto");

        } while (aleatorio != minumero);
            Console.WriteLine($"Lo has conseguido en {intentos} intentos");
    }
}

