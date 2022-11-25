# IO.Swagger.Api.MediaApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2MediaFilePost**](MediaApi.md#v2mediafilepost) | **POST** /v2/media/file | upload media file using multipart/form-data
[**V2MediaGet**](MediaApi.md#v2mediaget) | **GET** /v2/media | gets a media information.
[**V2MediaHashGet**](MediaApi.md#v2mediahashget) | **GET** /v2/media/hash | gets a media information using SHA256 hash of media file.
[**V2MediaPost**](MediaApi.md#v2mediapost) | **POST** /v2/media | upload media file using file uri or file content as base64 encoded string


<a name="v2mediafilepost"></a>
# **V2MediaFilePost**
> MediaUploadResponse V2MediaFilePost (Guid? apiKey, System.IO.Stream _file, string detectionFlags = null, double? detectionMinScore = null, string detectionNewFaces = null, string setPersonId = null, string recognizeTargets = null, string recognizeParameters = null, string originalFilename = null)

upload media file using multipart/form-data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MediaFilePostExample
    {
        public void main()
        {
            var apiInstance = new MediaApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var _file = new System.IO.Stream(); // System.IO.Stream | a media file to upload
            var detectionFlags = detectionFlags_example;  // string | (optional) comma separated list of detection flags: bestface - return only face with highest detection score, centerface - same as bestface but gives preference to face closest to image center, basicpoints - 22 basic points detection, propoints - 101 pro points detection, classifiers - face classification and attributes, extended - extended color and geometric measurements, content - image content detection.  for example: \"basicpoints,propoints,classifiers,content\" (optional) 
            var detectionMinScore = 1.2;  // double? | (optional) filter faces with detection score lower than min_score. (optional) 
            var detectionNewFaces = detectionNewFaces_example;  // string | (optional) override automatic faces detection and manually specify faces locations, face points and person ids to assign.  provide a list of new faces as a string of comma separated entries with following template: { \"x\": 0, \"y\": 0, \"width\": 0, \"height\": 0, \"angle\": 0, \"points\": [ { \"x\": 0, \"y\": 0, \"type\": 0 }, { \"x\": 0, \"y\": 0, \"type\": 0 }], \"tags\": [ { \"name\": \"\",  \"value\": \"\",  \"confidence\": 1.0 }, {\"name\": \"\", \"value\": \"\", \"confidence\": 1.0 } ], \"set_person_id\": \"\"} (optional) 
            var setPersonId = setPersonId_example;  // string | (optional) set person id in format name@namespace to each detected face. recommended to use with detection_flags bestface, centerface and/or min_score minimum detection score parameter. you can use special name random@namespace to assign random unique name to each face in specific namespace.  for example: \"John Doe@mynamespace\" (optional) 
            var recognizeTargets = recognizeTargets_example;  // string | (optional) for each detected face run recognize against specified targets (face ids, person ids or namespaces).  provide a list of targets as comma separated string, for example \"all@mynamespace,John Doe@othernamespace\" (optional) 
            var recognizeParameters = recognizeParameters_example;  // string | (optional) comma separated list of recognition parameters, currently supported min_match_score (minimum recognition score), min_score (minimum detection score), gender and race filter.  for example: \"min_match_score:0.4,min_score:0.2,gender:male,race:white\" (optional) 
            var originalFilename = originalFilename_example;  // string | (optional) original media filename, path, uri or your application specific id that you want to be stored in media metadata for reference. (optional) 

            try
            {
                // upload media file using multipart/form-data
                MediaUploadResponse result = apiInstance.V2MediaFilePost(apiKey, _file, detectionFlags, detectionMinScore, detectionNewFaces, setPersonId, recognizeTargets, recognizeParameters, originalFilename);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.V2MediaFilePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **_file** | **System.IO.Stream**| a media file to upload | 
 **detectionFlags** | **string**| (optional) comma separated list of detection flags: bestface - return only face with highest detection score, centerface - same as bestface but gives preference to face closest to image center, basicpoints - 22 basic points detection, propoints - 101 pro points detection, classifiers - face classification and attributes, extended - extended color and geometric measurements, content - image content detection.  for example: \&quot;basicpoints,propoints,classifiers,content\&quot; | [optional] 
 **detectionMinScore** | **double?**| (optional) filter faces with detection score lower than min_score. | [optional] 
 **detectionNewFaces** | **string**| (optional) override automatic faces detection and manually specify faces locations, face points and person ids to assign.  provide a list of new faces as a string of comma separated entries with following template: { \&quot;x\&quot;: 0, \&quot;y\&quot;: 0, \&quot;width\&quot;: 0, \&quot;height\&quot;: 0, \&quot;angle\&quot;: 0, \&quot;points\&quot;: [ { \&quot;x\&quot;: 0, \&quot;y\&quot;: 0, \&quot;type\&quot;: 0 }, { \&quot;x\&quot;: 0, \&quot;y\&quot;: 0, \&quot;type\&quot;: 0 }], \&quot;tags\&quot;: [ { \&quot;name\&quot;: \&quot;\&quot;,  \&quot;value\&quot;: \&quot;\&quot;,  \&quot;confidence\&quot;: 1.0 }, {\&quot;name\&quot;: \&quot;\&quot;, \&quot;value\&quot;: \&quot;\&quot;, \&quot;confidence\&quot;: 1.0 } ], \&quot;set_person_id\&quot;: \&quot;\&quot;} | [optional] 
 **setPersonId** | **string**| (optional) set person id in format name@namespace to each detected face. recommended to use with detection_flags bestface, centerface and/or min_score minimum detection score parameter. you can use special name random@namespace to assign random unique name to each face in specific namespace.  for example: \&quot;John Doe@mynamespace\&quot; | [optional] 
 **recognizeTargets** | **string**| (optional) for each detected face run recognize against specified targets (face ids, person ids or namespaces).  provide a list of targets as comma separated string, for example \&quot;all@mynamespace,John Doe@othernamespace\&quot; | [optional] 
 **recognizeParameters** | **string**| (optional) comma separated list of recognition parameters, currently supported min_match_score (minimum recognition score), min_score (minimum detection score), gender and race filter.  for example: \&quot;min_match_score:0.4,min_score:0.2,gender:male,race:white\&quot; | [optional] 
 **originalFilename** | **string**| (optional) original media filename, path, uri or your application specific id that you want to be stored in media metadata for reference. | [optional] 

### Return type

[**MediaUploadResponse**](MediaUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2mediaget"></a>
# **V2MediaGet**
> Media V2MediaGet (Guid? apiKey, Guid? mediaUuid)

gets a media information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MediaGetExample
    {
        public void main()
        {
            var apiInstance = new MediaApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var mediaUuid = new Guid?(); // Guid? | the requested media identifier.

            try
            {
                // gets a media information.
                Media result = apiInstance.V2MediaGet(apiKey, mediaUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.V2MediaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **mediaUuid** | [**Guid?**](Guid?.md)| the requested media identifier. | 

### Return type

[**Media**](Media.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2mediahashget"></a>
# **V2MediaHashGet**
> Media V2MediaHashGet (Guid? apiKey, string checksum)

gets a media information using SHA256 hash of media file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MediaHashGetExample
    {
        public void main()
        {
            var apiInstance = new MediaApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var checksum = checksum_example;  // string | SHA256 media file hash.

            try
            {
                // gets a media information using SHA256 hash of media file.
                Media result = apiInstance.V2MediaHashGet(apiKey, checksum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.V2MediaHashGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | [**Guid?**](Guid?.md)| your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
 **checksum** | **string**| SHA256 media file hash. | 

### Return type

[**Media**](Media.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2mediapost"></a>
# **V2MediaPost**
> MediaUploadResponse V2MediaPost (MediaUpload body = null)

upload media file using file uri or file content as base64 encoded string

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2MediaPostExample
    {
        public void main()
        {
            var apiInstance = new MediaApi();
            var body = new MediaUpload(); // MediaUpload | request json body with parameters. (optional) 

            try
            {
                // upload media file using file uri or file content as base64 encoded string
                MediaUploadResponse result = apiInstance.V2MediaPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaApi.V2MediaPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MediaUpload**](MediaUpload.md)| request json body with parameters. | [optional] 

### Return type

[**MediaUploadResponse**](MediaUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

