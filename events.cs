
SuscriptorCalc calculadora = new SuscriptorCalc(1, 2);
calculadora.ResultadoSuma();
calculadora.ResultadoResta();

// EDITOR O PUBLISHER

public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}

public class EditorCalc
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado  ejemploEvento;

    public void Sumar(int a, int b)
    {
        if(ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La sume es {a + b}");

        }
        else
        {
            Console.WriteLine("No tienes una suscripción al evento de SUMA");
        }
    }
    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La resta es {a - b}");
        }
        else
        {
            Console.WriteLine("No tienes una suscripción al evento de RESTA");
        }
    }
    public void Saludar()
    {
        Console.WriteLine("HOLA!");
    }
}

// SUSCRIPTOR

public class SuscriptorCalc
{
    EditorCalc editor;
    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        Console.WriteLine("Se imprime el resultado de la operación");

    }
    public SuscriptorCalc(int a, int b)
    {
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EjemploEventHandler;
    }
    public void ResultadoSuma()
    {
        editor.Sumar(A, B);
    }
    public void ResultadoResta()
    {
        editor.Restar(A, B);
        editor.Saludar();
    }

}   
