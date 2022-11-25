# IO.Swagger.Api.TransformApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2TransformGet**](TransformApi.md#v2transformget) | **GET** /v2/transform | gets a faces transform result.
[**V2TransformPost**](TransformApi.md#v2transformpost) | **POST** /v2/transform | initiate transform for one or more faces


<a name="v2transformget"></a>
# **V2TransformGet**
> void V2TransformGet (Guid? apiKey, Guid? transformUuid)

gets a faces transform result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2TransformGetExample
    {
        public void main()
        {
            var apiInstance = new TransformApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var transformUuid = new Guid?(); // Guid? | the requested transform identifier.

            try
            {
                // gets a faces transform result.
                apiInstance.V2TransformGet(apiKey, transformUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformApi.V2TransformGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **transformUuid** | [**Guid?**](Guid?.md)| the requested transform identifier. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2transformpost"></a>
# **V2TransformPost**
> Transform V2TransformPost (TransformRequest body = null)

initiate transform for one or more faces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2TransformPostExample
    {
        public void main()
        {
            var apiInstance = new TransformApi();
            var body = new TransformRequest(); // TransformRequest | request json body with parameters. (optional) 

            try
            {
                // initiate transform for one or more faces
                Transform result = apiInstance.V2TransformPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformApi.V2TransformPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransformRequest**](TransformRequest.md)| request json body with parameters. | [optional] 

### Return type

[**Transform**](Transform.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

