
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToUserParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Logic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance), TypeInfoPropertyName = "RecommendItemsToUserParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendUsersToUserParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance), TypeInfoPropertyName = "RecommendUsersToUserParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance), TypeInfoPropertyName = "RecommendItemsToItemParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendUsersToItemParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemSegmentsToUserParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemSegmentsToItemParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemSegmentsToItemSegmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemSegmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance), TypeInfoPropertyName = "RecommendItemsToItemSegmentParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendNextItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendNextItemSegmentsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Recommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Recommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance?), TypeInfoPropertyName = "NullableRecommendItemsToUserParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance?), TypeInfoPropertyName = "NullableRecommendUsersToUserParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance?), TypeInfoPropertyName = "NullableRecommendItemsToItemParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance?), TypeInfoPropertyName = "NullableRecommendItemsToItemSegmentParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Recommendation>))]
    internal sealed partial class RecommendationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecommendationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RecommendationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RecommendationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Recombee.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance)

                    || typeToConvert == typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance?)

                    || typeToConvert == typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance)

                    || typeToConvert == typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance?)

                    || typeToConvert == typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance)

                    || typeToConvert == typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance?)

                    || typeToConvert == typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance)

                    || typeToConvert == typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToUserParametersMinRelevanceJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendItemsToUserParametersMinRelevance?))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToUserParametersMinRelevanceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance))
                {
                    return new global::Recombee.JsonConverters.RecommendUsersToUserParametersMinRelevanceJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendUsersToUserParametersMinRelevance?))
                {
                    return new global::Recombee.JsonConverters.RecommendUsersToUserParametersMinRelevanceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToItemParametersMinRelevanceJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendItemsToItemParametersMinRelevance?))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToItemParametersMinRelevanceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToItemSegmentParametersMinRelevanceJsonConverter();
                }

                if (typeToConvert == typeof(global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance?))
                {
                    return new global::Recombee.JsonConverters.RecommendItemsToItemSegmentParametersMinRelevanceNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RecommendationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}