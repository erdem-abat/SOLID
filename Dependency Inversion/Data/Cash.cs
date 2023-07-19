namespace Dependency_Inversion.Data
{
    public class Cash : Payment<Cash>
    {
        public bool Payment()
        {
            return (PayCash());
        }

        private bool PayCash()
        {
            return true;
        }
    }
}
