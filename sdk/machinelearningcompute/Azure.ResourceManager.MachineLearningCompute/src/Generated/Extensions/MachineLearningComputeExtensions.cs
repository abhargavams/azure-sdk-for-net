// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningCompute
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MachineLearningCompute. </summary>
    public static partial class MachineLearningComputeExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new TenantResourceExtensionClient(client, resource.Id);
            });
        }

        private static TenantResourceExtensionClient GetTenantResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new TenantResourceExtensionClient(client, scope);
            });
        }
        #region OperationalizationClusterResource
        /// <summary>
        /// Gets an object representing an <see cref="OperationalizationClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OperationalizationClusterResource.CreateResourceIdentifier" /> to create an <see cref="OperationalizationClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OperationalizationClusterResource" /> object. </returns>
        public static OperationalizationClusterResource GetOperationalizationClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OperationalizationClusterResource.ValidateResourceId(id);
                return new OperationalizationClusterResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of OperationalizationClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OperationalizationClusterResources and their operations over a OperationalizationClusterResource. </returns>
        public static OperationalizationClusterCollection GetOperationalizationClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetOperationalizationClusters();
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OperationalizationClusterResource>> GetOperationalizationClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetOperationalizationClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the operationalization cluster resource view. Note that the credentials are not returned by this call. Call ListKeys to get them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningCompute/operationalizationClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<OperationalizationClusterResource> GetOperationalizationCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetOperationalizationClusters().Get(clusterName, cancellationToken);
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalizationClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OperationalizationClusterResource> GetOperationalizationClustersAsync(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetOperationalizationClustersAsync(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Gets the operationalization clusters in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MachineLearningCompute/operationalizationClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationalizationClusters_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalizationClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OperationalizationClusterResource> GetOperationalizationClusters(this SubscriptionResource subscriptionResource, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetOperationalizationClusters(skiptoken, cancellationToken);
        }

        /// <summary>
        /// Gets all available operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MachineLearningCompute/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineLearningCompute_ListAvailableOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceOperation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceOperation> GetAvailableOperationsMachineLearningComputesAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetTenantResourceExtensionClient(tenantResource).GetAvailableOperationsMachineLearningComputesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all available operations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MachineLearningCompute/operations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineLearningCompute_ListAvailableOperations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceOperation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceOperation> GetAvailableOperationsMachineLearningComputes(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetTenantResourceExtensionClient(tenantResource).GetAvailableOperationsMachineLearningComputes(cancellationToken);
        }
    }
}
