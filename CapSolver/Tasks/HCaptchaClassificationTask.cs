using CapSolver.Utilities;
using Newtonsoft.Json;

namespace CapSolver.Tasks;

/// <summary>
/// This task type is used to solve HCaptchaClassification
/// </summary>
public class HCaptchaClassificationTask : ITask
{
    [JsonProperty("type")]
    private string Type => "HCaptchaClassification";

    /// <summary>
    /// Page source url to improve accuracy
    /// </summary>
    [JsonProperty("websiteURL")]
    public string? WebsiteUrl { get; set; }

    /// <summary>
    /// Website key to improve accuracy
    /// </summary>
    [JsonProperty("websiteKey")]
    public string? WebsiteKey { get; set; }

    /// <summary>
    /// Base64 encoded images, do not include "data:image/***; base64,"
    /// Assembles the picture as a list: [base64, base64, base64...]
    /// </summary>
    [JsonRequired]
    [JsonProperty("queries")]
    public IList<string> Queries { get; set; }

    /// <summary>
    /// Question ID. Support English and Chinese, other languages please convert yourself
    /// </summary>
    [JsonRequired]
    [JsonProperty("question")]
    public string Question { get; set; }

    /// <summary>
    /// Prepare a HCaptchaClassification task.
    /// </summary>
    /// <param name="queries">Base64 encoded images, do not include "data:image/***; base64,"</param>
    /// <param name="question">Question ID. English is supported only. Please convert other languages by yourself</param>
    /// <param name="websiteUrl">Page source url to improve accuracy</param>
    public HCaptchaClassificationTask(IList<string> queries,
                                      string question,
                                      string? websiteUrl = null)
    {
        Queries = queries;
        Question = question;
    }
}