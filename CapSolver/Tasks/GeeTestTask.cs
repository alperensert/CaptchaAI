using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task is used to solve GeeTest.
/// </summary>
public class GeeTestTask : ITask, ICookieTask
{
    [JsonProperty("type")]
    private string Type => "GeeTestTaskProxyLess";

    /// <summary>
    /// Web address of the website using geetest (Ex: https://geetest.com)
    /// </summary>
    [JsonRequired]
    [JsonProperty("websiteURL")]
    public string WebsiteURL { get; set; }

    /// <summary>
    /// Only Geetest V3 is required
    /// </summary>
    [JsonProperty("gt", NullValueHandling = NullValueHandling.Ignore)]
    public string? Gt { get; set; }

    /// <summary>
    /// Only Geetest V3 is required
    /// </summary>
    [JsonProperty("challenge", NullValueHandling = NullValueHandling.Ignore)]
    public string? Challenge { get; set; }

    /// <summary>
    /// Only Geetest V4 is required
    /// </summary>
    [JsonProperty("captchaId", NullValueHandling = NullValueHandling.Ignore)]
    public string? CaptchaId { get; set; }

    /// <summary>
    /// Optional API subdomain. May be required for some implementations.
    /// </summary>
    [JsonProperty("geetestApiServerSubdomain", NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiServerSubdomain { get; set; }

    /// <summary>
    /// Prepare a GeeTest task
    /// </summary>
    /// <param name="websiteUrl">Address of a webpage with Geetest</param>
    /// <param name="gt">The domain public key, rarely updated.</param>
    /// <param name="challenge">Changing token key. Make sure you grab a fresh one for each captcha; otherwise, you'll be charged for an error task.</param>
    /// <param name="apiServerSubdomain">Optional API subdomain. May be required for some implementations.</param>
    public GeeTestTask(string websiteUrl,
                       string? gt = null,
                       string? challenge = null,
                       string? apiServerSubdomain = null,
                       string? captchaId = null)
    {
        WebsiteURL = websiteUrl;
        Gt = gt;
        Challenge = challenge;
        ApiServerSubdomain = apiServerSubdomain;
        CaptchaId = captchaId;

        if (gt != null && challenge != null)
        {
            CaptchaId = null;
        }
    }
}