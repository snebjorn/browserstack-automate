﻿// Copyright (c) Martin Costello, 2015. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

namespace MartinCostello.BrowserStack.Automate
{
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;

    /// <summary>
    /// A class containing extension methods for the <see cref="BrowserStackAutomateClient"/> class. This class cannot be inherited.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class BrowserStackAutomateClientExtensions
    {
        /// <summary>
        /// Sets the status of the session with the specified Id as having completed as an asynchronous operation.
        /// </summary>
        /// <param name="client">The <c>BrowserStack</c> Automate client.</param>
        /// <param name="sessionId">The session Id to set the status of.</param>
        /// <param name="reason">An optional reason to specify.</param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the asynchronous operation to set the status of the session with the specified Id as having completed.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="client"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="sessionId"/> is <see langword="null"/> or white space.
        /// </exception>
        public static async Task<SessionItem> SetSessionCompletedAsync(this BrowserStackAutomateClient client, string sessionId, string reason)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return await client.SetSessionStatusAsync(sessionId, SessionStatuses.Completed, reason);
        }

        /// <summary>
        /// Sets the status of the session with the specified Id as having an error as an asynchronous operation.
        /// </summary>
        /// <param name="client">The <c>BrowserStack</c> Automate client.</param>
        /// <param name="sessionId">The session Id to set the status of.</param>
        /// <param name="reason">An optional reason to specify.</param>
        /// <returns>
        /// A <see cref="Task{TResult}"/> representing the asynchronous operation to set the status of the session with the specified Id as having an error.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="client"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="sessionId"/> is <see langword="null"/> or white space.
        /// </exception>
        public static async Task<SessionItem> SetSessionErrorAsync(this BrowserStackAutomateClient client, string sessionId, string reason)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return await client.SetSessionStatusAsync(sessionId, SessionStatuses.Error, reason);
        }
    }
}
