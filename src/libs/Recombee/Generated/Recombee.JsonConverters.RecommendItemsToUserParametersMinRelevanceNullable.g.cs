#nullable enable

namespace Recombee.JsonConverters
{
    /// <inheritdoc />
    public sealed class RecommendItemsToUserParametersMinRelevanceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recombee.RecommendItemsToUserParametersMinRelevance?>
    {
        /// <inheritdoc />
        public override global::Recombee.RecommendItemsToUserParametersMinRelevance? Read(
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
                        return global::Recombee.RecommendItemsToUserParametersMinRelevanceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Recombee.RecommendItemsToUserParametersMinRelevance)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Recombee.RecommendItemsToUserParametersMinRelevance?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recombee.RecommendItemsToUserParametersMinRelevance? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Recombee.RecommendItemsToUserParametersMinRelevanceExtensions.ToValueString(value.Value));
            }
        }
    }
}
