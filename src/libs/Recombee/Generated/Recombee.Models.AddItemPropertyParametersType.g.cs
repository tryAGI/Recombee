
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Value type of the item property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.<br/>
    /// * `int` - Signed integer number.<br/>
    /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).<br/>
    /// * `string` - UTF-8 string.<br/>
    /// * `boolean` - *true* / *false*<br/>
    /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).<br/>
    /// * `set` - Set of strings.<br/>
    /// * `image` - URL of an image (`jpeg`, `png` or `gif`).<br/>
    /// * `imageList` - List of URLs that refer to images.
    /// </summary>
    public enum AddItemPropertyParametersType
    {
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Boolean,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Double,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Image,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        ImageList,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Int,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Set,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        String,
        /// <summary>
        /// `int`, `double`, `string`, `boolean`, `timestamp`, `set`, `image` or `imageList`.
        /// </summary>
        Timestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddItemPropertyParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddItemPropertyParametersType value)
        {
            return value switch
            {
                AddItemPropertyParametersType.Boolean => "boolean",
                AddItemPropertyParametersType.Double => "double",
                AddItemPropertyParametersType.Image => "image",
                AddItemPropertyParametersType.ImageList => "imageList",
                AddItemPropertyParametersType.Int => "int",
                AddItemPropertyParametersType.Set => "set",
                AddItemPropertyParametersType.String => "string",
                AddItemPropertyParametersType.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddItemPropertyParametersType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AddItemPropertyParametersType.Boolean,
                "double" => AddItemPropertyParametersType.Double,
                "image" => AddItemPropertyParametersType.Image,
                "imageList" => AddItemPropertyParametersType.ImageList,
                "int" => AddItemPropertyParametersType.Int,
                "set" => AddItemPropertyParametersType.Set,
                "string" => AddItemPropertyParametersType.String,
                "timestamp" => AddItemPropertyParametersType.Timestamp,
                _ => null,
            };
        }
    }
}