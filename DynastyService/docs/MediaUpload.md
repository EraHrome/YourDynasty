# IO.Swagger.Model.MediaUpload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **Guid?** | your API key or d45fd466-51e2-4701-8da8-04351c872236 | 
**FileUri** | **string** | publicly accessible media file uri. | [optional] 
**FileBase64** | **string** | base64 encoded media file content. file_uri parameter will be ignored if file_base64 parameter is specified and not empty. | [optional] 
**DetectionFlags** | **string** | (optional) comma separated list of detection flags: bestface - return only face with highest detection score, centerface - same as bestface but gives preference to face closest to image center, basicpoints - 22 basic points detection, propoints - 101 pro points detection, classifiers - face classification and attributes, extended - extended color and geometric measurements, content - image content detection.  for example: \&quot;basicpoints,propoints,classifiers,content\&quot; | [optional] 
**DetectionMinScore** | **double?** | (optional) filter faces with detection score lower than min_score. | [optional] 
**DetectionNewFaces** | [**List&lt;NewFace&gt;**](NewFace.md) | (optional) override automatic faces detection and manually specify faces locations, face points and person ids to assign.  provide an array of new faces | [optional] 
**SetPersonId** | **string** | (optional) set person id in format name@namespace to each detected face. recommended to use with detection_flags bestface, centerface and/or min_score minimum detection score parameter. | [optional] 
**RecognizeTargets** | **List&lt;string&gt;** | (optional) for each detected face run recognize against specified targets (face ids, person ids or namespaces). | [optional] 
**RecognizeParameters** | **string** | (optional) comma separated list of recognition parameters, currently supported min_match_score (minimum recognition score), min_score (minimum detection score), gender and race filter.  for example: \&quot;min_match_score:0.4,min_score:0.2,gender:male,race:white\&quot; | [optional] 
**OriginalFilename** | **string** | (optional) original media filename, path, uri or your application specific id that you want to be stored in media metadata for reference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

