namespace Liskov_Substitution.Data
{
    public class Apple : Computer<Apple>
    {
        public string GetName()
        {
            return ("Apple");
        }
        public string BatteryCapacity()
        {
            return ("1000mAh");
        }
    }
}
