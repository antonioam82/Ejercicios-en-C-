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
            catch(Exception ex) when (ex.GetType() != typeof(FormatException))
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Hubo un problema con la información introducida (el valor actual es 0)");
                minumero = 0;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Introduzca valor nemrico entre 0 y 100");
                minumero = 0;
            }
           

            if (minumero > aleatorio) Console.WriteLine("El número es más bajo");
            if (minumero < aleatorio) Console.WriteLine("El número es más alto");

        } while (aleatorio != minumero);
            Console.WriteLine($"Lo has conseguido en {intentos} intentos");
    }
}

