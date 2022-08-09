namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine(i);

                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }


            for (int myValue =0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }
            
            Console.ReadLine();
        }
    }
}