/* 
 * Betaface API 2.0
 *
 * Betaface face recognition API.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFaceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// gets a single cropped face information including cropped face image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>CroppedFace</returns>
        CroppedFace V2FaceCroppedGet (Guid? apiKey, Guid? faceUuid);

        /// <summary>
        /// gets a single cropped face information including cropped face image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>ApiResponse of CroppedFace</returns>
        ApiResponse<CroppedFace> V2FaceCroppedGetWithHttpInfo (Guid? apiKey, Guid? faceUuid);
        /// <summary>
        /// gets a single face information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Face</returns>
        Face V2FaceGet (Guid? apiKey, Guid? faceUuid);

        /// <summary>
        /// gets a single face information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>ApiResponse of Face</returns>
        ApiResponse<Face> V2FaceGetWithHttpInfo (Guid? apiKey, Guid? faceUuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// gets a single cropped face information including cropped face image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of CroppedFace</returns>
        System.Threading.Tasks.Task<CroppedFace> V2FaceCroppedGetAsync (Guid? apiKey, Guid? faceUuid);

        /// <summary>
        /// gets a single cropped face information including cropped face image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of ApiResponse (CroppedFace)</returns>
        System.Threading.Tasks.Task<ApiResponse<CroppedFace>> V2FaceCroppedGetAsyncWithHttpInfo (Guid? apiKey, Guid? faceUuid);
        /// <summary>
        /// gets a single face information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of Face</returns>
        System.Threading.Tasks.Task<Face> V2FaceGetAsync (Guid? apiKey, Guid? faceUuid);

        /// <summary>
        /// gets a single face information.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of ApiResponse (Face)</returns>
        System.Threading.Tasks.Task<ApiResponse<Face>> V2FaceGetAsyncWithHttpInfo (Guid? apiKey, Guid? faceUuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FaceApi : IFaceApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FaceApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FaceApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// gets a single cropped face information including cropped face image. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>CroppedFace</returns>
        public CroppedFace V2FaceCroppedGet (Guid? apiKey, Guid? faceUuid)
        {
             ApiResponse<CroppedFace> localVarResponse = V2FaceCroppedGetWithHttpInfo(apiKey, faceUuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// gets a single cropped face information including cropped face image. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>ApiResponse of CroppedFace</returns>
        public ApiResponse< CroppedFace > V2FaceCroppedGetWithHttpInfo (Guid? apiKey, Guid? faceUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling FaceApi->V2FaceCroppedGet");
            // verify the required parameter 'faceUuid' is set
            if (faceUuid == null)
                throw new ApiException(400, "Missing required parameter 'faceUuid' when calling FaceApi->V2FaceCroppedGet");

            var localVarPath = "/v2/face/cropped";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", apiKey)); // query parameter
            if (faceUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "face_uuid", faceUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2FaceCroppedGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CroppedFace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CroppedFace) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CroppedFace)));
        }

        /// <summary>
        /// gets a single cropped face information including cropped face image. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of CroppedFace</returns>
        public async System.Threading.Tasks.Task<CroppedFace> V2FaceCroppedGetAsync (Guid? apiKey, Guid? faceUuid)
        {
             ApiResponse<CroppedFace> localVarResponse = await V2FaceCroppedGetAsyncWithHttpInfo(apiKey, faceUuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// gets a single cropped face information including cropped face image. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of ApiResponse (CroppedFace)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CroppedFace>> V2FaceCroppedGetAsyncWithHttpInfo (Guid? apiKey, Guid? faceUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling FaceApi->V2FaceCroppedGet");
            // verify the required parameter 'faceUuid' is set
            if (faceUuid == null)
                throw new ApiException(400, "Missing required parameter 'faceUuid' when calling FaceApi->V2FaceCroppedGet");

            var localVarPath = "/v2/face/cropped";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", apiKey)); // query parameter
            if (faceUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "face_uuid", faceUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2FaceCroppedGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CroppedFace>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CroppedFace) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CroppedFace)));
        }

        /// <summary>
        /// gets a single face information. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Face</returns>
        public Face V2FaceGet (Guid? apiKey, Guid? faceUuid)
        {
             ApiResponse<Face> localVarResponse = V2FaceGetWithHttpInfo(apiKey, faceUuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// gets a single face information. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>ApiResponse of Face</returns>
        public ApiResponse< Face > V2FaceGetWithHttpInfo (Guid? apiKey, Guid? faceUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling FaceApi->V2FaceGet");
            // verify the required parameter 'faceUuid' is set
            if (faceUuid == null)
                throw new ApiException(400, "Missing required parameter 'faceUuid' when calling FaceApi->V2FaceGet");

            var localVarPath = "/v2/face";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", apiKey)); // query parameter
            if (faceUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "face_uuid", faceUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2FaceGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Face>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Face) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Face)));
        }

        /// <summary>
        /// gets a single face information. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of Face</returns>
        public async System.Threading.Tasks.Task<Face> V2FaceGetAsync (Guid? apiKey, Guid? faceUuid)
        {
             ApiResponse<Face> localVarResponse = await V2FaceGetAsyncWithHttpInfo(apiKey, faceUuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// gets a single face information. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="faceUuid">the requested media identifier.</param>
        /// <returns>Task of ApiResponse (Face)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Face>> V2FaceGetAsyncWithHttpInfo (Guid? apiKey, Guid? faceUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling FaceApi->V2FaceGet");
            // verify the required parameter 'faceUuid' is set
            if (faceUuid == null)
                throw new ApiException(400, "Missing required parameter 'faceUuid' when calling FaceApi->V2FaceGet");

            var localVarPath = "/v2/face";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", apiKey)); // query parameter
            if (faceUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "face_uuid", faceUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2FaceGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Face>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Face) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Face)));
        }

    }
}