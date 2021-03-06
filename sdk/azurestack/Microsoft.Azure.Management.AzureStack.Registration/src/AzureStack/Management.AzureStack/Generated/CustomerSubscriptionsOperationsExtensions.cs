// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStack
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CustomerSubscriptionsOperations.
    /// </summary>
    public static partial class CustomerSubscriptionsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            public static IPage<CustomerSubscription> List(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName)
            {
                return operations.ListAsync(resourceGroup, registrationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomerSubscription>> ListAsync(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroup, registrationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            public static CustomerSubscription Get(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName)
            {
                return operations.GetAsync(resourceGroup, registrationName, customerSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomerSubscription> GetAsync(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroup, registrationName, customerSubscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a customer subscription under a registration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            public static void Delete(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName)
            {
                operations.DeleteAsync(resourceGroup, registrationName, customerSubscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a customer subscription under a registration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroup, registrationName, customerSubscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new customer subscription under a registration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            /// <param name='customerCreationParameters'>
            /// Parameters use to create a customer subscription.
            /// </param>
            public static CustomerSubscription Create(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName, CustomerSubscription customerCreationParameters)
            {
                return operations.CreateAsync(resourceGroup, registrationName, customerSubscriptionName, customerCreationParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new customer subscription under a registration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='customerSubscriptionName'>
            /// Name of the product.
            /// </param>
            /// <param name='customerCreationParameters'>
            /// Parameters use to create a customer subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomerSubscription> CreateAsync(this ICustomerSubscriptionsOperations operations, string resourceGroup, string registrationName, string customerSubscriptionName, CustomerSubscription customerCreationParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroup, registrationName, customerSubscriptionName, customerCreationParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CustomerSubscription> ListNext(this ICustomerSubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of products.
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
            public static async Task<IPage<CustomerSubscription>> ListNextAsync(this ICustomerSubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
