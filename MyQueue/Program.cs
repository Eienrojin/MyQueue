namespace MyQueue
{
    class Programm
    {
        static void Main()
        {
            OtherQueue ew = new();

            ew.Enqueue(546);
            ew.Enqueue(53);
            ew.Enqueue(12);

            ew.Dequeue();
            ew.Dequeue();

            Console.WriteLine(ew.Peek());
        }
    }
}