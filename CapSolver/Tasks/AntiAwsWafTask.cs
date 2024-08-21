using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

public class AntiAwsWafTask : ITask, IProxyTask
{
    [JsonProperty("type")]
    private string Type => "AntiAwsWafTask";

    /// <summary>
    /// The URL of the page that returns the captcha info
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsContext is required
    /// </summary>
    [JsonProperty("awsKey", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsKey { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsIv is required
    /// </summary>
    [JsonProperty("awsIv", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsIv { get; set; }
  
    /// <summary>
    /// When the status code returned by the websiteURL page is 405, awsContext is required
    /// </summary>
    [JsonProperty("awsContext", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsContext { get; set; }

    /// <summary>
    /// When the status code returned by the websiteURL page is 405 or 202, awsChallengeJs is required
    /// </summary>
    [JsonProperty("awsChallengeJS", NullValueHandling = NullValueHandling.Ignore)]
    public string? AwsChallengeJS { get; set; }

    /// <summary>
    /// </summary>
    /// <param name="websiteUrl">The URL of the page that returns the captcha info</param>
    /// <param name="awsKey">When the status code returned by the websiteURL page is 405, awsContext is required</param>
    /// <param name="awsIv">When the status code returned by the websiteURL page is 405, awsIv is required</param>
    /// <param name="awsContext">When the status code returned by the websiteURL page is 405, awsContext is required</param>
    /// <param name="awsChallengeJS">When the status code returned by the websiteURL page is 405 or 202, awsChallengeJs is required</param>
    public AntiAwsWafTask(string websiteUrl,
                          string? awsKey = null,
                          string? awsIv = null,
                          string? awsContext = null,
                          string? awsChallengeJS = null)
    {
    
        WebsiteURL = websiteUrl;
        AwsKey = awsKey;
        AwsIv = awsIv;
        AwsContext = awsContext;
        AwsChallengeJS = awsChallengeJS;
  }
}
