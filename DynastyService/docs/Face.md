# IO.Swagger.Model.Face
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FaceUuid** | **Guid?** | face unique identifier. | [optional] 
**MediaUuid** | **Guid?** | media unique identifier. | [optional] 
**X** | **double?** | x coordinate of the face bounding box center in pixels. | [optional] 
**Y** | **double?** | y coordinate of the face bounding box center in pixels. | [optional] 
**Width** | **double?** | width of the face bounding box center in pixels. | [optional] 
**Height** | **double?** | height of the face bounding box center in pixels. | [optional] 
**Angle** | **double?** | in-plane rotation (roll) of the face bounding box center in degrees. | [optional] 
**DetectionScore** | **double?** | confidence-like value of the face detection, low detection scores (lower than 0.5 for example) correspond to higher probability of false detection. | [optional] 
**Points** | [**List&lt;Point&gt;**](Point.md) | facial landmark points. | [optional] 
**UserPoints** | [**List&lt;Point&gt;**](Point.md) | user-defined facial landmark points. | [optional] 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) | list of detected or labelled face tags - classifiers, attributes, measurements. | [optional] 
**PersonId** | **string** | assigned person id and namespace in format name@namespace. | [optional] 
**AppearanceId** | **int?** | reserved for future video processing | [optional] 
**Start** | **string** | reserved for future video processing | [optional] 
**Duration** | **string** | reserved for future video processing | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

