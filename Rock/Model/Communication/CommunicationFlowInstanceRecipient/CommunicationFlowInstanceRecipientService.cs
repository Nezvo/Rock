using System.Linq;

using Mono.CSharp;

namespace Rock.Model
{
    partial class CommunicationFlowInstanceRecipientService
    {
        /// <summary>
        /// Retrieves a queryable collection of recipients who have unsubscribed from a specified communication flow.
        /// </summary>
        /// <param name="communicationFlowId">The identifier of the communication flow to check for unsubscribed recipients.</param>
        /// <returns>An <see cref="IQueryable{T}"/> of <see cref="CommunicationFlowInstanceRecipient"/> representing the
        /// recipients who have unsubscribed from the specified communication flow.</returns>
        internal IQueryable<CommunicationFlowInstanceRecipient> GetUnsubscribedFromCommunicationFlow( int communicationFlowId )
        {
            return Queryable()
                .Where( r => r.CommunicationFlowInstance.CommunicationFlowId == communicationFlowId )
                .WhereUnsubscribedFromCommunicationFlow();
        }
    }

    internal static class CommunicationFlowInstanceRecipientServiceExtensions
    {
        /// <summary>
        /// An extension method to filter a queryable to only those that are unsubscribed from a specific communication flow.
        /// </summary>
        /// <param name="queryable">The queryable.</param>
        /// <returns></returns>
        public static IQueryable<CommunicationFlowInstanceRecipient> WhereUnsubscribedFromCommunicationFlow( this IQueryable<CommunicationFlowInstanceRecipient> queryable )
        {
            return queryable.Where( r =>
                r.Status == Enums.Communication.CommunicationFlowInstanceRecipientStatus.Inactive
                && r.InactiveReason == Enums.Communication.CommunicationFlowInstanceRecipientInactiveReason.UnsubscribedFromFlow
            );
        }
    }
}
