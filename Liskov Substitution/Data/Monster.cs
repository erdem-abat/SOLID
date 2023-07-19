namespace Liskov_Substitution.Data
{
    public class Monster : Computer<Monster>
    {
        public string GetName()
        {
            return ("Monster");
        }
        public int Cost()
        {
            return (500);
        }
    }
}
