# IO.Swagger.Api.RecognizeApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2RecognizeGet**](RecognizeApi.md#v2recognizeget) | **GET** /v2/recognize | gets a faces recognition result.
[**V2RecognizePost**](RecognizeApi.md#v2recognizepost) | **POST** /v2/recognize | initiate recognition for one or more faces


<a name="v2recognizeget"></a>
# **V2RecognizeGet**
> void V2RecognizeGet (Guid? apiKey, Guid? recognizeUuid)

gets a faces recognition result.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2RecognizeGetExample
    {
        public void main()
        {
            var apiInstance = new RecognizeApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var recognizeUuid = new Guid?(); // Guid? | the requested recognize identifier.

            try
            {
                // gets a faces recognition result.
                apiInstance.V2RecognizeGet(apiKey, recognizeUuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.V2RecognizeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **recognizeUuid** | [**Guid?**](Guid?.md)| the requested recognize identifier. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2recognizepost"></a>
# **V2RecognizePost**
> Recognize V2RecognizePost (RecognizeRequest body = null)

initiate recognition for one or more faces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2RecognizePostExample
    {
        public void main()
        {
            var apiInstance = new RecognizeApi();
            var body = new RecognizeRequest(); // RecognizeRequest | request json body with parameters. (optional) 

            try
            {
                // initiate recognition for one or more faces
                Recognize result = apiInstance.V2RecognizePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecognizeApi.V2RecognizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecognizeRequest**](RecognizeRequest.md)| request json body with parameters. | [optional] 

### Return type

[**Recognize**](Recognize.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

