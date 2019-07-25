namespace OmniSharp.Cake
{
    internal class CakeContextModel
    {
        // some change2
        public CakeContextModel(string filePath)
        {
            Path = filePath;
        }

        public string Path { get; }
    }
}
