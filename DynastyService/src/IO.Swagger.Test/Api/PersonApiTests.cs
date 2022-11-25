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
    ///  Class for testing PersonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PersonApiTests
    {
        private PersonApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PersonApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PersonApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PersonApi
            //Assert.IsInstanceOfType(typeof(PersonApi), instance, "instance is a PersonApi");
        }

        
        /// <summary>
        /// Test V2PersonGet
        /// </summary>
        [Test]
        public void V2PersonGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? apiKey = null;
            //Guid? apiSecret = null;
            //List<string> personId = null;
            //var response = instance.V2PersonGet(apiKey, apiSecret, personId);
            //Assert.IsInstanceOf<List<Person>> (response, "response is List<Person>");
        }
        
        /// <summary>
        /// Test V2PersonPost
        /// </summary>
        [Test]
        public void V2PersonPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPerson body = null;
            //instance.V2PersonPost(body);
            
        }
        
    }

}