using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Models.Responses;

public class VisionEngineClassificationResponse : ITaskResponse
{
    [JsonProperty("distance")]
    public int Distance { get; set; }

    [JsonProperty("angle")]
    public int Angle{ get; set; }

    [JsonProperty("box")]
    public IList<float>? Box { get; set; }
}