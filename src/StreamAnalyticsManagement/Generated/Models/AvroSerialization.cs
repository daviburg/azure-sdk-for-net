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
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The Avro serialization.
    /// </summary>
    public partial class AvroSerialization : Serialization
    {
        private AvroSerializationProperties _avroSerializationProperties;
        
        /// <summary>
        /// Required. The properties of the AVRO serialization.
        /// </summary>
        public AvroSerializationProperties AvroSerializationProperties
        {
            get { return this._avroSerializationProperties; }
            set { this._avroSerializationProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AvroSerialization class.
        /// </summary>
        public AvroSerialization()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AvroSerialization class with
        /// required arguments.
        /// </summary>
        public AvroSerialization(AvroSerializationProperties avroSerializationProperties)
            : this()
        {
            if (avroSerializationProperties == null)
            {
                throw new ArgumentNullException("avroSerializationProperties");
            }
            this.AvroSerializationProperties = avroSerializationProperties;
        }
    }
}
