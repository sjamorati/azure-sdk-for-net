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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List Resource Extensions operation response.
    /// </summary>
    public partial class VirtualMachineExtensionListResponse : OperationResponse, IEnumerable<VirtualMachineExtensionListResponse.ResourceExtension>
    {
        private IList<VirtualMachineExtensionListResponse.ResourceExtension> _resourceExtensions;
        
        /// <summary>
        /// Optional. The extensions that are available to add to your cloud
        /// service.
        /// </summary>
        public IList<VirtualMachineExtensionListResponse.ResourceExtension> ResourceExtensions
        {
            get { return this._resourceExtensions; }
            set { this._resourceExtensions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineExtensionListResponse class.
        /// </summary>
        public VirtualMachineExtensionListResponse()
        {
            this._resourceExtensions = new List<VirtualMachineExtensionListResponse.ResourceExtension>();
        }
        
        /// <summary>
        /// Gets the sequence of ResourceExtensions.
        /// </summary>
        public IEnumerator<VirtualMachineExtensionListResponse.ResourceExtension> GetEnumerator()
        {
            return this.ResourceExtensions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ResourceExtensions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An extension available to add to your virtual machine.
        /// </summary>
        public partial class ResourceExtension
        {
            private string _description;
            
            /// <summary>
            /// Optional. The description of the extension.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private Uri _eula;
            
            /// <summary>
            /// Optional. URI string pointing to the EULA (End User License
            /// Agreement) of this version of extension. This is optionally
            /// specified by the third-party publishing the extension instead
            /// of Azure, at the time of extension creation or update.
            /// </summary>
            public Uri Eula
            {
                get { return this._eula; }
                set { this._eula = value; }
            }
            
            private Uri _homepageUri;
            
            /// <summary>
            /// Optional. URI string pointing to the homepage of this version
            /// of extension. This is optionally specified by the third-party
            /// publishing the extension instead of Azure, at the time of
            /// extension creation or update.
            /// </summary>
            public Uri HomepageUri
            {
                get { return this._homepageUri; }
                set { this._homepageUri = value; }
            }
            
            private bool? _isJsonExtension;
            
            /// <summary>
            /// Optional. Indicates whether the extension accepts JSON or XML
            /// based configuration. If this property is 'true' the extension
            /// accepts JSON based configuration. If this property is 'false'
            /// the extension accepts XML based configuration.
            /// </summary>
            public bool? IsJsonExtension
            {
                get { return this._isJsonExtension; }
                set { this._isJsonExtension = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. The label that is used to identify the extension.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of the extension.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private Uri _privacyUri;
            
            /// <summary>
            /// Optional. URI string pointing to the privacy document of this
            /// version of extension. This is optionally specified by the
            /// third-party publishing the extension instead of Azure, at the
            /// time of extension creation or update.
            /// </summary>
            public Uri PrivacyUri
            {
                get { return this._privacyUri; }
                set { this._privacyUri = value; }
            }
            
            private string _privateConfigurationSchema;
            
            /// <summary>
            /// Optional. The base64-encoded schema of the private
            /// configuration.
            /// </summary>
            public string PrivateConfigurationSchema
            {
                get { return this._privateConfigurationSchema; }
                set { this._privateConfigurationSchema = value; }
            }
            
            private string _publicConfigurationSchema;
            
            /// <summary>
            /// Optional. The base64-encoded schema of the public configuration.
            /// </summary>
            public string PublicConfigurationSchema
            {
                get { return this._publicConfigurationSchema; }
                set { this._publicConfigurationSchema = value; }
            }
            
            private string _publisher;
            
            /// <summary>
            /// Optional. The provider namespace of the extension. The provider
            /// namespace for Azure extensions is Microsoft.Compute.
            /// </summary>
            public string Publisher
            {
                get { return this._publisher; }
                set { this._publisher = value; }
            }
            
            private bool? _replicationCompleted;
            
            /// <summary>
            /// Optional. Indicates whether this version of extension has been
            /// replicated to all regions or not. If true, then the given
            /// extension version can be used in creating or updating
            /// deployments. Otherwise, the given extension version might
            /// cause failure in creating or updating deployments. The typical
            /// time is 20 minutes for a newly-registered or newly-updated
            /// extension to replicate completely by Azure.
            /// </summary>
            public bool? ReplicationCompleted
            {
                get { return this._replicationCompleted; }
                set { this._replicationCompleted = value; }
            }
            
            private string _sampleConfig;
            
            /// <summary>
            /// Optional. A sample configuration file for the resource
            /// extension.
            /// </summary>
            public string SampleConfig
            {
                get { return this._sampleConfig; }
                set { this._sampleConfig = value; }
            }
            
            private string _version;
            
            /// <summary>
            /// Optional. The version of the extension.
            /// </summary>
            public string Version
            {
                get { return this._version; }
                set { this._version = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ResourceExtension class.
            /// </summary>
            public ResourceExtension()
            {
            }
        }
    }
}
