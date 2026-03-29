
#nullable enable

namespace Recombee
{
    /// <summary>
    /// **Expert option:** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
    /// </summary>
    public enum RecommendItemsToItemSegmentParametersMinRelevance
    {
        /// <summary>
        /// ** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        High,
        /// <summary>
        /// ** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        Low,
        /// <summary>
        /// ** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecommendItemsToItemSegmentParametersMinRelevanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecommendItemsToItemSegmentParametersMinRelevance value)
        {
            return value switch
            {
                RecommendItemsToItemSegmentParametersMinRelevance.High => "high",
                RecommendItemsToItemSegmentParametersMinRelevance.Low => "low",
                RecommendItemsToItemSegmentParametersMinRelevance.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecommendItemsToItemSegmentParametersMinRelevance? ToEnum(string value)
        {
            return value switch
            {
                "high" => RecommendItemsToItemSegmentParametersMinRelevance.High,
                "low" => RecommendItemsToItemSegmentParametersMinRelevance.Low,
                "medium" => RecommendItemsToItemSegmentParametersMinRelevance.Medium,
                _ => null,
            };
        }
    }
}