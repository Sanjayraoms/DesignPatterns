// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Thread t1 = new Thread(() =>
{
    TestSingleton("Foo");
});

Thread t2 = new Thread(() =>
{
    TestSingleton("Hey");
});
t1.Start();
t2.Start();
t1.Join();
t2.Join();
void TestSingleton(string v)
{
    Singleton singleton = Singleton.GetSingletonInstance(v);
    Console.WriteLine(singleton.Value);
}

Console.ReadLine();