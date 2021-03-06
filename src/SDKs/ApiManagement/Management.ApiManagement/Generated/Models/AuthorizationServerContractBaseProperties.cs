// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// External OAuth authorization server Update settings contract.
    /// </summary>
    public partial class AuthorizationServerContractBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AuthorizationServerContractBaseProperties class.
        /// </summary>
        public AuthorizationServerContractBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AuthorizationServerContractBaseProperties class.
        /// </summary>
        /// <param name="description">Description of the authorization server.
        /// Can contain HTML formatting tags.</param>
        /// <param name="authorizationMethods">HTTP verbs supported by the
        /// authorization endpoint. GET must be always present. POST is
        /// optional.</param>
        /// <param name="clientAuthenticationMethod">Method of authentication
        /// supported by the token endpoint of this authorization server.
        /// Possible values are Basic and/or Body. When Body is specified,
        /// client credentials and other parameters are passed within the
        /// request body in the application/x-www-form-urlencoded
        /// format.</param>
        /// <param name="tokenBodyParameters">Additional parameters required by
        /// the token endpoint of this authorization server represented as an
        /// array of JSON objects with name and value string properties, i.e.
        /// {"name" : "name value", "value": "a value"}.</param>
        /// <param name="tokenEndpoint">OAuth token endpoint. Contains absolute
        /// URI to entity being referenced.</param>
        /// <param name="supportState">If true, authorization server will
        /// include state parameter from the authorization request to its
        /// response. Client may use state parameter to raise protocol
        /// security.</param>
        /// <param name="defaultScope">Access token scope that is going to be
        /// requested by default. Can be overridden at the API level. Should be
        /// provided in the form of a string containing space-delimited
        /// values.</param>
        /// <param name="bearerTokenSendingMethods">Specifies the mechanism by
        /// which access token is passed to the API. </param>
        /// <param name="clientSecret">Client or app secret registered with
        /// this authorization server.</param>
        /// <param name="resourceOwnerUsername">Can be optionally specified
        /// when resource owner password grant type is supported by this
        /// authorization server. Default resource owner username.</param>
        /// <param name="resourceOwnerPassword">Can be optionally specified
        /// when resource owner password grant type is supported by this
        /// authorization server. Default resource owner password.</param>
        public AuthorizationServerContractBaseProperties(string description = default(string), IList<AuthorizationMethod?> authorizationMethods = default(IList<AuthorizationMethod?>), IList<string> clientAuthenticationMethod = default(IList<string>), IList<TokenBodyParameterContract> tokenBodyParameters = default(IList<TokenBodyParameterContract>), string tokenEndpoint = default(string), bool? supportState = default(bool?), string defaultScope = default(string), IList<string> bearerTokenSendingMethods = default(IList<string>), string clientSecret = default(string), string resourceOwnerUsername = default(string), string resourceOwnerPassword = default(string))
        {
            Description = description;
            AuthorizationMethods = authorizationMethods;
            ClientAuthenticationMethod = clientAuthenticationMethod;
            TokenBodyParameters = tokenBodyParameters;
            TokenEndpoint = tokenEndpoint;
            SupportState = supportState;
            DefaultScope = defaultScope;
            BearerTokenSendingMethods = bearerTokenSendingMethods;
            ClientSecret = clientSecret;
            ResourceOwnerUsername = resourceOwnerUsername;
            ResourceOwnerPassword = resourceOwnerPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the authorization server. Can contain
        /// HTML formatting tags.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets HTTP verbs supported by the authorization endpoint.
        /// GET must be always present. POST is optional.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationMethods")]
        public IList<AuthorizationMethod?> AuthorizationMethods { get; set; }

        /// <summary>
        /// Gets or sets method of authentication supported by the token
        /// endpoint of this authorization server. Possible values are Basic
        /// and/or Body. When Body is specified, client credentials and other
        /// parameters are passed within the request body in the
        /// application/x-www-form-urlencoded format.
        /// </summary>
        [JsonProperty(PropertyName = "clientAuthenticationMethod")]
        public IList<string> ClientAuthenticationMethod { get; set; }

        /// <summary>
        /// Gets or sets additional parameters required by the token endpoint
        /// of this authorization server represented as an array of JSON
        /// objects with name and value string properties, i.e. {"name" : "name
        /// value", "value": "a value"}.
        /// </summary>
        [JsonProperty(PropertyName = "tokenBodyParameters")]
        public IList<TokenBodyParameterContract> TokenBodyParameters { get; set; }

        /// <summary>
        /// Gets or sets oAuth token endpoint. Contains absolute URI to entity
        /// being referenced.
        /// </summary>
        [JsonProperty(PropertyName = "tokenEndpoint")]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Gets or sets if true, authorization server will include state
        /// parameter from the authorization request to its response. Client
        /// may use state parameter to raise protocol security.
        /// </summary>
        [JsonProperty(PropertyName = "supportState")]
        public bool? SupportState { get; set; }

        /// <summary>
        /// Gets or sets access token scope that is going to be requested by
        /// default. Can be overridden at the API level. Should be provided in
        /// the form of a string containing space-delimited values.
        /// </summary>
        [JsonProperty(PropertyName = "defaultScope")]
        public string DefaultScope { get; set; }

        /// <summary>
        /// Gets or sets specifies the mechanism by which access token is
        /// passed to the API.
        /// </summary>
        [JsonProperty(PropertyName = "bearerTokenSendingMethods")]
        public IList<string> BearerTokenSendingMethods { get; set; }

        /// <summary>
        /// Gets or sets client or app secret registered with this
        /// authorization server.
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets can be optionally specified when resource owner
        /// password grant type is supported by this authorization server.
        /// Default resource owner username.
        /// </summary>
        [JsonProperty(PropertyName = "resourceOwnerUsername")]
        public string ResourceOwnerUsername { get; set; }

        /// <summary>
        /// Gets or sets can be optionally specified when resource owner
        /// password grant type is supported by this authorization server.
        /// Default resource owner password.
        /// </summary>
        [JsonProperty(PropertyName = "resourceOwnerPassword")]
        public string ResourceOwnerPassword { get; set; }

    }
}
