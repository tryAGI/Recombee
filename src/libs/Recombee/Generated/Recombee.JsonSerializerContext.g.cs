
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
            typeof(global::Recombee.JsonConverters.RecommendItemsToUserParametersMinRelevanceJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendItemsToUserParametersMinRelevanceNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendUsersToUserParametersMinRelevanceJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendUsersToUserParametersMinRelevanceNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendItemsToItemParametersMinRelevanceJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendItemsToItemParametersMinRelevanceNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendItemsToItemSegmentParametersMinRelevanceJsonConverter),

            typeof(global::Recombee.JsonConverters.RecommendItemsToItemSegmentParametersMinRelevanceNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.CompositeRecommendationStageParametersMinRelevanceJsonConverter),

            typeof(global::Recombee.JsonConverters.CompositeRecommendationStageParametersMinRelevanceNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.PutItemsPropertiesTypeJsonConverter),

            typeof(global::Recombee.JsonConverters.PutItemsPropertiesTypeNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.PutUsersPropertiesTypeJsonConverter),

            typeof(global::Recombee.JsonConverters.PutUsersPropertiesTypeNullableJsonConverter),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Recombee.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.PropertyInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SeriesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RemoveSeriesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.AddSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.DeleteSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.DetailView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Purchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Rating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CartAddition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Bookmark))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.ViewPortion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.UpdateMoreItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.UpdateMoreItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.DeleteMoreItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.DeleteMoreItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendItemsToUserParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Logic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationStageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationStageParametersMinRelevance), TypeInfoPropertyName = "CompositeRecommendationStageParametersMinRelevance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SearchItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SearchItemSegmentsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendNextItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CreatePropertyBasedSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.UpdatePropertyBasedSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CreateAutoReQLSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.UpdateAutoReQLSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CreateManualReQLSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.UpdateManualReQLSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.ManualReQLSegmentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Recommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Recommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.RecommendationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.CompositeRecommendationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Series))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Group))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SearchSynonymParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.SearchSynonym))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.ListSearchSynonymsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.SearchSynonym>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Scenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.Segmentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.ListSegmentationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Segmentation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.PutItemsPropertiesType), TypeInfoPropertyName = "PutItemsPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Recombee.PutUsersPropertiesType), TypeInfoPropertyName = "PutUsersPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.PropertyInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Series>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.SeriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.DetailView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Purchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Rating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.CartAddition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Bookmark>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.ViewPortion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Recombee.Scenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Recommendation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.SearchSynonym>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Segmentation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.PropertyInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Series>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.SeriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.DetailView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Purchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Rating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.CartAddition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Bookmark>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.ViewPortion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Recombee.Scenario>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}