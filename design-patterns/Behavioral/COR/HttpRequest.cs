using System.Text.Json;

namespace design_patterns.Behavioral.COR
{
    internal class HttpRequest : IRequest
    {
        public Dictionary<string, string> Headers { get; set; }
        public Dictionary<string, string> Params { get; set; }

        public HttpRequest()
        {
            Headers = new Dictionary<string, string>();
            Params = new Dictionary<string, string>();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
