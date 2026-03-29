
#nullable enable

namespace Recombee
{
    /// <summary>
    /// **Expert option:** Specifies the threshold of how relevant must the recommended users be. Possible values one of: "low", "medium", "high".
    /// </summary>
    public enum RecommendUsersToUserParametersMinRelevance
    {
        /// <summary>
        /// ** Specifies the threshold of how relevant must the recommended users be. Possible values one of: "low", "medium", "high".
        /// </summary>
        High,
        /// <summary>
        /// ** Specifies the threshold of how relevant must the recommended users be. Possible values one of: "low", "medium", "high".
        /// </summary>
        Low,
        /// <summary>
        /// ** Specifies the threshold of how relevant must the recommended users be. Possible values one of: "low", "medium", "high".
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RecommendUsersToUserParametersMinRelevanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecommendUsersToUserParametersMinRelevance value)
        {
            return value switch
            {
                RecommendUsersToUserParametersMinRelevance.High => "high",
                RecommendUsersToUserParametersMinRelevance.Low => "low",
                RecommendUsersToUserParametersMinRelevance.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecommendUsersToUserParametersMinRelevance? ToEnum(string value)
        {
            return value switch
            {
                "high" => RecommendUsersToUserParametersMinRelevance.High,
                "low" => RecommendUsersToUserParametersMinRelevance.Low,
                "medium" => RecommendUsersToUserParametersMinRelevance.Medium,
                _ => null,
            };
        }
    }
}