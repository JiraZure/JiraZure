// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Field.Item.Option.Item;
using JiraLib.Rest.Api.Three.Field.Item.Option.Suggestions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Field.Item.Option {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\field\{field-id}\option
    /// </summary>
    public class OptionRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The suggestions property</summary>
        public SuggestionsRequestBuilder Suggestions
        {
            get => new SuggestionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.field.item.option.item collection</summary>
        /// <param name="position">The ID of the option to be deleted.</param>
        /// <returns>A <see cref="WithOptionItemRequestBuilder"/></returns>
        public WithOptionItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("optionId", position);
                return new WithOptionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.field.item.option.item collection</summary>
        /// <param name="position">The ID of the option to be deleted.</param>
        /// <returns>A <see cref="WithOptionItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithOptionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("optionId", position);
                return new WithOptionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="OptionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{field%2Did}/option{?maxResults*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="OptionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OptionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{field%2Did}/option{?maxResults*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of all the options of a select list issue field. A select list issue field is a type of [issue field](https://developer.atlassian.com/cloud/jira/platform/modules/issue-field/) that enables a user to select a value from a list of options.Note that this operation **only works for issue field select list options added by Connect apps**, it cannot be used with issue field select list options created in Jira or using operations from the [Issue custom field options](#api-group-Issue-custom-field-options) resource.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). Jira permissions are not required for the app providing the field.
        /// </summary>
        /// <returns>A <see cref="PageBeanIssueFieldOption"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanIssueFieldOption?> GetAsync(Action<RequestConfiguration<OptionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanIssueFieldOption> GetAsync(Action<RequestConfiguration<OptionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanIssueFieldOption>(requestInfo, PageBeanIssueFieldOption.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an option for a select list issue field.Note that this operation **only works for issue field select list options added by Connect apps**, it cannot be used with issue field select list options created in Jira or using operations from the [Issue custom field options](#api-group-Issue-custom-field-options) resource.Each field can have a maximum of 10000 options, and each option can have a maximum of 10000 scopes.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). Jira permissions are not required for the app providing the field.
        /// </summary>
        /// <returns>A <see cref="IssueFieldOption"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IssueFieldOption?> PostAsync(IssueFieldOptionCreateBean body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<IssueFieldOption> PostAsync(IssueFieldOptionCreateBean body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<IssueFieldOption>(requestInfo, IssueFieldOption.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of all the options of a select list issue field. A select list issue field is a type of [issue field](https://developer.atlassian.com/cloud/jira/platform/modules/issue-field/) that enables a user to select a value from a list of options.Note that this operation **only works for issue field select list options added by Connect apps**, it cannot be used with issue field select list options created in Jira or using operations from the [Issue custom field options](#api-group-Issue-custom-field-options) resource.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). Jira permissions are not required for the app providing the field.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OptionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<OptionRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates an option for a select list issue field.Note that this operation **only works for issue field select list options added by Connect apps**, it cannot be used with issue field select list options created in Jira or using operations from the [Issue custom field options](#api-group-Issue-custom-field-options) resource.Each field can have a maximum of 10000 options, and each option can have a maximum of 10000 scopes.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). Jira permissions are not required for the app providing the field.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(IssueFieldOptionCreateBean body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(IssueFieldOptionCreateBean body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="OptionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OptionRequestBuilder WithUrl(string rawUrl)
        {
            return new OptionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of all the options of a select list issue field. A select list issue field is a type of [issue field](https://developer.atlassian.com/cloud/jira/platform/modules/issue-field/) that enables a user to select a value from a list of options.Note that this operation **only works for issue field select list options added by Connect apps**, it cannot be used with issue field select list options created in Jira or using operations from the [Issue custom field options](#api-group-Issue-custom-field-options) resource.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). Jira permissions are not required for the app providing the field.
        /// </summary>
        public class OptionRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OptionRequestBuilderGetRequestConfiguration : RequestConfiguration<OptionRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class OptionRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
