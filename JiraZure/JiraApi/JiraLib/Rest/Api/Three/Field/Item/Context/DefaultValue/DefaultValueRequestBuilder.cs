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
namespace JiraLib.Rest.Api.Three.Field.Item.Context.DefaultValue {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\field\{field-id}\context\defaultValue
    /// </summary>
    public class DefaultValueRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="DefaultValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultValueRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{field%2Did}/context/defaultValue{?contextId*,maxResults*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="DefaultValueRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DefaultValueRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{field%2Did}/context/defaultValue{?contextId*,maxResults*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of defaults for a custom field. The results can be filtered by `contextId`, otherwise all values are returned. If no defaults are set for a context, nothing is returned.  The returned object depends on type of the custom field: *  `CustomFieldContextDefaultValueDate` (type `datepicker`) for date fields. *  `CustomFieldContextDefaultValueDateTime` (type `datetimepicker`) for date-time fields. *  `CustomFieldContextDefaultValueSingleOption` (type `option.single`) for single choice select lists and radio buttons. *  `CustomFieldContextDefaultValueMultipleOption` (type `option.multiple`) for multiple choice select lists and checkboxes. *  `CustomFieldContextDefaultValueCascadingOption` (type `option.cascading`) for cascading select lists. *  `CustomFieldContextSingleUserPickerDefaults` (type `single.user.select`) for single users. *  `CustomFieldContextDefaultValueMultiUserPicker` (type `multi.user.select`) for user lists. *  `CustomFieldContextDefaultValueSingleGroupPicker` (type `grouppicker.single`) for single choice group pickers. *  `CustomFieldContextDefaultValueMultipleGroupPicker` (type `grouppicker.multiple`) for multiple choice group pickers. *  `CustomFieldContextDefaultValueURL` (type `url`) for URLs. *  `CustomFieldContextDefaultValueProject` (type `project`) for project pickers. *  `CustomFieldContextDefaultValueFloat` (type `float`) for floats (floating-point numbers). *  `CustomFieldContextDefaultValueLabels` (type `labels`) for labels. *  `CustomFieldContextDefaultValueTextField` (type `textfield`) for text fields. *  `CustomFieldContextDefaultValueTextArea` (type `textarea`) for text area fields. *  `CustomFieldContextDefaultValueReadOnly` (type `readonly`) for read only (text) fields. *  `CustomFieldContextDefaultValueMultipleVersion` (type `version.multiple`) for single choice version pickers. *  `CustomFieldContextDefaultValueSingleVersion` (type `version.single`) for multiple choice version pickers.Forge custom fields [types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/#data-types) are also supported, returning: *  `CustomFieldContextDefaultValueForgeStringFieldBean` (type `forge.string`) for Forge string fields. *  `CustomFieldContextDefaultValueForgeMultiStringFieldBean` (type `forge.string.list`) for Forge string collection fields. *  `CustomFieldContextDefaultValueForgeObjectFieldBean` (type `forge.object`) for Forge object fields. *  `CustomFieldContextDefaultValueForgeDateTimeFieldBean` (type `forge.datetime`) for Forge date-time fields. *  `CustomFieldContextDefaultValueForgeGroupFieldBean` (type `forge.group`) for Forge group fields. *  `CustomFieldContextDefaultValueForgeMultiGroupFieldBean` (type `forge.group.list`) for Forge group collection fields. *  `CustomFieldContextDefaultValueForgeNumberFieldBean` (type `forge.number`) for Forge number fields. *  `CustomFieldContextDefaultValueForgeUserFieldBean` (type `forge.user`) for Forge user fields. *  `CustomFieldContextDefaultValueForgeMultiUserFieldBean` (type `forge.user.list`) for Forge user collection fields.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="PageBeanCustomFieldContextDefaultValue"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanCustomFieldContextDefaultValue?> GetAsync(Action<RequestConfiguration<DefaultValueRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanCustomFieldContextDefaultValue> GetAsync(Action<RequestConfiguration<DefaultValueRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanCustomFieldContextDefaultValue>(requestInfo, PageBeanCustomFieldContextDefaultValue.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sets default for contexts of a custom field. Default are defined using these objects: *  `CustomFieldContextDefaultValueDate` (type `datepicker`) for date fields. *  `CustomFieldContextDefaultValueDateTime` (type `datetimepicker`) for date-time fields. *  `CustomFieldContextDefaultValueSingleOption` (type `option.single`) for single choice select lists and radio buttons. *  `CustomFieldContextDefaultValueMultipleOption` (type `option.multiple`) for multiple choice select lists and checkboxes. *  `CustomFieldContextDefaultValueCascadingOption` (type `option.cascading`) for cascading select lists. *  `CustomFieldContextSingleUserPickerDefaults` (type `single.user.select`) for single users. *  `CustomFieldContextDefaultValueMultiUserPicker` (type `multi.user.select`) for user lists. *  `CustomFieldContextDefaultValueSingleGroupPicker` (type `grouppicker.single`) for single choice group pickers. *  `CustomFieldContextDefaultValueMultipleGroupPicker` (type `grouppicker.multiple`) for multiple choice group pickers. *  `CustomFieldContextDefaultValueURL` (type `url`) for URLs. *  `CustomFieldContextDefaultValueProject` (type `project`) for project pickers. *  `CustomFieldContextDefaultValueFloat` (type `float`) for floats (floating-point numbers). *  `CustomFieldContextDefaultValueLabels` (type `labels`) for labels. *  `CustomFieldContextDefaultValueTextField` (type `textfield`) for text fields. *  `CustomFieldContextDefaultValueTextArea` (type `textarea`) for text area fields. *  `CustomFieldContextDefaultValueReadOnly` (type `readonly`) for read only (text) fields. *  `CustomFieldContextDefaultValueMultipleVersion` (type `version.multiple`) for single choice version pickers. *  `CustomFieldContextDefaultValueSingleVersion` (type `version.single`) for multiple choice version pickers.Forge custom fields [types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/#data-types) are also supported, returning: *  `CustomFieldContextDefaultValueForgeStringFieldBean` (type `forge.string`) for Forge string fields. *  `CustomFieldContextDefaultValueForgeMultiStringFieldBean` (type `forge.string.list`) for Forge string collection fields. *  `CustomFieldContextDefaultValueForgeObjectFieldBean` (type `forge.object`) for Forge object fields. *  `CustomFieldContextDefaultValueForgeDateTimeFieldBean` (type `forge.datetime`) for Forge date-time fields. *  `CustomFieldContextDefaultValueForgeGroupFieldBean` (type `forge.group`) for Forge group fields. *  `CustomFieldContextDefaultValueForgeMultiGroupFieldBean` (type `forge.group.list`) for Forge group collection fields. *  `CustomFieldContextDefaultValueForgeNumberFieldBean` (type `forge.number`) for Forge number fields. *  `CustomFieldContextDefaultValueForgeUserFieldBean` (type `forge.user`) for Forge user fields. *  `CustomFieldContextDefaultValueForgeMultiUserFieldBean` (type `forge.user.list`) for Forge user collection fields.Only one type of default object can be included in a request. To remove a default for a context, set the default parameter to `null`.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="body">Default values to update.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(CustomFieldContextDefaultValueUpdate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(CustomFieldContextDefaultValueUpdate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of defaults for a custom field. The results can be filtered by `contextId`, otherwise all values are returned. If no defaults are set for a context, nothing is returned.  The returned object depends on type of the custom field: *  `CustomFieldContextDefaultValueDate` (type `datepicker`) for date fields. *  `CustomFieldContextDefaultValueDateTime` (type `datetimepicker`) for date-time fields. *  `CustomFieldContextDefaultValueSingleOption` (type `option.single`) for single choice select lists and radio buttons. *  `CustomFieldContextDefaultValueMultipleOption` (type `option.multiple`) for multiple choice select lists and checkboxes. *  `CustomFieldContextDefaultValueCascadingOption` (type `option.cascading`) for cascading select lists. *  `CustomFieldContextSingleUserPickerDefaults` (type `single.user.select`) for single users. *  `CustomFieldContextDefaultValueMultiUserPicker` (type `multi.user.select`) for user lists. *  `CustomFieldContextDefaultValueSingleGroupPicker` (type `grouppicker.single`) for single choice group pickers. *  `CustomFieldContextDefaultValueMultipleGroupPicker` (type `grouppicker.multiple`) for multiple choice group pickers. *  `CustomFieldContextDefaultValueURL` (type `url`) for URLs. *  `CustomFieldContextDefaultValueProject` (type `project`) for project pickers. *  `CustomFieldContextDefaultValueFloat` (type `float`) for floats (floating-point numbers). *  `CustomFieldContextDefaultValueLabels` (type `labels`) for labels. *  `CustomFieldContextDefaultValueTextField` (type `textfield`) for text fields. *  `CustomFieldContextDefaultValueTextArea` (type `textarea`) for text area fields. *  `CustomFieldContextDefaultValueReadOnly` (type `readonly`) for read only (text) fields. *  `CustomFieldContextDefaultValueMultipleVersion` (type `version.multiple`) for single choice version pickers. *  `CustomFieldContextDefaultValueSingleVersion` (type `version.single`) for multiple choice version pickers.Forge custom fields [types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/#data-types) are also supported, returning: *  `CustomFieldContextDefaultValueForgeStringFieldBean` (type `forge.string`) for Forge string fields. *  `CustomFieldContextDefaultValueForgeMultiStringFieldBean` (type `forge.string.list`) for Forge string collection fields. *  `CustomFieldContextDefaultValueForgeObjectFieldBean` (type `forge.object`) for Forge object fields. *  `CustomFieldContextDefaultValueForgeDateTimeFieldBean` (type `forge.datetime`) for Forge date-time fields. *  `CustomFieldContextDefaultValueForgeGroupFieldBean` (type `forge.group`) for Forge group fields. *  `CustomFieldContextDefaultValueForgeMultiGroupFieldBean` (type `forge.group.list`) for Forge group collection fields. *  `CustomFieldContextDefaultValueForgeNumberFieldBean` (type `forge.number`) for Forge number fields. *  `CustomFieldContextDefaultValueForgeUserFieldBean` (type `forge.user`) for Forge user fields. *  `CustomFieldContextDefaultValueForgeMultiUserFieldBean` (type `forge.user.list`) for Forge user collection fields.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultValueRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultValueRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Sets default for contexts of a custom field. Default are defined using these objects: *  `CustomFieldContextDefaultValueDate` (type `datepicker`) for date fields. *  `CustomFieldContextDefaultValueDateTime` (type `datetimepicker`) for date-time fields. *  `CustomFieldContextDefaultValueSingleOption` (type `option.single`) for single choice select lists and radio buttons. *  `CustomFieldContextDefaultValueMultipleOption` (type `option.multiple`) for multiple choice select lists and checkboxes. *  `CustomFieldContextDefaultValueCascadingOption` (type `option.cascading`) for cascading select lists. *  `CustomFieldContextSingleUserPickerDefaults` (type `single.user.select`) for single users. *  `CustomFieldContextDefaultValueMultiUserPicker` (type `multi.user.select`) for user lists. *  `CustomFieldContextDefaultValueSingleGroupPicker` (type `grouppicker.single`) for single choice group pickers. *  `CustomFieldContextDefaultValueMultipleGroupPicker` (type `grouppicker.multiple`) for multiple choice group pickers. *  `CustomFieldContextDefaultValueURL` (type `url`) for URLs. *  `CustomFieldContextDefaultValueProject` (type `project`) for project pickers. *  `CustomFieldContextDefaultValueFloat` (type `float`) for floats (floating-point numbers). *  `CustomFieldContextDefaultValueLabels` (type `labels`) for labels. *  `CustomFieldContextDefaultValueTextField` (type `textfield`) for text fields. *  `CustomFieldContextDefaultValueTextArea` (type `textarea`) for text area fields. *  `CustomFieldContextDefaultValueReadOnly` (type `readonly`) for read only (text) fields. *  `CustomFieldContextDefaultValueMultipleVersion` (type `version.multiple`) for single choice version pickers. *  `CustomFieldContextDefaultValueSingleVersion` (type `version.single`) for multiple choice version pickers.Forge custom fields [types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/#data-types) are also supported, returning: *  `CustomFieldContextDefaultValueForgeStringFieldBean` (type `forge.string`) for Forge string fields. *  `CustomFieldContextDefaultValueForgeMultiStringFieldBean` (type `forge.string.list`) for Forge string collection fields. *  `CustomFieldContextDefaultValueForgeObjectFieldBean` (type `forge.object`) for Forge object fields. *  `CustomFieldContextDefaultValueForgeDateTimeFieldBean` (type `forge.datetime`) for Forge date-time fields. *  `CustomFieldContextDefaultValueForgeGroupFieldBean` (type `forge.group`) for Forge group fields. *  `CustomFieldContextDefaultValueForgeMultiGroupFieldBean` (type `forge.group.list`) for Forge group collection fields. *  `CustomFieldContextDefaultValueForgeNumberFieldBean` (type `forge.number`) for Forge number fields. *  `CustomFieldContextDefaultValueForgeUserFieldBean` (type `forge.user`) for Forge user fields. *  `CustomFieldContextDefaultValueForgeMultiUserFieldBean` (type `forge.user.list`) for Forge user collection fields.Only one type of default object can be included in a request. To remove a default for a context, set the default parameter to `null`.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Default values to update.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(CustomFieldContextDefaultValueUpdate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(CustomFieldContextDefaultValueUpdate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="DefaultValueRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DefaultValueRequestBuilder WithUrl(string rawUrl)
        {
            return new DefaultValueRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of defaults for a custom field. The results can be filtered by `contextId`, otherwise all values are returned. If no defaults are set for a context, nothing is returned.  The returned object depends on type of the custom field: *  `CustomFieldContextDefaultValueDate` (type `datepicker`) for date fields. *  `CustomFieldContextDefaultValueDateTime` (type `datetimepicker`) for date-time fields. *  `CustomFieldContextDefaultValueSingleOption` (type `option.single`) for single choice select lists and radio buttons. *  `CustomFieldContextDefaultValueMultipleOption` (type `option.multiple`) for multiple choice select lists and checkboxes. *  `CustomFieldContextDefaultValueCascadingOption` (type `option.cascading`) for cascading select lists. *  `CustomFieldContextSingleUserPickerDefaults` (type `single.user.select`) for single users. *  `CustomFieldContextDefaultValueMultiUserPicker` (type `multi.user.select`) for user lists. *  `CustomFieldContextDefaultValueSingleGroupPicker` (type `grouppicker.single`) for single choice group pickers. *  `CustomFieldContextDefaultValueMultipleGroupPicker` (type `grouppicker.multiple`) for multiple choice group pickers. *  `CustomFieldContextDefaultValueURL` (type `url`) for URLs. *  `CustomFieldContextDefaultValueProject` (type `project`) for project pickers. *  `CustomFieldContextDefaultValueFloat` (type `float`) for floats (floating-point numbers). *  `CustomFieldContextDefaultValueLabels` (type `labels`) for labels. *  `CustomFieldContextDefaultValueTextField` (type `textfield`) for text fields. *  `CustomFieldContextDefaultValueTextArea` (type `textarea`) for text area fields. *  `CustomFieldContextDefaultValueReadOnly` (type `readonly`) for read only (text) fields. *  `CustomFieldContextDefaultValueMultipleVersion` (type `version.multiple`) for single choice version pickers. *  `CustomFieldContextDefaultValueSingleVersion` (type `version.single`) for multiple choice version pickers.Forge custom fields [types](https://developer.atlassian.com/platform/forge/manifest-reference/modules/jira-custom-field-type/#data-types) are also supported, returning: *  `CustomFieldContextDefaultValueForgeStringFieldBean` (type `forge.string`) for Forge string fields. *  `CustomFieldContextDefaultValueForgeMultiStringFieldBean` (type `forge.string.list`) for Forge string collection fields. *  `CustomFieldContextDefaultValueForgeObjectFieldBean` (type `forge.object`) for Forge object fields. *  `CustomFieldContextDefaultValueForgeDateTimeFieldBean` (type `forge.datetime`) for Forge date-time fields. *  `CustomFieldContextDefaultValueForgeGroupFieldBean` (type `forge.group`) for Forge group fields. *  `CustomFieldContextDefaultValueForgeMultiGroupFieldBean` (type `forge.group.list`) for Forge group collection fields. *  `CustomFieldContextDefaultValueForgeNumberFieldBean` (type `forge.number`) for Forge number fields. *  `CustomFieldContextDefaultValueForgeUserFieldBean` (type `forge.user`) for Forge user fields. *  `CustomFieldContextDefaultValueForgeMultiUserFieldBean` (type `forge.user.list`) for Forge user collection fields.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class DefaultValueRequestBuilderGetQueryParameters 
        {
            /// <summary>The IDs of the contexts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("contextId")]
            public long?[]? ContextId { get; set; }
#nullable restore
#else
            [QueryParameter("contextId")]
            public long?[] ContextId { get; set; }
#endif
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
        public class DefaultValueRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultValueRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DefaultValueRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
