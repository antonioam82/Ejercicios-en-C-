using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

// PROGRAMACIÓN ASINCRONA

Stopwatch sw = Stopwatch.StartNew();


//TASK 1
var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task1: {crono.Elapsed}");

});

var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task2: {crono.Elapsed}");

});

var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task3: {crono.Elapsed}");

});
var task4 = new Task(async () =>
{
    var str = await RandomAsync();
    Console.WriteLine(str);
});

task1.Start();
task2.Start();
task3.Start();
task4.Start();

await task1;
await task2;
await task3;




sw.Stop();
Console.WriteLine($"Todo main: {sw.Elapsed}");

static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    //Thread.Sleep(1000);
    sw.Stop();
    var str = $"{num.ToString()} calculado en {sw.Elapsed}";
    //Console.WriteLine(str);
    return str;

}
