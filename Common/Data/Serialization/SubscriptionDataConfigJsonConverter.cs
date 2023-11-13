/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

using QuantConnect.Util;
using System;

namespace QuantConnect.Data.Serialization
{
    /// <summary>
    /// Defines how subscription data configurations should be serialized to json
    /// </summary>
    public class SubscriptionDataConfigJsonConverter : TypeChangeJsonConverter<SubscriptionDataConfig, SerializedSubscriptionDataConfig>
    {
        /// <summary>
        /// Convert the input value to a value to be serialzied
        /// </summary>
        /// <param name="value">The input value to be converted before serialziation</param>
        /// <returns>A new instance of TResult that is to be serialzied</returns>
        protected override SerializedSubscriptionDataConfig Convert(SubscriptionDataConfig value)
        {
            return new SerializedSubscriptionDataConfig(value);
        }

        /// <summary>
        /// Converts the input value to be deserialized
        /// </summary>
        /// <param name="value">The deserialized value that needs to be converted to <see cref="SubscriptionDataConfig"/></param>
        /// <returns>The converted value</returns>
        protected override SubscriptionDataConfig Convert(SerializedSubscriptionDataConfig value)
        {
            throw new NotImplementedException("Not implemented: subscription data configurations cannot be deserialized");
        }
    }
}