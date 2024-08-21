using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task type is used to solve VisionEngine
/// </summary>
public class VisionEngineClassificationTask : ITask
{
    [JsonProperty("type")]
    private string Type => "VisionEngine";

    /// <summary>
    /// See supported images types: <seealso href="https://docs.capsolver.com/guide/recognition/VisionEngine.html#support-img-types">click here</seealso>
    /// </summary>
    [JsonRequired]
    [JsonProperty("module")]
    public string Module { get; set; }

    /// <summary>
    /// Base64 encoded content of the image (no newlines, no data:image/***;charset=utf-8;base64,)
    /// </summary>
    [JsonRequired]
    [JsonProperty("image")]
    public string Image { get; set; }

    /// <summary>
    /// Base64 encoded content of the background image (no newlines, no data:image/***;charset=utf-8;base64,)
    /// </summary>
    [JsonRequired]
    [JsonProperty("imageBackground")]
    public string ImageBackground { get; set; }

    /// <summary>
    /// Page source url to improve accuracy
    /// </summary>
    [JsonProperty("websiteURL")]
    public string? WebsiteUrl { get; set; }
  
    /// <summary>
    /// space_detection requires
    /// </summary>
    [JsonProperty("question")]
    public string? Question { get; set; }

    /// <summary>
    /// Prepare a HCaptchaClassification task.
    /// </summary>
    /// <param name="module">See supported images types: <seealso href="https://docs.capsolver.com/guide/recognition/VisionEngine.html#support-img-types">click here</seealso></param>
    /// <param name="image">Base64 encoded content of the image (no newlines, no data:image/***;charset=utf-8;base64,)</param>
    /// <param name="imageBackground">Base64 encoded content of the background image (no newlines, no data:image/***;charset=utf-8;base64,)</param>
    /// <param name="question">Page source url to improve accuracy</param>
    /// <param name="websiteUrl">space_detection requires</param>
    public VisionEngineClassificationTask(string module,
                                          string image,
                                          string imageBackground,
                                          string? websiteUrl = null,
                                          string? question = null)
    {
        Module = module;
        Image = image;
        ImageBackground = imageBackground;
    }
}