﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.TrafficManager.Testing.ScenarioTests
{
    using System.Collections.Generic;
    using System.Linq;
    using global::TrafficManager.Tests.Helpers;
    using Microsoft.Azure.Management.Resources.Models;
    using Microsoft.Azure.Management.TrafficManager.Models;
    using Microsoft.Azure.Management.TrafficManager.Testing.Helpers;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Xunit;

    public class ProfileScenarioTests : TestBase
    {
        [Fact]
        public void CrudProfileFullCycle()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                TrafficManagerManagementClient trafficManagerClient = this.GetTrafficManagerManagementClient(context);

                string resourceGroupName = TestUtilities.GenerateName("resourcegroup");
                string profileName = TestUtilities.GenerateName("atmprofile");
                ResourceGroup resourceGroup = this.CreateResourceGroup(context, resourceGroupName);

                // Create the profile
                trafficManagerClient.Profiles.CreateOrUpdate(
                    resourceGroup.Name, 
                    profileName,
                    TrafficManagerHelper.GenerateDefaultProfile(profileName));

                // Get the profile
                trafficManagerClient.Profiles.Get(
                    resourceGroup.Name,
                    profileName);

                // Delete the profile
                trafficManagerClient.Profiles.Delete(resourceGroup.Name, profileName);

                this.DeleteResourceGroup(context, resourceGroupName);
            }
        }
        
        [Fact]
        public void CrudProfileWithoutEndpoints_ThenUpdate()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                TrafficManagerManagementClient trafficManagerClient = this.GetTrafficManagerManagementClient(context);

                string resourceGroupName = TestUtilities.GenerateName("resourcegroup");
                string profileName = TestUtilities.GenerateName("atmprofile");
                ResourceGroup resourceGroup = this.CreateResourceGroup(context, resourceGroupName);

                Profile profile = TrafficManagerHelper.GenerateDefaultProfile(profileName);
                profile.Endpoints = null;

                // Create the profile
                trafficManagerClient.Profiles.CreateOrUpdate(
                    resourceGroup.Name,
                    profileName,
                    profile);

                profile.Endpoints = new[]
                {
                    new Endpoint
                    {
                        Id = null,
                        Name = "My external endpoint",
                        Type = "Microsoft.network/TrafficManagerProfiles/ExternalEndpoints",
                        TargetResourceId = null,
                        Target = "foobar.contoso.com",
                        EndpointLocation = "North Europe",
                        EndpointStatus = "Enabled"
                    } 
                };

                // Create the profile
                trafficManagerClient.Profiles.CreateOrUpdate(
                    resourceGroup.Name,
                    profileName,
                    profile);

                this.DeleteResourceGroup(context, resourceGroupName);
            }
        }
        
        [Fact]
        public void ListProfilesByResourceGroup()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                TrafficManagerManagementClient trafficManagerClient = this.GetTrafficManagerManagementClient(context);

                string resourceGroupName = TestUtilities.GenerateName("resourcegroup");
                ResourceGroup resourceGroup = this.CreateResourceGroup(context, resourceGroupName);

                for (int i = 0; i < 5; ++i)
                {
                    string profileName = TestUtilities.GenerateName("atmprofile");

                    trafficManagerClient.Profiles.CreateOrUpdate(
                        resourceGroup.Name,
                        profileName,
                        TrafficManagerHelper.GenerateDefaultProfile(profileName));
                }

                List<Profile> listResponse = trafficManagerClient.Profiles.ListAllInResourceGroup(resourceGroup.Name).ToList();

                Assert.Equal(5, listResponse.Count);

                this.DeleteResourceGroup(context, resourceGroupName);
            }
        }

        [Fact]
        public void ListAllProfiles()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                TrafficManagerManagementClient trafficManagerClient = this.GetTrafficManagerManagementClient(context);

                string resourceGroupName = TestUtilities.GenerateName("resourcegroup");
                ResourceGroup resourceGroup = this.CreateResourceGroup(context, resourceGroupName);

                for (int i = 0; i < 5; ++i)
                {
                    string profileName = TestUtilities.GenerateName("atmprofile");

                    trafficManagerClient.Profiles.CreateOrUpdate(
                        resourceGroup.Name,
                        profileName,
                        TrafficManagerHelper.GenerateDefaultProfile(profileName));
                }

                IEnumerable<Profile> listResponse = trafficManagerClient.Profiles.ListAll();

                // Just in case the subscription had some other profiles
                Assert.True(5 <= listResponse.Count());

                this.DeleteResourceGroup(context, resourceGroupName);
            }
        }
    }
}
