// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AccountOperations operations.
    /// </summary>
    public partial interface IAccountOperations
    {
        /// <summary>
        /// Deletes the specified firewall rule from the specified Data Lake
        /// Store account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to delete the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteFirewallRuleWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the
        /// firewall rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FirewallRule>> GetFirewallRuleWithHttpMessagesAsync(string resourceGroupName, string accountName, string firewallRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data
        /// Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the
        /// firewall rules.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<FirewallRule>>> ListFirewallRulesWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates the specified firewall rule.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to which to add the
        /// firewall rule.
        /// </param>
        /// <param name='name'>
        /// The name of the firewall rule to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create the create firewall rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<FirewallRule>> CreateOrUpdateFirewallRuleWithHttpMessagesAsync(string resourceGroupName, string accountName, string name, FirewallRule parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to create.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> CreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to create.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Store account information.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> UpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified Data Lake Store account information.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='name'>
        /// The name of the Data Lake Store account to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the Data Lake Store account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeStoreAccount parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource
        /// group. The response includes a link to the next page of results,
        /// if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Store account(s).
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to
        /// just those requested, e.g.
        /// Categories?$select=CategoryName,Description. Optional.
        /// </param>
        /// <param name='count'>
        /// A Boolean value of true or false to request a count of the
        /// matching resources included with the resources in the response,
        /// e.g. Categories?$count=true. Optional.
        /// </param>
        /// <param name='search'>
        /// A free form search. A free-text search expression to match for
        /// whether a particular entry should be included in the feed, e.g.
        /// Categories?$search=blue OR green. Optional.
        /// </param>
        /// <param name='format'>
        /// The desired return format. Return the response in particular
        /// formatxii without access to request headers for standard
        /// content-type negotiation (e.g Orders?$format=json). Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The
        /// response includes a link to the next page of results, if any.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to
        /// just those requested, e.g.
        /// Categories?$select=CategoryName,Description. Optional.
        /// </param>
        /// <param name='count'>
        /// The Boolean value of true or false to request a count of the
        /// matching resources included with the resources in the response,
        /// e.g. Categories?$count=true. Optional.
        /// </param>
        /// <param name='search'>
        /// A free form search. A free-text search expression to match for
        /// whether a particular entry should be included in the feed, e.g.
        /// Categories?$search=blue OR green. Optional.
        /// </param>
        /// <param name='format'>
        /// The desired return format. Return the response in particular
        /// formatxii without access to request headers for standard
        /// content-type negotiation (e.g Orders?$format=json). Optional.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListWithHttpMessagesAsync(ODataQuery<DataLakeStoreAccount> odataQuery = default(ODataQuery<DataLakeStoreAccount>), string select = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store firewall rules within the specified Data
        /// Lake Store account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<FirewallRule>>> ListFirewallRulesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within a specific resource
        /// group. The response includes a link to the next page of results,
        /// if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Store accounts within the subscription. The
        /// response includes a link to the next page of results, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
