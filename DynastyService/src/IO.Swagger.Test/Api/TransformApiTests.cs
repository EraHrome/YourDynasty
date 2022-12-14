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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing TransformApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransformApiTests
    {
        private TransformApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransformApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransformApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransformApi
            //Assert.IsInstanceOfType(typeof(TransformApi), instance, "instance is a TransformApi");
        }

        
        /// <summary>
        /// Test V2TransformGet
        /// </summary>
        [Test]
        public void V2TransformGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? apiKey = null;
            //Guid? transformUuid = null;
            //instance.V2TransformGet(apiKey, transformUuid);
            
        }
        
        /// <summary>
        /// Test V2TransformPost
        /// </summary>
        [Test]
        public void V2TransformPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransformRequest body = null;
            //var response = instance.V2TransformPost(body);
            //Assert.IsInstanceOf<Transform> (response, "response is Transform");
        }
        
    }

}
