﻿// <auto-generated>
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
// 
// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.
// 
// For documentation on code generator please visit
//   https://aka.ms/nrp-code-generation
// Please contact wanrpdev@microsoft.com if you need to make changes to this file.
// </auto-generated>

using Microsoft.Azure.Commands.Network.Test.ScenarioTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Commands.Network.Test.ScenarioTests
{
    public class NetworkProfileTests : NetworkTestRunner
    {
        public NetworkProfileTests(Xunit.Abstractions.ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestNetworkProfileCRUDMinimalParameters()
        {
            TestRunner.RunTestScript(string.Format("Test-NetworkProfileCRUDMinimalParameters"));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestNetworkProfileCRUDAllParameters()
        {
            TestRunner.RunTestScript(string.Format("Test-NetworkProfileCRUDAllParameters"));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestContainerNetworkInterfaceConfigCRUDMinimalParameters()
        {
            TestRunner.RunTestScript(string.Format("Test-ContainerNetworkInterfaceConfigCRUDMinimalParameters"));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestContainerNetworkInterfaceConfigCRUD()
        {
            TestRunner.RunTestScript(string.Format("Test-ContainerNetworkInterfaceConfigCRUD"));
        }
    }
}
