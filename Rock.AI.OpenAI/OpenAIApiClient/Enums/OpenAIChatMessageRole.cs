﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.AI.OpenAI.OpenAIApiClient.Enums
{
    /// <summary>
    /// The various roles for OpenAI chat messages
    /// </summary>
    public enum OpenAIChatMessageRole
    {
        /// <summary>
        /// Represents the message sent by the user, which usually includes questions, statements, or conversation prompts.
        /// </summary>
        [Description("user")]
        User = 0,
        /// <summary>
        /// Represents a system instruction or directive, usually setting the context or providing guidelines for the AI's behavior in the conversation.
        /// </summary>
        [Description( "system" )]
        System = 1,
        /// <summary>
        /// Represents the response generated by the AI model, in reply to the user's message or following the system instructions.
        /// </summary>
        [Description( "assistant" )]
        Assistant = 2
    }
}
