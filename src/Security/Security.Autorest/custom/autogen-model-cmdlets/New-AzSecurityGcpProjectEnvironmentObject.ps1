
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for GcpProjectEnvironment.
.Description
Create an in-memory object for GcpProjectEnvironment.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Security.Models.GcpProjectEnvironment
.Link
https://learn.microsoft.com/powershell/module/Az.Security/new-azsecuritygcpprojectenvironmentobject
#>
function New-AzSecurityGcpProjectEnvironmentObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Security.Models.GcpProjectEnvironment')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The Gcp project's organizational data.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGcpOrganizationalData]
        $OrganizationalData,
        [Parameter(HelpMessage="The GCP Project id.")]
        [string]
        $ProjectDetailProjectId,
        [Parameter(HelpMessage="The unique GCP Project number.")]
        [string]
        $ProjectDetailProjectNumber,
        [Parameter(HelpMessage="Scan interval in hours (value should be between 1-hour to 24-hours).")]
        [long]
        $ScanInterval
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Security.Models.GcpProjectEnvironment]::New()

        if ($PSBoundParameters.ContainsKey('OrganizationalData')) {
            $Object.OrganizationalData = $OrganizationalData
        }
        if ($PSBoundParameters.ContainsKey('ProjectDetailProjectId')) {
            $Object.ProjectDetailProjectId = $ProjectDetailProjectId
        }
        if ($PSBoundParameters.ContainsKey('ProjectDetailProjectNumber')) {
            $Object.ProjectDetailProjectNumber = $ProjectDetailProjectNumber
        }
        if ($PSBoundParameters.ContainsKey('ScanInterval')) {
            $Object.ScanInterval = $ScanInterval
        }
        return $Object
    }
}

