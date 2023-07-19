namespace Open_Closed.Data
{
    public interface Deci<T> where T : class, Deci<T>
    {
         int CalculateDeci();
    }
}
