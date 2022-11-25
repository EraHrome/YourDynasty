# IO.Swagger.Model.NewFace
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**X** | **double?** | x coordinate of the face bounding box center in pixels. | [optional] 
**Y** | **double?** | y coordinate of the face bounding box center in pixels. | [optional] 
**Width** | **double?** | width of the face bounding box center in pixels. | [optional] 
**Height** | **double?** | height of the face bounding box center in pixels. | [optional] 
**Angle** | **double?** | in-plane rotation (roll) of the face bounding box center in degrees. | [optional] 
**Points** | [**List&lt;Point&gt;**](Point.md) | face points. you have to specify minimum 3 points coordinates - type 512 (left eye), type 768 (right eye), type 2816 (mouth). point names are not required. | 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) | (optional) face tags or labels to set manually. | [optional] 
**SetPersonId** | **string** | (optional) manually assign person id in format name@namespace. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

