
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMoreItemsParameters
    {
        /// <summary>
        /// A [ReQL](https://docs.recombee.com/reql) expression, which returns `true` for the items that shall be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// A dictionary where the keys are properties that shall be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMoreItemsParameters" /> class.
        /// </summary>
        /// <param name="filter">
        /// A [ReQL](https://docs.recombee.com/reql) expression, which returns `true` for the items that shall be updated.
        /// </param>
        /// <param name="changes">
        /// A dictionary where the keys are properties that shall be updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMoreItemsParameters(
            string filter,
            object changes)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMoreItemsParameters" /> class.
        /// </summary>
        public UpdateMoreItemsParameters()
        {
        }
    }
}