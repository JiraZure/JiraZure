// <auto-generated/>
using JiraLib.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.App.Field.Value {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\app\field\value
    /// </summary>
    public class ValueRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValueRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field/value{?generateChangelog*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ValueRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field/value{?generateChangelog*}", rawUrl)
        {
        }
        /// <summary>
        /// Updates the value of one or more custom fields on one or more issues. Combinations of custom field and issue should be unique within the request.Apps can only perform this operation on [custom fields](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field/) and [custom field types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/) declared in their own manifests.**[Permissions](#permissions) required:** Only the app that owns the custom field or custom field type can update its values with this operation.
        /// </summary>
        /// <param name="body">List of updates for a custom fields.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(MultipleCustomFieldValuesUpdateDetails body, Action<RequestConfiguration<ValueRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(MultipleCustomFieldValuesUpdateDetails body, Action<RequestConfiguration<ValueRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the value of one or more custom fields on one or more issues. Combinations of custom field and issue should be unique within the request.Apps can only perform this operation on [custom fields](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field/) and [custom field types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/) declared in their own manifests.**[Permissions](#permissions) required:** Only the app that owns the custom field or custom field type can update its values with this operation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">List of updates for a custom fields.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(MultipleCustomFieldValuesUpdateDetails body, Action<RequestConfiguration<ValueRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(MultipleCustomFieldValuesUpdateDetails body, Action<RequestConfiguration<ValueRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ValueRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ValueRequestBuilder WithUrl(string rawUrl)
        {
            return new ValueRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Updates the value of one or more custom fields on one or more issues. Combinations of custom field and issue should be unique within the request.Apps can only perform this operation on [custom fields](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field/) and [custom field types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/) declared in their own manifests.**[Permissions](#permissions) required:** Only the app that owns the custom field or custom field type can update its values with this operation.
        /// </summary>
        public class ValueRequestBuilderPostQueryParameters 
        {
            /// <summary>Whether to generate a changelog for this update.</summary>
            [QueryParameter("generateChangelog")]
            public bool? GenerateChangelog { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ValueRequestBuilderPostRequestConfiguration : RequestConfiguration<ValueRequestBuilderPostQueryParameters> 
        {
        }
    }
}
