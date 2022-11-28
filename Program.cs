// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Method1();
Method2();
Console.ReadKey();

static async Task Method1()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(" Method 1");
            // Do something
            Task.Delay(100).Wait();
        }
    });
}


static void Method2()
{
    for (int i = 0; i < 25; i++)
    {
        Console.WriteLine(" Method 2");
        // Do something
        Task.Delay(100).Wait();
    }
}