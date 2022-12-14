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
    public interface IRecognizeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// gets a faces recognition result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns></returns>
        void V2RecognizeGet (Guid? apiKey, Guid? recognizeUuid);

        /// <summary>
        /// gets a faces recognition result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V2RecognizeGetWithHttpInfo (Guid? apiKey, Guid? recognizeUuid);
        /// <summary>
        /// initiate recognition for one or more faces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Recognize</returns>
        Recognize V2RecognizePost (RecognizeRequest body = null);

        /// <summary>
        /// initiate recognition for one or more faces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>ApiResponse of Recognize</returns>
        ApiResponse<Recognize> V2RecognizePostWithHttpInfo (RecognizeRequest body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// gets a faces recognition result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V2RecognizeGetAsync (Guid? apiKey, Guid? recognizeUuid);

        /// <summary>
        /// gets a faces recognition result.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V2RecognizeGetAsyncWithHttpInfo (Guid? apiKey, Guid? recognizeUuid);
        /// <summary>
        /// initiate recognition for one or more faces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Task of Recognize</returns>
        System.Threading.Tasks.Task<Recognize> V2RecognizePostAsync (RecognizeRequest body = null);

        /// <summary>
        /// initiate recognition for one or more faces
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Task of ApiResponse (Recognize)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recognize>> V2RecognizePostAsyncWithHttpInfo (RecognizeRequest body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecognizeApi : IRecognizeApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecognizeApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognizeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecognizeApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// gets a faces recognition result. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns></returns>
        public void V2RecognizeGet (Guid? apiKey, Guid? recognizeUuid)
        {
             V2RecognizeGetWithHttpInfo(apiKey, recognizeUuid);
        }

        /// <summary>
        /// gets a faces recognition result. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V2RecognizeGetWithHttpInfo (Guid? apiKey, Guid? recognizeUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling RecognizeApi->V2RecognizeGet");
            // verify the required parameter 'recognizeUuid' is set
            if (recognizeUuid == null)
                throw new ApiException(400, "Missing required parameter 'recognizeUuid' when calling RecognizeApi->V2RecognizeGet");

            var localVarPath = "/v2/recognize";
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
            if (recognizeUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recognize_uuid", recognizeUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2RecognizeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// gets a faces recognition result. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V2RecognizeGetAsync (Guid? apiKey, Guid? recognizeUuid)
        {
             await V2RecognizeGetAsyncWithHttpInfo(apiKey, recognizeUuid);

        }

        /// <summary>
        /// gets a faces recognition result. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">your API key or d45fd466-51e2-4701-8da8-04351c872236</param>
        /// <param name="recognizeUuid">the requested recognize identifier.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V2RecognizeGetAsyncWithHttpInfo (Guid? apiKey, Guid? recognizeUuid)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling RecognizeApi->V2RecognizeGet");
            // verify the required parameter 'recognizeUuid' is set
            if (recognizeUuid == null)
                throw new ApiException(400, "Missing required parameter 'recognizeUuid' when calling RecognizeApi->V2RecognizeGet");

            var localVarPath = "/v2/recognize";
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
            if (recognizeUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "recognize_uuid", recognizeUuid)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2RecognizeGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// initiate recognition for one or more faces 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Recognize</returns>
        public Recognize V2RecognizePost (RecognizeRequest body = null)
        {
             ApiResponse<Recognize> localVarResponse = V2RecognizePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// initiate recognition for one or more faces 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>ApiResponse of Recognize</returns>
        public ApiResponse< Recognize > V2RecognizePostWithHttpInfo (RecognizeRequest body = null)
        {

            var localVarPath = "/v2/recognize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2RecognizePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Recognize>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recognize) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recognize)));
        }

        /// <summary>
        /// initiate recognition for one or more faces 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Task of Recognize</returns>
        public async System.Threading.Tasks.Task<Recognize> V2RecognizePostAsync (RecognizeRequest body = null)
        {
             ApiResponse<Recognize> localVarResponse = await V2RecognizePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// initiate recognition for one or more faces 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">request json body with parameters. (optional)</param>
        /// <returns>Task of ApiResponse (Recognize)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recognize>> V2RecognizePostAsyncWithHttpInfo (RecognizeRequest body = null)
        {

            var localVarPath = "/v2/recognize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V2RecognizePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Recognize>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recognize) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recognize)));
        }

    }
}
