using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class AwsWafClassificationResponse : ITaskResponse
{
    [JsonRequired]
    [JsonProperty("objects")]
    public IList<int> Objects { get; set; } = null!;

    [JsonRequired]
    [JsonProperty("box")]
    public IList<float> Box { get; set; } = null!;

    [JsonProperty("distance")]
    public int? Distance { get; set; }
}
