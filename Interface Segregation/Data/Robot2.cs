namespace Interface_Segregation.Data
{
    public class Robot2 : Carryable, Walkable
    {
        public void Carry()
        {
            Console.WriteLine("Robot 2 Carryable");
        }
        public void Walk()
        {
            Console.WriteLine("Robot 2 Walkable");
        }
    }
}
