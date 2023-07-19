namespace Open_Closed.Data
{
    public class Package : Deci<Package>
    {
        int cm = 15 * 15 * 10;
        public int CalculateDeci()
        {
            return (cm);
        }
    }
}
