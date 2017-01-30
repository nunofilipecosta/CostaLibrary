namespace CostaLibrary.Entities.Composition
{
    public class Toyota : IManufacturer
    {
        private static IManufacturer _instance;

        private Toyota()
        {
        }

        public string Name
        {
            get
            {
                return "Toyota";
            }
        }

        public static IManufacturer GetInstance()
        {
            return _instance ?? (_instance = new Toyota());
        }
    }
}