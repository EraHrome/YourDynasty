# IO.Swagger.Api.PersonApi

All URIs are relative to *https://www.betafaceapi.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V2PersonGet**](PersonApi.md#v2personget) | **GET** /v2/person | lists all persons and their faces identifiers sorted by namespace and person name alphabetically. (Administrative endpoint - API secret required)
[**V2PersonPost**](PersonApi.md#v2personpost) | **POST** /v2/person | sets or overwrites person id for each specified face.


<a name="v2personget"></a>
# **V2PersonGet**
> List<Person> V2PersonGet (Guid? apiKey, Guid? apiSecret, List<string> personId = null)

lists all persons and their faces identifiers sorted by namespace and person name alphabetically. (Administrative endpoint - API secret required)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2PersonGetExample
    {
        public void main()
        {
            var apiInstance = new PersonApi();
            var apiKey = new Guid?(); // Guid? | your API key or d45fd466-51e2-4701-8da8-04351c872236
            var apiSecret = new Guid?(); // Guid? | your API secret. It is not recommended to expose your application secret at client side.
            var personId = new List<string>(); // List<string> | (optional) query parameters array of specific person ids or all@namespace to list persons in that namespace (optional) 

            try
            {
                // lists all persons and their faces identifiers sorted by namespace and person name alphabetically. (Administrative endpoint - API secret required)
                List&lt;Person&gt; result = apiInstance.V2PersonGet(apiKey, apiSecret, personId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonApi.V2PersonGet: " + e.Message );
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
 **personId** | [**List&lt;string&gt;**](string.md)| (optional) query parameters array of specific person ids or all@namespace to list persons in that namespace | [optional] 

### Return type

[**List<Person>**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v2personpost"></a>
# **V2PersonPost**
> void V2PersonPost (SetPerson body = null)

sets or overwrites person id for each specified face.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2PersonPostExample
    {
        public void main()
        {
            var apiInstance = new PersonApi();
            var body = new SetPerson(); // SetPerson | request json body with parameters. (optional) 

            try
            {
                // sets or overwrites person id for each specified face.
                apiInstance.V2PersonPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonApi.V2PersonPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetPerson**](SetPerson.md)| request json body with parameters. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

