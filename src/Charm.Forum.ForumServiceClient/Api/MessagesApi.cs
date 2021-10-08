/*
 * Forum
 *
 * An api for supporting forum posts and comments.
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Charm.Forum.ForumServiceClient.Client;
using Charm.Forum.ForumServiceClient.Model;

namespace Charm.Forum.ForumServiceClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new message for the specified post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new message to a specified post.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>MessageRequest</returns>
        MessageRequest CreateMessage(int postid);

        /// <summary>
        /// Create a new message for the specified post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new message to a specified post.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>ApiResponse of MessageRequest</returns>
        ApiResponse<MessageRequest> CreateMessageWithHttpInfo(int postid);
        /// <summary>
        /// Get the collection of messages related to a particular post.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>List&lt;MessageModel&gt;</returns>
        List<MessageModel> GetMessages(int postid);

        /// <summary>
        /// Get the collection of messages related to a particular post.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>ApiResponse of List&lt;MessageModel&gt;</returns>
        ApiResponse<List<MessageModel>> GetMessagesWithHttpInfo(int postid);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new message for the specified post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new message to a specified post.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MessageRequest</returns>
        System.Threading.Tasks.Task<MessageRequest> CreateMessageAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new message for the specified post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new message to a specified post.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MessageRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageRequest>> CreateMessageWithHttpInfoAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the collection of messages related to a particular post.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MessageModel&gt;</returns>
        System.Threading.Tasks.Task<List<MessageModel>> GetMessagesAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the collection of messages related to a particular post.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;MessageModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MessageModel>>> GetMessagesWithHttpInfoAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi : IMessagesApiSync, IMessagesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagesApi : IMessagesApi
    {
        private Charm.Forum.ForumServiceClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagesApi(string basePath)
        {
            this.Configuration = Charm.Forum.ForumServiceClient.Client.Configuration.MergeConfigurations(
                Charm.Forum.ForumServiceClient.Client.GlobalConfiguration.Instance,
                new Charm.Forum.ForumServiceClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Charm.Forum.ForumServiceClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Charm.Forum.ForumServiceClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Charm.Forum.ForumServiceClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagesApi(Charm.Forum.ForumServiceClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Charm.Forum.ForumServiceClient.Client.Configuration.MergeConfigurations(
                Charm.Forum.ForumServiceClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Charm.Forum.ForumServiceClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Charm.Forum.ForumServiceClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Charm.Forum.ForumServiceClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MessagesApi(Charm.Forum.ForumServiceClient.Client.ISynchronousClient client, Charm.Forum.ForumServiceClient.Client.IAsynchronousClient asyncClient, Charm.Forum.ForumServiceClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Charm.Forum.ForumServiceClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Charm.Forum.ForumServiceClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Charm.Forum.ForumServiceClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Charm.Forum.ForumServiceClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Charm.Forum.ForumServiceClient.Client.ExceptionFactory ExceptionFactory
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
        /// Create a new message for the specified post. Method for adding a new message to a specified post.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>MessageRequest</returns>
        public MessageRequest CreateMessage(int postid)
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<MessageRequest> localVarResponse = CreateMessageWithHttpInfo(postid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new message for the specified post. Method for adding a new message to a specified post.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>ApiResponse of MessageRequest</returns>
        public Charm.Forum.ForumServiceClient.Client.ApiResponse<MessageRequest> CreateMessageWithHttpInfo(int postid)
        {
            Charm.Forum.ForumServiceClient.Client.RequestOptions localVarRequestOptions = new Charm.Forum.ForumServiceClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("postid", Charm.Forum.ForumServiceClient.Client.ClientUtils.ParameterToString(postid)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Post<MessageRequest>("/posts/{postid}/messages", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMessage", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new message for the specified post. Method for adding a new message to a specified post.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MessageRequest</returns>
        public async System.Threading.Tasks.Task<MessageRequest> CreateMessageAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<MessageRequest> localVarResponse = await CreateMessageWithHttpInfoAsync(postid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new message for the specified post. Method for adding a new message to a specified post.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MessageRequest)</returns>
        public async System.Threading.Tasks.Task<Charm.Forum.ForumServiceClient.Client.ApiResponse<MessageRequest>> CreateMessageWithHttpInfoAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Charm.Forum.ForumServiceClient.Client.RequestOptions localVarRequestOptions = new Charm.Forum.ForumServiceClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("postid", Charm.Forum.ForumServiceClient.Client.ClientUtils.ParameterToString(postid)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<MessageRequest>("/posts/{postid}/messages", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateMessage", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the collection of messages related to a particular post. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>List&lt;MessageModel&gt;</returns>
        public List<MessageModel> GetMessages(int postid)
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<List<MessageModel>> localVarResponse = GetMessagesWithHttpInfo(postid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the collection of messages related to a particular post. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <returns>ApiResponse of List&lt;MessageModel&gt;</returns>
        public Charm.Forum.ForumServiceClient.Client.ApiResponse<List<MessageModel>> GetMessagesWithHttpInfo(int postid)
        {
            Charm.Forum.ForumServiceClient.Client.RequestOptions localVarRequestOptions = new Charm.Forum.ForumServiceClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("postid", Charm.Forum.ForumServiceClient.Client.ClientUtils.ParameterToString(postid)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<MessageModel>>("/posts/{postid}/messages", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMessages", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the collection of messages related to a particular post. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;MessageModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<MessageModel>> GetMessagesAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<List<MessageModel>> localVarResponse = await GetMessagesWithHttpInfoAsync(postid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the collection of messages related to a particular post. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postid">Numeric ID of the post to attach the message to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;MessageModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Charm.Forum.ForumServiceClient.Client.ApiResponse<List<MessageModel>>> GetMessagesWithHttpInfoAsync(int postid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Charm.Forum.ForumServiceClient.Client.RequestOptions localVarRequestOptions = new Charm.Forum.ForumServiceClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Charm.Forum.ForumServiceClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("postid", Charm.Forum.ForumServiceClient.Client.ClientUtils.ParameterToString(postid)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<MessageModel>>("/posts/{postid}/messages", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMessages", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
