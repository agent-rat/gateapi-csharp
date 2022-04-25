/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Reflection;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;

namespace Io.Gate.GateApi.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "4.23.4";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                // try to deserialize into GateApiException
                try
                {
                    var exception = JsonConvert.DeserializeObject<GateApiException>(response.RawContent);
                    if (!string.IsNullOrWhiteSpace(exception.ErrorLabel))
                    {
                        return exception;
                    }
                }
                catch (Exception)
                {
                    // fallthrough
                }
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.RawContent),
                    response.RawContent);
            }
            // emit exception when non-http related error happened
            if (!string.IsNullOrEmpty(response.ErrorText))
            {
                return new ApiException(status,
                    string.Format("Error calling {0}: {1}", methodName, response.ErrorText),
                    response.ErrorText);
            }
            return null;
        };

        #endregion Static Members

        #region Private Members

        /// <summary>
        /// Defines the base path of the target API server.
        /// Example: http://localhost:3000/v1/
        /// </summary>
        private string _basePath;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration()
        {
            UserAgent = "OpenAPI-Generator/4.23.4/csharp";
            BasePath = "https://api.gateio.ws/api/v4";
            DefaultHeaders = new ConcurrentDictionary<string, string>();

            // Setting Timeout has side effects (forces ApiClient creation).
            Timeout = 100000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(
            IDictionary<string, string> defaultHeaders,
            string apiV4Key,
            string apiV4Secret,
            string basePath = "https://api.gateio.ws/api/v4") : this()
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", "basePath");

            BasePath = basePath;

            DefaultHeaders = new ConcurrentDictionary<string, string>();
            if (defaultHeaders != null)
            {
                foreach (var keyValuePair in defaultHeaders)
                {
                    DefaultHeaders.Add(keyValuePair);
                }
            }

            if (string.IsNullOrWhiteSpace(apiV4Key) && string.IsNullOrWhiteSpace(apiV4Secret))
            {
                ApiV4Key = apiV4Key;
                ApiV4Secret = apiV4Secret;
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath {
            get { return _basePath; }
            set {
                _basePath = value;
            }
        }

        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int Timeout { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        ///
        /// This helper property simplifies code generation.
        /// </summary>
        /// <value>The access token.</value>
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public virtual string TempFolderPath
        {
            get { return _tempFolderPath; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                {
                    _tempFolderPath = value;
                }
                else
                {
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
                }
            }
        }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the Gate APIv4 key
        /// </summary>
        /// <value>The API key.</value>
        public string ApiV4Key { get; set; }

        /// <summary>
        /// Gets or sets the Gate APIv4 secret
        /// </summary>
        /// <value>The API secret.</value>
        public string ApiV4Secret { get; set; }

        /// <summary>
        /// Gets or sets the WebProxy used to send HTTP request
        /// </summary>
        /// <value>The proxy used.</value>
        public IWebProxy Proxy { get; set;  }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            string report = "C# SDK (Io.Gate.GateApi) Debug Report:\n";
            report += "    OS: " + System.Runtime.InteropServices.RuntimeInformation.OSDescription + "\n";
            report += "    Version of the API: 4.23.4\n";
            report += "    SDK Package Version: 4.23.4\n";

            return report;
        }

        /// <summary>
        /// helper method to update Gate APIv4 key and secret
        /// </summary>
        /// <param name="key">APIv4 key</param>
        /// <param name="secret">APIv4 secret</param>
        public void SetGateApiV4KeyPair(string key, string secret)
        {
            ApiV4Key = key;
            ApiV4Secret = secret;
        }

        #endregion Methods

        #region Static Members
        /// <summary>
        /// Merge configurations.
        /// </summary>
        /// <param name="first">First configuration.</param>
        /// <param name="second">Second configuration.</param>
        /// <return>Merged configuration.</return>
        public static IReadableConfiguration MergeConfigurations(IReadableConfiguration first, IReadableConfiguration second)
        {
            if (second == null) return first ?? GlobalConfiguration.Instance;

            Dictionary<string, string> defaultHeaders = first.DefaultHeaders.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in second.DefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            var config = new Configuration
            {
                ApiV4Key = second.ApiV4Key ?? first.ApiV4Key,
                ApiV4Secret = second.ApiV4Secret ?? first.ApiV4Secret,
                DefaultHeaders = defaultHeaders,
                BasePath = second.BasePath ?? first.BasePath,
                Timeout = second.Timeout,
                UserAgent = second.UserAgent ?? first.UserAgent,
                Username = second.Username ?? first.Username,
                Password = second.Password ?? first.Password,
                AccessToken = second.AccessToken ?? first.AccessToken,
                TempFolderPath = second.TempFolderPath ?? first.TempFolderPath,
                DateTimeFormat = second.DateTimeFormat ?? first.DateTimeFormat,
                Proxy = second.Proxy ?? first.Proxy
            };
            return config;
        }
        #endregion Static Members
    }
}
