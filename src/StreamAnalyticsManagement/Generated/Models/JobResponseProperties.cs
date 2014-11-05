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
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of the stream analytics job.
    /// </summary>
    public partial class JobResponseProperties
    {
        private DateTime _createdDate;
        
        /// <summary>
        /// Required. The created date of the stream analytics job.
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }
        
        private string _etag;
        
        /// <summary>
        /// Required. Etag of the stream analytics job.
        /// </summary>
        public string Etag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }
        
        private int _eventsOutOfOrderMaxDelayInMilliseconds;
        
        /// <summary>
        /// Required. The max delay time of the out of order policy of the
        /// stream analytics job. It is in Milliseconds
        /// </summary>
        public int EventsOutOfOrderMaxDelayInMilliseconds
        {
            get { return this._eventsOutOfOrderMaxDelayInMilliseconds; }
            set { this._eventsOutOfOrderMaxDelayInMilliseconds = value; }
        }
        
        private string _eventsOutOfOrderPolicy;
        
        /// <summary>
        /// Required. The out of order policy of the stream analytics job.
        /// </summary>
        public string EventsOutOfOrderPolicy
        {
            get { return this._eventsOutOfOrderPolicy; }
            set { this._eventsOutOfOrderPolicy = value; }
        }
        
        private IList<InputResponse> _inputsInResponse;
        
        /// <summary>
        /// Optional. A list of one or more inputs returned in the response.
        /// </summary>
        public IList<InputResponse> InputsInResponse
        {
            get { return this._inputsInResponse; }
            set { this._inputsInResponse = value; }
        }
        
        private string _jobId;
        
        /// <summary>
        /// Required. Id of the stream analytics job.
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private string _jobState;
        
        /// <summary>
        /// Required. The running state of the stream analytics job.
        /// </summary>
        public string JobState
        {
            get { return this._jobState; }
            set { this._jobState = value; }
        }
        
        private IList<OutputResponse> _outputsInResponse;
        
        /// <summary>
        /// Optional. A list of outputs returned in the response.
        /// </summary>
        public IList<OutputResponse> OutputsInResponse
        {
            get { return this._outputsInResponse; }
            set { this._outputsInResponse = value; }
        }
        
        private string _outputStartMode;
        
        /// <summary>
        /// Required. The output start mode of the stream analytics job.
        /// </summary>
        public string OutputStartMode
        {
            get { return this._outputStartMode; }
            set { this._outputStartMode = value; }
        }
        
        private System.DateTime? _outputStartTime;
        
        /// <summary>
        /// Required. The output start time of the stream analytics job.
        /// </summary>
        public System.DateTime? OutputStartTime
        {
            get { return this._outputStartTime; }
            set { this._outputStartTime = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Required. The provisioning state of the stream analytics job.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private Sku _sku;
        
        /// <summary>
        /// Required. The Sku of the stream analytics job.
        /// </summary>
        public Sku Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }
        
        private Transformation _transformation;
        
        /// <summary>
        /// Optional. The transformation query.
        /// </summary>
        public Transformation Transformation
        {
            get { return this._transformation; }
            set { this._transformation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobResponseProperties class.
        /// </summary>
        public JobResponseProperties()
        {
            this.InputsInResponse = new LazyList<InputResponse>();
            this.OutputsInResponse = new LazyList<OutputResponse>();
        }
    }
}
