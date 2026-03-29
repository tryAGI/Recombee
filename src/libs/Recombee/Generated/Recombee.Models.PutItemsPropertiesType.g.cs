
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutItemsPropertiesType
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
    public static class PutItemsPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutItemsPropertiesType value)
        {
            return value switch
            {
                PutItemsPropertiesType.Boolean => "boolean",
                PutItemsPropertiesType.Double => "double",
                PutItemsPropertiesType.Image => "image",
                PutItemsPropertiesType.ImageList => "imageList",
                PutItemsPropertiesType.Int => "int",
                PutItemsPropertiesType.Set => "set",
                PutItemsPropertiesType.String => "string",
                PutItemsPropertiesType.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutItemsPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => PutItemsPropertiesType.Boolean,
                "double" => PutItemsPropertiesType.Double,
                "image" => PutItemsPropertiesType.Image,
                "imageList" => PutItemsPropertiesType.ImageList,
                "int" => PutItemsPropertiesType.Int,
                "set" => PutItemsPropertiesType.Set,
                "string" => PutItemsPropertiesType.String,
                "timestamp" => PutItemsPropertiesType.Timestamp,
                _ => null,
            };
        }
    }
}