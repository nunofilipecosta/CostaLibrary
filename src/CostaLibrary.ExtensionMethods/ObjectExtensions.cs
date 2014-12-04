
namespace CostaLibrary.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static string Get(this object obj)
        {
            return obj.GetType().AssemblyQualifiedName;
        }
    }
}
