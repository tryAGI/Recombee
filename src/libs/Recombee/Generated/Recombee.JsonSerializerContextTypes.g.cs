
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Recombee.PropertyInfo? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.PropertyRole? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.PropertyMetadata? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.AddItemPropertyParameters? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.AddItemPropertyParametersType? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.AddUserPropertyParameters? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.AddUserPropertyParametersType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SeriesItem? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RemoveSeriesItem? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.AddSeries? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.DeleteSeries? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.DetailView? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.OneOf<string, double?>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Purchase? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Rating? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CartAddition? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Bookmark? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.ViewPortion? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.UpdateMoreItemsParameters? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.UpdateMoreItemsResponse? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.DeleteMoreItemsParameters? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.DeleteMoreItemsResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToUserParameters? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Logic? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToUserParametersMinRelevance? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendUsersToUserParameters? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendUsersToUserParametersMinRelevance? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToItemParameters? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToItemParametersMinRelevance? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendUsersToItemParameters? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemSegmentsToUserParameters? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemSegmentsToItemParameters? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemSegmentsToItemSegmentParameters? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToItemSegmentParameters? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CompositeRecommendationStageParameters? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CompositeRecommendationStageParametersMinRelevance? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CompositeRecommendationParameters? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SearchItemsParameters? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SearchItemSegmentsParameters? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendNextItemsParameters? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendNextItemSegmentsParameters? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CreatePropertyBasedSegmentationParameters? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.UpdatePropertyBasedSegmentationParameters? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CreateAutoReQLSegmentationParameters? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.UpdateAutoReQLSegmentationParameters? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CreateManualReQLSegmentationParameters? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.UpdateManualReQLSegmentationParameters? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.ManualReQLSegmentParameters? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SearchResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Recommendation>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Recommendation? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.RecommendationResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.CompositeRecommendationResponse? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Batch? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Item? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.User? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Series? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SearchSynonymParams? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.SearchSynonym? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.ListSearchSynonymsResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.SearchSynonym>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Scenario? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.Segmentation? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Recombee.ListSegmentationsResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Segmentation>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Item>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.PropertyInfo>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Series>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.SeriesItem>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.User>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.DetailView>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Purchase>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Rating>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.CartAddition>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Bookmark>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.ViewPortion>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Recombee.Scenario>? Type86 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.PropertyMetadata>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Recommendation>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.SearchSynonym>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Segmentation>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Item>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.PropertyInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Series>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.SeriesItem>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.User>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.DetailView>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Purchase>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Rating>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.CartAddition>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Bookmark>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.ViewPortion>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.Scenario>? ListType17 { get; set; }
    }
}