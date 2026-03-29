#nullable enable

namespace Recombee.JsonConverters
{
    /// <inheritdoc />
    public sealed class RecommendItemsToItemSegmentParametersMinRelevanceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance>
    {
        /// <inheritdoc />
        public override global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Recombee.RecommendItemsToItemSegmentParametersMinRelevanceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevanceExtensions.ToValueString(value));
        }
    }
}
