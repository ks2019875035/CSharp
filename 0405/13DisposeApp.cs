using System;

namespace BasicClass
{
    class DisposeClass : IDisposable
    {
        // ...
        public void Dispose()
        {
            Console.WriteLine("In the Dispose ...");
            GC.SuppressFinalize(this);
        }
    }
    class DisposeApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            using (DisposeClass obj = new DisposeClass())
            {
                // ...
            }
            Console.WriteLine("End of Main");

        }
    }
}
