// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Webhook base
    /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
    /// </summary>
    public abstract partial class MachineLearningWebhook
    {
        /// <summary> Initializes a new instance of MachineLearningWebhook. </summary>
        protected MachineLearningWebhook()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWebhook. </summary>
        /// <param name="eventType"> Send callback on a specified notification event. </param>
        /// <param name="webhookType"> [Required] Specifies the type of service to send a callback. </param>
        internal MachineLearningWebhook(string eventType, MachineLearningWebhookType webhookType)
        {
            EventType = eventType;
            WebhookType = webhookType;
        }

        /// <summary> Send callback on a specified notification event. </summary>
        public string EventType { get; set; }
        /// <summary> [Required] Specifies the type of service to send a callback. </summary>
        internal MachineLearningWebhookType WebhookType { get; set; }
    }
}
