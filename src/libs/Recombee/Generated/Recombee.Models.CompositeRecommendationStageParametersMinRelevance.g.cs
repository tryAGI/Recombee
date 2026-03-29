
#nullable enable

namespace Recombee
{
    /// <summary>
    /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
    /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
    /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
    /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
    /// If the *userId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user.<br/>
    /// Possible values one of: `"low"`, `"medium"`, `"high"`.<br/>
    /// The default value is `"low"`, meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*.<br/>
    /// This behavior may be suppressed by using `"medium"` or `"high"` values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
    /// </summary>
    public enum CompositeRecommendationStageParametersMinRelevance
    {
        /// <summary>
        /// `"low"`, `"medium"`, `"high"`.
        /// </summary>
        High,
        /// <summary>
        /// `"low"`, `"medium"`, `"high"`.
        /// </summary>
        Low,
        /// <summary>
        /// `"low"`, `"medium"`, `"high"`.
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompositeRecommendationStageParametersMinRelevanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompositeRecommendationStageParametersMinRelevance value)
        {
            return value switch
            {
                CompositeRecommendationStageParametersMinRelevance.High => "high",
                CompositeRecommendationStageParametersMinRelevance.Low => "low",
                CompositeRecommendationStageParametersMinRelevance.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompositeRecommendationStageParametersMinRelevance? ToEnum(string value)
        {
            return value switch
            {
                "high" => CompositeRecommendationStageParametersMinRelevance.High,
                "low" => CompositeRecommendationStageParametersMinRelevance.Low,
                "medium" => CompositeRecommendationStageParametersMinRelevance.Medium,
                _ => null,
            };
        }
    }
}