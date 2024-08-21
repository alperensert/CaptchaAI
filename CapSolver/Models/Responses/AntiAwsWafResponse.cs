using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class AntiAwsWafResponse : ITaskResponse
{
    [JsonRequired]
    [JsonProperty("cookie")]
    public string Cookie { get; set; } = null!;
}