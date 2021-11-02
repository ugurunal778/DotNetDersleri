namespace OOPSamples.ExtensionMethod
{
    public static class StaticClass
    {
        public static int GetMod(this int intValue)
        {
            var result = intValue % 2;
            return result;
        }
    }
}
