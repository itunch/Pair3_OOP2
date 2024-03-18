namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Aytunç");
            Console.WriteLine(isimler.Length);

            isimler.Add("Ömer");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);

            }

            //List<string> list = new List<string>();
            //Console.WriteLine(list.Count);

            Console.WriteLine("Hello, World!");
        }
    }
}
