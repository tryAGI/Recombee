
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutUsersPropertiesType
    {
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        Boolean,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        Double,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        Int,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        Set,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        String,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`.
        /// </summary>
        Timestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutUsersPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutUsersPropertiesType value)
        {
            return value switch
            {
                PutUsersPropertiesType.Boolean => "boolean",
                PutUsersPropertiesType.Double => "double",
                PutUsersPropertiesType.Int => "int",
                PutUsersPropertiesType.Set => "set",
                PutUsersPropertiesType.String => "string",
                PutUsersPropertiesType.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutUsersPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => PutUsersPropertiesType.Boolean,
                "double" => PutUsersPropertiesType.Double,
                "int" => PutUsersPropertiesType.Int,
                "set" => PutUsersPropertiesType.Set,
                "string" => PutUsersPropertiesType.String,
                "timestamp" => PutUsersPropertiesType.Timestamp,
                _ => null,
            };
        }
    }
}