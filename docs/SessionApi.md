# gu_rest_api.Api.SessionApi

All URIs are relative to *http://127.0.0.1:61622*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSessionPeers**](SessionApi.md#addsessionpeers) | **POST** /sessions/{sessionId}/peers | Manually adds peers to hub session
[**CreateBlob**](SessionApi.md#createblob) | **POST** /sessions/{sessionId}/blobs | Creates new lob
[**CreateDeployment**](SessionApi.md#createdeployment) | **POST** /sessions/{sessionId}/peers/{nodeId}/deployments | Creates new deployment
[**CreateSession**](SessionApi.md#createsession) | **POST** /sessions | Creates new hub session.
[**DeleteBlob**](SessionApi.md#deleteblob) | **DELETE** /sessions/{sessionId}/blobs/{blobId} | 
[**DeleteDeployment**](SessionApi.md#deletedeployment) | **DELETE** /sessions/{sessionId}/peers/{nodeId}/deployments/{deploymentId} | 
[**DeleteSession**](SessionApi.md#deletesession) | **DELETE** /sessions/{sessionId} | 
[**DownloadBlob**](SessionApi.md#downloadblob) | **GET** /sessions/{sessionId}/blobs/{blobId} | Downloads binary content from the hub
[**GetConfig**](SessionApi.md#getconfig) | **GET** /sessions/{sessionId}/config | Gets configuration from stash
[**GetHubInfo**](SessionApi.md#gethubinfo) | **GET** /info | 
[**GetSession**](SessionApi.md#getsession) | **GET** /sessions/{sessionId} | Gets hub session info
[**ListBlobs**](SessionApi.md#listblobs) | **GET** /sessions/{sessionId}/blobs | Lists currently allocated lobs
[**ListSessionPeers**](SessionApi.md#listsessionpeers) | **GET** /sessions/{sessionId}/peers | List session peers
[**ListSessions**](SessionApi.md#listsessions) | **GET** /sessions | Lists current hub sessions.
[**SetConfig**](SessionApi.md#setconfig) | **PUT** /sessions/{sessionId}/config | Sets configuration stash
[**UpdateDeployment**](SessionApi.md#updatedeployment) | **PATCH** /sessions/{sessionId}/peers/{nodeId}/deployments/{deploymentId} | Sends multiple commands for peer
[**UpdateSession**](SessionApi.md#updatesession) | **PATCH** /sessions/{sessionId} | Hub session update
[**UploadBlob**](SessionApi.md#uploadblob) | **PUT** /sessions/{sessionId}/blobs/{blobId} | Uploads a binary content to the hub.


<a name="addsessionpeers"></a>
# **AddSessionPeers**
> List<string> AddSessionPeers (long? sessionId, List<string> peerSet)

Manually adds peers to hub session

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class AddSessionPeersExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var peerSet = new List<string>(); // List<string> | 

            try
            {
                // Manually adds peers to hub session
                List&lt;string&gt; result = apiInstance.AddSessionPeers(sessionId, peerSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.AddSessionPeers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **peerSet** | [**List&lt;string&gt;**](List.md)|  | 

### Return type

**List<string>**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createblob"></a>
# **CreateBlob**
> Object CreateBlob (long? sessionId, System.IO.Stream body = null)

Creates new lob

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class CreateBlobExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Creates new lob
                Object result = apiInstance.CreateBlob(sessionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.CreateBlob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

**Object**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdeployment"></a>
# **CreateDeployment**
> string CreateDeployment (long? sessionId, string nodeId, DeploymentInfo deploymentSpec)

Creates new deployment

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class CreateDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var deploymentSpec = new DeploymentInfo(); // DeploymentInfo | 

            try
            {
                // Creates new deployment
                string result = apiInstance.CreateDeployment(sessionId, nodeId, deploymentSpec);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.CreateDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **nodeId** | **string**| GU Network node identifier | 
 **deploymentSpec** | [**DeploymentInfo**](DeploymentInfo.md)|  | 

### Return type

**string**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsession"></a>
# **CreateSession**
> long? CreateSession (HubSession body)

Creates new hub session.

Allowed fileds:  * name        - human readable session name * expires     - session expiration timestamp * allocation  - resource allocation mode.

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var body = new HubSession(); // HubSession | 

            try
            {
                // Creates new hub session.
                long? result = apiInstance.CreateSession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.CreateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HubSession**](HubSession.md)|  | 

### Return type

**long?**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblob"></a>
# **DeleteBlob**
> void DeleteBlob (long? sessionId, long? blobId)



### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class DeleteBlobExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var blobId = 789;  // long? | Blob identifier

            try
            {
                apiInstance.DeleteBlob(sessionId, blobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteBlob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **blobId** | **long?**| Blob identifier | 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedeployment"></a>
# **DeleteDeployment**
> void DeleteDeployment (long? sessionId, string nodeId, string deploymentId)



### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class DeleteDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var deploymentId = deploymentId_example;  // string | 

            try
            {
                apiInstance.DeleteDeployment(sessionId, nodeId, deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **nodeId** | **string**| GU Network node identifier | 
 **deploymentId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession (long? sessionId)



### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id

            try
            {
                apiInstance.DeleteSession(sessionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadblob"></a>
# **DownloadBlob**
> System.IO.Stream DownloadBlob (long? sessionId, long? blobId)

Downloads binary content from the hub

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class DownloadBlobExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var blobId = 789;  // long? | Blob identifier

            try
            {
                // Downloads binary content from the hub
                System.IO.Stream result = apiInstance.DownloadBlob(sessionId, blobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DownloadBlob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **blobId** | **long?**| Blob identifier | 

### Return type

**System.IO.Stream**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfig"></a>
# **GetConfig**
> Dictionary<string, Object> GetConfig (long? sessionId)

Gets configuration from stash

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class GetConfigExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id

            try
            {
                // Gets configuration from stash
                Dictionary&lt;string, Object&gt; result = apiInstance.GetConfig(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 

### Return type

**Dictionary<string, Object>**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethubinfo"></a>
# **GetHubInfo**
> HubInfo GetHubInfo ()



### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class GetHubInfoExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();

            try
            {
                HubInfo result = apiInstance.GetHubInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetHubInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HubInfo**](HubInfo.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsession"></a>
# **GetSession**
> HubSession GetSession (long? sessionId)

Gets hub session info

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class GetSessionExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id

            try
            {
                // Gets hub session info
                HubSession result = apiInstance.GetSession(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.GetSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 

### Return type

[**HubSession**](HubSession.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listblobs"></a>
# **ListBlobs**
> List<BlobInfo> ListBlobs (long? sessionId)

Lists currently allocated lobs

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class ListBlobsExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id

            try
            {
                // Lists currently allocated lobs
                List&lt;BlobInfo&gt; result = apiInstance.ListBlobs(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.ListBlobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 

### Return type

[**List<BlobInfo>**](BlobInfo.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsessionpeers"></a>
# **ListSessionPeers**
> List<PeerInfo> ListSessionPeers (long? sessionId)

List session peers

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class ListSessionPeersExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id

            try
            {
                // List session peers
                List&lt;PeerInfo&gt; result = apiInstance.ListSessionPeers(sessionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.ListSessionPeers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 

### Return type

[**List<PeerInfo>**](PeerInfo.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsessions"></a>
# **ListSessions**
> List<HubSession> ListSessions (int? limit = null, int? offset = null)

Lists current hub sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class ListSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var limit = 56;  // int? |  (optional)  (default to 50)
            var offset = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Lists current hub sessions.
                List&lt;HubSession&gt; result = apiInstance.ListSessions(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.ListSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**|  | [optional] [default to 50]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

[**List<HubSession>**](HubSession.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setconfig"></a>
# **SetConfig**
> long? SetConfig (long? sessionId, Dictionary<string, Object> config)

Sets configuration stash

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class SetConfigExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var config = new Dictionary<string, Object>(); // Dictionary<string, Object> | New config stash value

            try
            {
                // Sets configuration stash
                long? result = apiInstance.SetConfig(sessionId, config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SetConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **config** | [**Dictionary&lt;string, Object&gt;**](Object.md)| New config stash value | 

### Return type

**long?**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeployment"></a>
# **UpdateDeployment**
> void UpdateDeployment (long? sessionId, string nodeId, string deploymentId, List<Command> commands)

Sends multiple commands for peer

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class UpdateDeploymentExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var deploymentId = deploymentId_example;  // string | 
            var commands = new List<Command>(); // List<Command> | 

            try
            {
                // Sends multiple commands for peer
                apiInstance.UpdateDeployment(sessionId, nodeId, deploymentId, commands);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.UpdateDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **nodeId** | **string**| GU Network node identifier | 
 **deploymentId** | **string**|  | 
 **commands** | [**List&lt;Command&gt;**](List.md)|  | 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesession"></a>
# **UpdateSession**
> void UpdateSession (long? sessionId, HubSessionCommand changes = null)

Hub session update

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class UpdateSessionExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var changes = new HubSessionCommand(); // HubSessionCommand |  (optional) 

            try
            {
                // Hub session update
                apiInstance.UpdateSession(sessionId, changes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.UpdateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **changes** | [**HubSessionCommand**](HubSessionCommand.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadblob"></a>
# **UploadBlob**
> void UploadBlob (long? sessionId, long? blobId, System.IO.Stream body = null)

Uploads a binary content to the hub.

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class UploadBlobExample
    {
        public void main()
        {
            // Configure API key authorization: serviceToken
            Configuration.Default.AddApiKey("X-GU-APIKEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APIKEY", "Bearer");
            // Configure API key authorization: systemName
            Configuration.Default.AddApiKey("X-GU-APPNAME", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-GU-APPNAME", "Bearer");

            var apiInstance = new SessionApi();
            var sessionId = 789;  // long? | HUB session id
            var blobId = 789;  // long? | Blob identifier
            var body = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Uploads a binary content to the hub.
                apiInstance.UploadBlob(sessionId, blobId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.UploadBlob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sessionId** | **long?**| HUB session id | 
 **blobId** | **long?**| Blob identifier | 
 **body** | **System.IO.Stream**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

