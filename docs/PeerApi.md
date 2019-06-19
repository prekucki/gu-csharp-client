# gu_rest_api.Api.PeerApi

All URIs are relative to *http://127.0.0.1:61622*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDeployment**](PeerApi.md#createdeployment) | **POST** /peers/{nodeId}/deployments | 
[**DropDeployment**](PeerApi.md#dropdeployment) | **DELETE** /peers/{nodeId}/deployments/{deploymentId} | Removes deployment
[**GetHubInfo**](PeerApi.md#gethubinfo) | **GET** /info | 
[**GetPeerDetails**](PeerApi.md#getpeerdetails) | **GET** /peers/{nodeId} | Returns detailed peer info
[**ListDeployments**](PeerApi.md#listdeployments) | **GET** /peers/{nodeId}/deployments | 
[**ListPeers**](PeerApi.md#listpeers) | **GET** /peers | Returns a list hub peers.
[**UpdateDeployment**](PeerApi.md#updatedeployment) | **PATCH** /peers/{nodeId}/deployments/{deploymentId} | 


<a name="createdeployment"></a>
# **CreateDeployment**
> string CreateDeployment (string nodeId, DeploymentSpec spec)



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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **string**| GU Network node identifier | 
 **spec** | [**DeploymentSpec**](DeploymentSpec.md)|  | 

### Return type

**string**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dropdeployment"></a>
# **DropDeployment**
> void DropDeployment (string nodeId, string deploymentId)

Removes deployment

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class DropDeploymentExample
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

            var apiInstance = new PeerApi();
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var deploymentId = deploymentId_example;  // string | 

            try
            {
                // Removes deployment
                apiInstance.DropDeployment(nodeId, deploymentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.DropDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

            var apiInstance = new PeerApi();

            try
            {
                HubInfo result = apiInstance.GetHubInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.GetHubInfo: " + e.Message );
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

<a name="getpeerdetails"></a>
# **GetPeerDetails**
> PeerDetails GetPeerDetails (string nodeId)

Returns detailed peer info

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class GetPeerDetailsExample
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

            var apiInstance = new PeerApi();
            var nodeId = nodeId_example;  // string | GU Network node identifier

            try
            {
                // Returns detailed peer info
                PeerDetails result = apiInstance.GetPeerDetails(nodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.GetPeerDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **string**| GU Network node identifier | 

### Return type

[**PeerDetails**](PeerDetails.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdeployments"></a>
# **ListDeployments**
> List<DeploymentInfo> ListDeployments (string nodeId)



### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class ListDeploymentsExample
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

            var apiInstance = new PeerApi();
            var nodeId = nodeId_example;  // string | GU Network node identifier

            try
            {
                List&lt;DeploymentInfo&gt; result = apiInstance.ListDeployments(nodeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.ListDeployments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **string**| GU Network node identifier | 

### Return type

[**List<DeploymentInfo>**](DeploymentInfo.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpeers"></a>
# **ListPeers**
> List<PeerInfo> ListPeers (int? offset = null, int? limit = null)

Returns a list hub peers.

### Example
```csharp
using System;
using System.Diagnostics;
using gu_rest_api.Api;
using gu_rest_api.Client;
using gu_rest_api.Model;

namespace Example
{
    public class ListPeersExample
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

            var apiInstance = new PeerApi();
            var offset = 56;  // int? |  (optional)  (default to 0)
            var limit = 56;  // int? |  (optional)  (default to 50)

            try
            {
                // Returns a list hub peers.
                List&lt;PeerInfo&gt; result = apiInstance.ListPeers(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.ListPeers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**|  | [optional] [default to 0]
 **limit** | **int?**|  | [optional] [default to 50]

### Return type

[**List<PeerInfo>**](PeerInfo.md)

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedeployment"></a>
# **UpdateDeployment**
> List<string> UpdateDeployment (string nodeId, string deploymentId, List<Command> commands = null)



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

            var apiInstance = new PeerApi();
            var nodeId = nodeId_example;  // string | GU Network node identifier
            var deploymentId = deploymentId_example;  // string | 
            var commands = new List<Command>(); // List<Command> |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.UpdateDeployment(nodeId, deploymentId, commands);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PeerApi.UpdateDeployment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nodeId** | **string**| GU Network node identifier | 
 **deploymentId** | **string**|  | 
 **commands** | [**List&lt;Command&gt;**](List.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[serviceToken](../README.md#serviceToken), [systemName](../README.md#systemName)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

