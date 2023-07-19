namespace Dependency_Inversion.Data
{
    public interface Payment<T> where T : class, Payment<T>
    {
        bool Payment();
    }
}
