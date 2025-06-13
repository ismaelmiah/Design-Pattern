namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = DataBase.GetInstance();
            var instance2 = DataBase.GetInstance();
            Console.WriteLine(ReferenceEquals(instance, instance2)); // True

        }
    }
}
