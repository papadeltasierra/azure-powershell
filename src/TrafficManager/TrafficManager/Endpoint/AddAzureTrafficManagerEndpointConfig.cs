﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.TrafficManager.Models;
using Microsoft.Azure.Commands.TrafficManager.Utilities;
using System.Management.Automation;
using ProjectResources = Microsoft.Azure.Commands.TrafficManager.Properties.Resources;

namespace Microsoft.Azure.Commands.TrafficManager
{
    using ResourceManager.Common.ArgumentCompleters;
    using System.Collections.Generic;
    using System.Linq;

    [Cmdlet("Add", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "TrafficManagerEndpointConfig"), OutputType(typeof(TrafficManagerProfile))]
    public class AddAzureTrafficManagerEndpointConfig : TrafficManagerBaseCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "The name of the endpoint.")]
        [ValidateNotNullOrEmpty]
        public string EndpointName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "The profile.")]
        [ValidateNotNullOrEmpty]
        public TrafficManagerProfile TrafficManagerProfile { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The type of the endpoint.")]
        [ValidateSet(Constants.AzureEndpoint, Constants.ExternalEndpoint, Constants.NestedEndpoint, IgnoreCase = true)]
        [ValidateNotNullOrEmpty]
        public string Type { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The resource id of the endpoint.")]
        [ValidateNotNullOrEmpty]
        public string TargetResourceId { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The target of the endpoint.")]
        [ValidateNotNullOrEmpty]
        public string Target { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The status of the endpoint.")]
        [ValidateSet(Constants.StatusEnabled, Constants.StatusDisabled, IgnoreCase = false)]
        [ValidateNotNullOrEmpty]
        public string EndpointStatus { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The weight of the endpoint.")]
        [ValidateNotNullOrEmpty]
        public uint? Weight { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The priority of the endpoint.")]
        [ValidateNotNullOrEmpty]
        public uint? Priority { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The location of the endpoint.")]
        [LocationCompleter("Microsoft.Network/trafficmanagerprofiles")]
        [ValidateNotNullOrEmpty]
        public string EndpointLocation { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "If Always Serve is enabled, probing for endpoint health will be disabled and endpoints will be included in the traffic routing method.")]
        [ValidateSet(Constants.StatusEnabled, Constants.StatusDisabled, IgnoreCase = false)]
        [ValidateNotNullOrEmpty]
        public string AlwaysServe { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The minimum number of endpoints that must be available in the child profile in order for the Nested Endpoint in the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.")]
        [ValidateNotNullOrEmpty]
        public uint? MinChildEndpoints { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The minimum number of  IPv4 (DNS record type A) endpoints that must be available in the child profile in order for the Nested Endpoint in the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.")]
        [ValidateNotNullOrEmpty]
        public uint? MinChildEndpointsIPv4 { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The minimum number of IPv6 (DNS record type AAAA) endpoints that must be available in the child profile in order for the Nested Endpoint in the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.")]
        [ValidateNotNullOrEmpty]
        public uint? MinChildEndpointsIPv6 { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The list of regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager documentation for a full list of accepted values.")]
        [ValidateCount(1, 350)]
        public List<string> GeoMapping { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The list of address ranges or subnets mapped to this endpoint when using the 'Subnet' traffic routing method.")]
        public List<TrafficManagerIpAddressRange> SubnetMapping { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "List of custom header name and value pairs for probe requests.")]
        [ValidateCount(1, 8)]
        public List<TrafficManagerCustomHeader> CustomHeader { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.TrafficManagerProfile.Endpoints == null)
            {
                this.TrafficManagerProfile.Endpoints = new List<TrafficManagerEndpoint>();
            }

            if (this.TrafficManagerProfile.Endpoints.Any(endpoint => string.Equals(this.EndpointName, endpoint.Name)))
            {
                throw new PSArgumentException(string.Format(ProjectResources.Error_AddExistingEndpoint, this.EndpointName));
            }

            this.TrafficManagerProfile.Endpoints.Add(
                new TrafficManagerEndpoint
                {
                    Name = this.EndpointName,
                    Type = this.Type,
                    TargetResourceId = this.TargetResourceId,
                    Target = this.Target,
                    EndpointStatus = this.EndpointStatus,
                    Weight = this.Weight,
                    Priority = this.Priority,
                    Location = this.EndpointLocation,
                    MinChildEndpoints = this.MinChildEndpoints,
                    MinChildEndpointsIPv4 = this.MinChildEndpointsIPv4,
                    MinChildEndpointsIPv6 = this.MinChildEndpointsIPv6,
                    GeoMapping = this.GeoMapping,
                    SubnetMapping = this.SubnetMapping,
                    CustomHeaders = this.CustomHeader,
                    AlwaysServe = this.AlwaysServe
                });

            this.WriteVerbose(ProjectResources.Success);
            this.WriteObject(this.TrafficManagerProfile);
        }
    }
}
