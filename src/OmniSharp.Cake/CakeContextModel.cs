namespace OmniSharp.Cake
{
    internal class CakeContextModel
    {
        // some change1
        public CakeContextModel(string filePath)
        {
            Path = filePath;
        }

        public string Path { get; }
    }
}
