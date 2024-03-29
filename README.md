# gu_rest_api - the C# library for the Golem unlimited low level hub API

API description in Markdown.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out gu_rest_api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: serviceToken
            Configuration.Default.ApiKey.Add("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.ApiKey.Add("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-GU-APPNAME", "Bearer");

            var apiInstance = new PeerApi();
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var spec = new DeploymentSpec(); // DeploymentSpec | 

            try
            {
                string result = apiInstance.CreateDeployment(nodeId, spec);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.CreateDeployment: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://127.0.0.1:61622*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PeerApi* | [**CreateDeployment**](docs/PeerApi.md#createdeployment) | **POST** /peers/{nodeId}/deployments | 
*PeerApi* | [**DropDeployment**](docs/PeerApi.md#dropdeployment) | **DELETE** /peers/{nodeId}/deployments/{deploymentId} | Removes deployment
*PeerApi* | [**GetHubInfo**](docs/PeerApi.md#gethubinfo) | **GET** /info | 
*PeerApi* | [**GetPeerDetails**](docs/PeerApi.md#getpeerdetails) | **GET** /peers/{nodeId} | Returns detailed peer info
*PeerApi* | [**ListDeployments**](docs/PeerApi.md#listdeployments) | **GET** /peers/{nodeId}/deployments | 
*PeerApi* | [**ListPeers**](docs/PeerApi.md#listpeers) | **GET** /peers | Returns a list hub peers.
*PeerApi* | [**UpdateDeployment**](docs/PeerApi.md#updatedeployment) | **PATCH** /peers/{nodeId}/deployments/{deploymentId} | 
*SessionApi* | [**AddSessionPeers**](docs/SessionApi.md#addsessionpeers) | **POST** /sessions/{sessionId}/peers | Manually adds peers to hub session
*SessionApi* | [**CreateBlob**](docs/SessionApi.md#createblob) | **POST** /sessions/{sessionId}/blobs | Creates new lob
*SessionApi* | [**CreateDeployment**](docs/SessionApi.md#createdeployment) | **POST** /sessions/{sessionId}/peers/{nodeId}/deployments | Creates new deployment
*SessionApi* | [**CreateSession**](docs/SessionApi.md#createsession) | **POST** /sessions | Creates new hub session.
*SessionApi* | [**DeleteBlob**](docs/SessionApi.md#deleteblob) | **DELETE** /sessions/{sessionId}/blobs/{blobId} | 
*SessionApi* | [**DeleteDeployment**](docs/SessionApi.md#deletedeployment) | **DELETE** /sessions/{sessionId}/peers/{nodeId}/deployments/{deploymentId} | 
*SessionApi* | [**DeleteSession**](docs/SessionApi.md#deletesession) | **DELETE** /sessions/{sessionId} | 
*SessionApi* | [**DownloadBlob**](docs/SessionApi.md#downloadblob) | **GET** /sessions/{sessionId}/blobs/{blobId} | Downloads binary content from the hub
*SessionApi* | [**GetConfig**](docs/SessionApi.md#getconfig) | **GET** /sessions/{sessionId}/config | Gets configuration from stash
*SessionApi* | [**GetHubInfo**](docs/SessionApi.md#gethubinfo) | **GET** /info | 
*SessionApi* | [**GetSession**](docs/SessionApi.md#getsession) | **GET** /sessions/{sessionId} | Gets hub session info
*SessionApi* | [**ListBlobs**](docs/SessionApi.md#listblobs) | **GET** /sessions/{sessionId}/blobs | Lists currently allocated lobs
*SessionApi* | [**ListSessionPeers**](docs/SessionApi.md#listsessionpeers) | **GET** /sessions/{sessionId}/peers | List session peers
*SessionApi* | [**ListSessions**](docs/SessionApi.md#listsessions) | **GET** /sessions | Lists current hub sessions.
*SessionApi* | [**SetConfig**](docs/SessionApi.md#setconfig) | **PUT** /sessions/{sessionId}/config | Sets configuration stash
*SessionApi* | [**UpdateDeployment**](docs/SessionApi.md#updatedeployment) | **PATCH** /sessions/{sessionId}/peers/{nodeId}/deployments/{deploymentId} | Sends multiple commands for peer
*SessionApi* | [**UpdateSession**](docs/SessionApi.md#updatesession) | **PATCH** /sessions/{sessionId} | Hub session update
*SessionApi* | [**UploadBlob**](docs/SessionApi.md#uploadblob) | **PUT** /sessions/{sessionId}/blobs/{blobId} | Uploads a binary content to the hub.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BlobInfo](docs/BlobInfo.md)
 - [Model.BuildInfo](docs/BuildInfo.md)
 - [Model.Command](docs/Command.md)
 - [Model.DeploymentInfo](docs/DeploymentInfo.md)
 - [Model.DeploymentSpec](docs/DeploymentSpec.md)
 - [Model.DeploymentSpecImage](docs/DeploymentSpecImage.md)
 - [Model.DeploymentStatus](docs/DeploymentStatus.md)
 - [Model.DockerCreateOptions](docs/DockerCreateOptions.md)
 - [Model.DockerNetDef](docs/DockerNetDef.md)
 - [Model.DownloadFileCommand](docs/DownloadFileCommand.md)
 - [Model.EnvType](docs/EnvType.md)
 - [Model.ExecCommand](docs/ExecCommand.md)
 - [Model.FileFormat](docs/FileFormat.md)
 - [Model.HubInfo](docs/HubInfo.md)
 - [Model.HubSession](docs/HubSession.md)
 - [Model.HubSessionCommand](docs/HubSessionCommand.md)
 - [Model.HubSessionTouchCommand](docs/HubSessionTouchCommand.md)
 - [Model.PeerDetails](docs/PeerDetails.md)
 - [Model.PeerInfo](docs/PeerInfo.md)
 - [Model.ProcessInfo](docs/ProcessInfo.md)
 - [Model.StartCommand](docs/StartCommand.md)
 - [Model.StopCommand](docs/StopCommand.md)
 - [Model.UploadFileCommand](docs/UploadFileCommand.md)
 - [Model.VolumeDef](docs/VolumeDef.md)
 - [Model.VolumeDefBindRw](docs/VolumeDefBindRw.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="serviceToken"></a>
### serviceToken

- **Type**: API key
- **API key parameter name**: X-GU-APIKEY
- **Location**: HTTP header

<a name="systemName"></a>
### systemName

- **Type**: API key
- **API key parameter name**: X-GU-APPNAME
- **Location**: HTTP header

