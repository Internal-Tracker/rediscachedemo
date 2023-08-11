using System.Text.Json;

namespace rediscachedemoazure.error
{
    public class ErrorResponse
    {
        public int ErrorStatusCode { get; set; }
        public string? ErrorMessage { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);  
        }
    }
}
