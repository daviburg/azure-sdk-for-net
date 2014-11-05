// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the EventHub data source as stream input.
    /// </summary>
    public partial class EventHubStreamInputDataSourceProperties
    {
        private string _eventHubName;
        
        /// <summary>
        /// Required. The EventHub name.
        /// </summary>
        public string EventHubName
        {
            get { return this._eventHubName; }
            set { this._eventHubName = value; }
        }
        
        private string _serviceBusNamespace;
        
        /// <summary>
        /// Required. The service bus namespace of the event hub.
        /// </summary>
        public string ServiceBusNamespace
        {
            get { return this._serviceBusNamespace; }
            set { this._serviceBusNamespace = value; }
        }
        
        private string _sharedAccessPolicyKey;
        
        /// <summary>
        /// Required. The shared access policy key.
        /// </summary>
        public string SharedAccessPolicyKey
        {
            get { return this._sharedAccessPolicyKey; }
            set { this._sharedAccessPolicyKey = value; }
        }
        
        private string _sharedAccessPolicyName;
        
        /// <summary>
        /// Required. The shared access policy name.
        /// </summary>
        public string SharedAccessPolicyName
        {
            get { return this._sharedAccessPolicyName; }
            set { this._sharedAccessPolicyName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// EventHubStreamInputDataSourceProperties class.
        /// </summary>
        public EventHubStreamInputDataSourceProperties()
        {
        }
    }
}
