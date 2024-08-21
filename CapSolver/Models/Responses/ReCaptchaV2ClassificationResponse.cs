using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class ReCaptchaV2ClassificationResponse : ITaskResponse
{
    [JsonRequired]
    [JsonProperty("type")]
    public string Type { get; set; } = null!;

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("objects")]
    public IList<int>? Objects { get; set; } = null!;

    [JsonProperty("hasObject")]
    public bool? HasObject { get; set; }
}