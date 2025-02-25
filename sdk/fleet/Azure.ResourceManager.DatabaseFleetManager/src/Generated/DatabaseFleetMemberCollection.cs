// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DatabaseFleetManager
{
    /// <summary>
    /// A class representing a collection of <see cref="DatabaseFleetMemberResource" /> and their operations.
    /// Each <see cref="DatabaseFleetMemberResource" /> in the collection will belong to the same instance of <see cref="DatabaseFleetResource" />.
    /// To get a <see cref="DatabaseFleetMemberCollection" /> instance call the GetDatabaseFleetMembers method from an instance of <see cref="DatabaseFleetResource" />.
    /// </summary>
    public partial class DatabaseFleetMemberCollection : ArmCollection, IEnumerable<DatabaseFleetMemberResource>, IAsyncEnumerable<DatabaseFleetMemberResource>
    {
        private readonly ClientDiagnostics _databaseFleetMemberFleetMembersClientDiagnostics;
        private readonly FleetMembersRestOperations _databaseFleetMemberFleetMembersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatabaseFleetMemberCollection"/> class for mocking. </summary>
        protected DatabaseFleetMemberCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseFleetMemberCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatabaseFleetMemberCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseFleetMemberFleetMembersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseFleetManager", DatabaseFleetMemberResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatabaseFleetMemberResource.ResourceType, out string databaseFleetMemberFleetMembersApiVersion);
            _databaseFleetMemberFleetMembersRestClient = new FleetMembersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseFleetMemberFleetMembersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatabaseFleetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatabaseFleetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseFleetMemberResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fleetMemberName, DatabaseFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseFleetMemberFleetMembersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseFleetManagerArmOperation<DatabaseFleetMemberResource>(new DatabaseFleetMemberOperationSource(Client), _databaseFleetMemberFleetMembersClientDiagnostics, Pipeline, _databaseFleetMemberFleetMembersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseFleetMemberResource> CreateOrUpdate(WaitUntil waitUntil, string fleetMemberName, DatabaseFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseFleetMemberFleetMembersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DatabaseFleetManagerArmOperation<DatabaseFleetMemberResource>(new DatabaseFleetMemberOperationSource(Client), _databaseFleetMemberFleetMembersClientDiagnostics, Pipeline, _databaseFleetMemberFleetMembersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<Response<DatabaseFleetMemberResource>> GetAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FleetMember
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual Response<DatabaseFleetMemberResource> Get(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List FleetMember resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseFleetMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseFleetMemberResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseFleetMemberFleetMembersRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseFleetMemberFleetMembersRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetMemberResource(Client, DatabaseFleetMemberData.DeserializeDatabaseFleetMemberData(e)), _databaseFleetMemberFleetMembersClientDiagnostics, Pipeline, "DatabaseFleetMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FleetMember resources by Fleet
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_ListByFleet</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseFleetMemberResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseFleetMemberResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseFleetMemberFleetMembersRestClient.CreateListByFleetRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseFleetMemberFleetMembersRestClient.CreateListByFleetNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetMemberResource(Client, DatabaseFleetMemberData.DeserializeDatabaseFleetMemberData(e)), _databaseFleetMemberFleetMembersClientDiagnostics, Pipeline, "DatabaseFleetMemberCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = await _databaseFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual Response<bool> Exists(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.Exists");
            scope.Start();
            try
            {
                var response = _databaseFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual async Task<NullableResponse<DatabaseFleetMemberResource>> GetIfExistsAsync(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _databaseFleetMemberFleetMembersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseFleetMemberResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/members/{fleetMemberName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FleetMembers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetMemberName"> The name of the Fleet member resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetMemberName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetMemberName"/> is null. </exception>
        public virtual NullableResponse<DatabaseFleetMemberResource> GetIfExists(string fleetMemberName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetMemberName, nameof(fleetMemberName));

            using var scope = _databaseFleetMemberFleetMembersClientDiagnostics.CreateScope("DatabaseFleetMemberCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseFleetMemberFleetMembersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, fleetMemberName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseFleetMemberResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetMemberResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatabaseFleetMemberResource> IEnumerable<DatabaseFleetMemberResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatabaseFleetMemberResource> IAsyncEnumerable<DatabaseFleetMemberResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
