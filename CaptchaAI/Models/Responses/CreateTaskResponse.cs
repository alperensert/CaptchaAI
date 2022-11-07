using Newtonsoft.Json;

namespace CaptchaAI.Models.Responses;

public class CreateTaskResponse : ErrorResponse
{
    [JsonRequired]
    [JsonProperty("taskId")]
    public string TaskId { get; set; } = null!;

    [JsonRequired]
    [JsonProperty("status")]
    public string Status { get; set; } = null!;
}