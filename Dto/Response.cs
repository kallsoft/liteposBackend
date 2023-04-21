using System.Text.Json.Serialization;

namespace LitePosBackend.Dto
{
    public class GenericResponseDTO<T>
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("response")]
        public T Response { get; set; }
    }
}
