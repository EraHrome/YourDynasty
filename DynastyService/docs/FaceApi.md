# IO.Swagger.Api.FaceApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2FaceCroppedGet**](FaceApi.md#v2facecroppedget) | **GET** /v2/face/cropped | gets a single cropped face information including cropped face image.
[**V2FaceGet**](FaceApi.md#v2faceget) | **GET** /v2/face | gets a single face information.


<a name="v2facecroppedget"></a>
# **V2FaceCroppedGet**
> CroppedFace V2FaceCroppedGet (Guid? apiKey, Guid? faceUuid)

gets a single cropped face information including cropped face image.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2FaceCroppedGetExample
    {
        public void main()
        {
            var apiInstance = new FaceApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var faceUuid = new Guid?(); // Guid? | the requested media identifier.

            try
            {
                // gets a single cropped face information including cropped face image.
                CroppedFace result = apiInstance.V2FaceCroppedGet(apiKey, faceUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.V2FaceCroppedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **faceUuid** | [**Guid?**](Guid?.md)| the requested media identifier. | 

### Return type

[**CroppedFace**](CroppedFace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2faceget"></a>
# **V2FaceGet**
> Face V2FaceGet (Guid? apiKey, Guid? faceUuid)

gets a single face information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2FaceGetExample
    {
        public void main()
        {
            var apiInstance = new FaceApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var faceUuid = new Guid?(); // Guid? | the requested media identifier.

            try
            {
                // gets a single face information.
                Face result = apiInstance.V2FaceGet(apiKey, faceUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FaceApi.V2FaceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **faceUuid** | [**Guid?**](Guid?.md)| the requested media identifier. | 

### Return type

[**Face**](Face.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

