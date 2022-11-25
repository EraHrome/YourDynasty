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
    ///  Class for testing FaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FaceApiTests
    {
        private FaceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FaceApi
            //Assert.IsInstanceOfType(typeof(FaceApi), instance, "instance is a FaceApi");
        }

        
        /// <summary>
        /// Test V2FaceCroppedGet
        /// </summary>
        [Test]
        public void V2FaceCroppedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? apiKey = null;
            //Guid? faceUuid = null;
            //var response = instance.V2FaceCroppedGet(apiKey, faceUuid);
            //Assert.IsInstanceOf<CroppedFace> (response, "response is CroppedFace");
        }
        
        /// <summary>
        /// Test V2FaceGet
        /// </summary>
        [Test]
        public void V2FaceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? apiKey = null;
            //Guid? faceUuid = null;
            //var response = instance.V2FaceGet(apiKey, faceUuid);
            //Assert.IsInstanceOf<Face> (response, "response is Face");
        }
        
    }

}
