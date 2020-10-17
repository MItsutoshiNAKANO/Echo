using System;

namespace Echo
{
    public class Echo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Echo().GetMessage(args));
        }

        public string GetMessage(string[] args)
        {
            return string.Join(" ", args);
        }
    }
}
