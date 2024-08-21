using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

public class MtCaptchaTask : ITask, IProxyTask
{
    [JsonProperty("type")]
    private string Type => "MtCaptchaTask";

    /// <summary>
    /// Web address of the website using MTCaptcha, generally it's fixed value. (Ex: https://google.com)
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    /// <summary>
    /// The domain public key, rarely updated. (Ex: sk=MTPublic-xxx public key)
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteKey")]
    public string WebsiteKey { get; set; }

    /// <summary>
    /// </summary>
    /// <param name="websiteUrl">Web address of the website using MTCaptcha, generally it's fixed value.</param>
    /// <param name="websiteKey">The domain public key, rarely updated. (Ex: sk=MTPublic-xxx public key)</param>
    public MtCaptchaTask(string websiteUrl,
                         string websiteKey)
    {
    
        WebsiteURL = websiteUrl;
        WebsiteKey = websiteKey;
    }
}
