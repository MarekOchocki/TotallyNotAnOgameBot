namespace TotallyNotAnOgameBot.Data.Resource
{
    public class Energy
    {
        private long value;

        public Energy(long energyValue = 0)
        {
            value = energyValue;
        }

        public long getValue()
        {
            return value;
        }

        public void setValue(long energyValue)
        {
            value = energyValue;
        }
    }
}
