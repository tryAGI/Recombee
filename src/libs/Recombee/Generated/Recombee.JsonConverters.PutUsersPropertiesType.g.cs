#nullable enable

namespace Recombee.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutUsersPropertiesTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Recombee.PutUsersPropertiesType>
    {
        /// <inheritdoc />
        public override global::Recombee.PutUsersPropertiesType Read(
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
                        return global::Recombee.PutUsersPropertiesTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Recombee.PutUsersPropertiesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Recombee.PutUsersPropertiesType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Recombee.PutUsersPropertiesType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Recombee.PutUsersPropertiesTypeExtensions.ToValueString(value));
        }
    }
}
