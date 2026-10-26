
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`.<br/>
    /// * `int` - Signed integer number.<br/>
    /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).<br/>
    /// * `string` - UTF-8 string.<br/>
    /// * `boolean` - *true* / *false*<br/>
    /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).<br/>
    /// * `set` - Set of strings.
    /// </summary>
    public enum AddUserPropertyParametersType
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
    public static class AddUserPropertyParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddUserPropertyParametersType value)
        {
            return value switch
            {
                AddUserPropertyParametersType.Boolean => "boolean",
                AddUserPropertyParametersType.Double => "double",
                AddUserPropertyParametersType.Int => "int",
                AddUserPropertyParametersType.Set => "set",
                AddUserPropertyParametersType.String => "string",
                AddUserPropertyParametersType.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddUserPropertyParametersType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AddUserPropertyParametersType.Boolean,
                "double" => AddUserPropertyParametersType.Double,
                "int" => AddUserPropertyParametersType.Int,
                "set" => AddUserPropertyParametersType.Set,
                "string" => AddUserPropertyParametersType.String,
                "timestamp" => AddUserPropertyParametersType.Timestamp,
                _ => null,
            };
        }
    }
}