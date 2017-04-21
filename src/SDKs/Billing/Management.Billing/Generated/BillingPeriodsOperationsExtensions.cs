// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingPeriodsOperations.
    /// </summary>
    public static partial class BillingPeriodsOperationsExtensions
    {
            /// <summary>
            /// Lists the available billing periods for a subscription in reverse
            /// chronological order.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=844490" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter billing periods by billingPeriodEndDate. The filter
            /// supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently
            /// support 'ne', 'or', or 'not'.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N billing
            /// periods.
            /// </param>
            public static IPage<BillingPeriod> List(this IBillingPeriodsOperations operations, string filter = default(string), string skiptoken = default(string), int? top = default(int?))
            {
                return operations.ListAsync(filter, skiptoken, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available billing periods for a subscription in reverse
            /// chronological order.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=844490" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter billing periods by billingPeriodEndDate. The filter
            /// supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently
            /// support 'ne', 'or', or 'not'.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N billing
            /// periods.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingPeriod>> ListAsync(this IBillingPeriodsOperations operations, string filter = default(string), string skiptoken = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(filter, skiptoken, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a named billing period.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingPeriodName'>
            /// The name of a BillingPeriod resource.
            /// </param>
            public static BillingPeriod Get(this IBillingPeriodsOperations operations, string billingPeriodName)
            {
                return operations.GetAsync(billingPeriodName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a named billing period.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingPeriodName'>
            /// The name of a BillingPeriod resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingPeriod> GetAsync(this IBillingPeriodsOperations operations, string billingPeriodName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingPeriodName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available billing periods for a subscription in reverse
            /// chronological order.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=844490" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BillingPeriod> ListNext(this IBillingPeriodsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available billing periods for a subscription in reverse
            /// chronological order.
            /// <see href="https://go.microsoft.com/fwlink/?linkid=844490" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BillingPeriod>> ListNextAsync(this IBillingPeriodsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
