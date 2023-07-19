namespace Liskov_Substitution.Data
{
    public interface Computer<T> where T : class, Computer<T>
    {
        public string GetName();
    }
}
