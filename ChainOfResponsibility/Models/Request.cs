namespace DesignPatterns.ChainOfResponsibility.Models
{
    internal class Request
    {
        public Dictionary<string, string> Arguments { get; set; } = new Dictionary<string, string>();
    }
}
