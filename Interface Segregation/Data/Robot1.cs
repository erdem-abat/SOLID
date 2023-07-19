namespace Interface_Segregation.Data
{
    public class Robot1 : Runable, Walkable
    {
        public void Run()
        {
            Console.WriteLine("Robot 1 Runnable");
        }

        public void Walk()
        {
            Console.WriteLine("Robot 1 Walkable");
        }
    }
}
