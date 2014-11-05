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
    /// The output definition.
    /// </summary>
    public partial class Output
    {
        private string _name;
        
        /// <summary>
        /// Required. The name of the output.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OutputProperties _outputProperties;
        
        /// <summary>
        /// Required. The properties of the output.
        /// </summary>
        public OutputProperties OutputProperties
        {
            get { return this._outputProperties; }
            set { this._outputProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Output class.
        /// </summary>
        public Output()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Output class with required
        /// arguments.
        /// </summary>
        public Output(string name, OutputProperties outputProperties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (outputProperties == null)
            {
                throw new ArgumentNullException("outputProperties");
            }
            this.Name = name;
            this.OutputProperties = outputProperties;
        }
    }
}
