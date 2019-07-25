namespace OmniSharp.Cake
{
    internal class CakeContextModel
    {
        // some change
        public CakeContextModel(string filePath)
        {
            Path = filePath;
        }

        public string Path { get; }
    }
}
