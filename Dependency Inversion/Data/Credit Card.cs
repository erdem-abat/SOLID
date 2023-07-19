namespace Dependency_Inversion.Data
{
    public class Credit_Card : Payment<Credit_Card>
    {
        public bool Payment()
        {
            return (Card());
        }

        private bool Card()
        {
            return false;
        }
    }
}
