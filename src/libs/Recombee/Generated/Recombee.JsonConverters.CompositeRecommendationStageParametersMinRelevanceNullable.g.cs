#nullable enable

namespace Recombee.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompositeRecommendationStageParametersMinRelevanceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recombee.CompositeRecommendationStageParametersMinRelevance?>
    {
        /// <inheritdoc />
        public override global::Recombee.CompositeRecommendationStageParametersMinRelevance? Read(
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
                        return global::Recombee.CompositeRecommendationStageParametersMinRelevanceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Recombee.CompositeRecommendationStageParametersMinRelevance)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Recombee.CompositeRecommendationStageParametersMinRelevance?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recombee.CompositeRecommendationStageParametersMinRelevance? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Recombee.CompositeRecommendationStageParametersMinRelevanceExtensions.ToValueString(value.Value));
            }
        }
    }
}
