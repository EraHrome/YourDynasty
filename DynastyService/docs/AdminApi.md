# IO.Swagger.Api.AdminApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2AdminUsageGet**](AdminApi.md#v2adminusageget) | **GET** /v2/admin/usage | get API usage information. (Administrative endpoint - API secret required)


<a name="v2adminusageget"></a>
# **V2AdminUsageGet**
> Usage V2AdminUsageGet (Guid? apiKey, Guid? apiSecret)

get API usage information. (Administrative endpoint - API secret required)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2AdminUsageGetExample
    {
        public void main()
        {
            var apiInstance = new AdminApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var apiSecret = new Guid?(); // Guid? | your API secret. It is not recommended to expose your application secret at client side.

            try
            {
                // get API usage information. (Administrative endpoint - API secret required)
                Usage result = apiInstance.V2AdminUsageGet(apiKey, apiSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.V2AdminUsageGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **apiSecret** | [**Guid?**](Guid?.md)| your API secret. It is not recommended to expose your application secret at client side. | 

### Return type

[**Usage**](Usage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

