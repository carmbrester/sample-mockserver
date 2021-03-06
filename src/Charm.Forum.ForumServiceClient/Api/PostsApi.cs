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
    public interface IPostsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new post resource to the collection.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PostModel</returns>
        PostModel CreatePost();

        /// <summary>
        /// Create a new post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new post resource to the collection.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PostModel</returns>
        ApiResponse<PostModel> CreatePostWithHttpInfo();
        /// <summary>
        /// Get the collection of posts.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PostRequest&gt;</returns>
        List<PostRequest> GetPosts();

        /// <summary>
        /// Get the collection of posts.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PostRequest&gt;</returns>
        ApiResponse<List<PostRequest>> GetPostsWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPostsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a new post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new post resource to the collection.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostModel</returns>
        System.Threading.Tasks.Task<PostModel> CreatePostAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a new post.
        /// </summary>
        /// <remarks>
        /// Method for adding a new post resource to the collection.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<PostModel>> CreatePostWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the collection of posts.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PostRequest&gt;</returns>
        System.Threading.Tasks.Task<List<PostRequest>> GetPostsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the collection of posts.
        /// </summary>
        /// <remarks>
        /// Returns a collection sorted by creation date.
        /// </remarks>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PostRequest&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PostRequest>>> GetPostsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPostsApi : IPostsApiSync, IPostsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PostsApi : IPostsApi
    {
        private Charm.Forum.ForumServiceClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PostsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PostsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PostsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PostsApi(Charm.Forum.ForumServiceClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PostsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PostsApi(Charm.Forum.ForumServiceClient.Client.ISynchronousClient client, Charm.Forum.ForumServiceClient.Client.IAsynchronousClient asyncClient, Charm.Forum.ForumServiceClient.Client.IReadableConfiguration configuration)
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
        /// Create a new post. Method for adding a new post resource to the collection.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PostModel</returns>
        public PostModel CreatePost()
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<PostModel> localVarResponse = CreatePostWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new post. Method for adding a new post resource to the collection.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PostModel</returns>
        public Charm.Forum.ForumServiceClient.Client.ApiResponse<PostModel> CreatePostWithHttpInfo()
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



            // make the HTTP request
            var localVarResponse = this.Client.Post<PostModel>("/posts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a new post. Method for adding a new post resource to the collection.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PostModel</returns>
        public async System.Threading.Tasks.Task<PostModel> CreatePostAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<PostModel> localVarResponse = await CreatePostWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new post. Method for adding a new post resource to the collection.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PostModel)</returns>
        public async System.Threading.Tasks.Task<Charm.Forum.ForumServiceClient.Client.ApiResponse<PostModel>> CreatePostWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<PostModel>("/posts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the collection of posts. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PostRequest&gt;</returns>
        public List<PostRequest> GetPosts()
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<List<PostRequest>> localVarResponse = GetPostsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the collection of posts. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PostRequest&gt;</returns>
        public Charm.Forum.ForumServiceClient.Client.ApiResponse<List<PostRequest>> GetPostsWithHttpInfo()
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



            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PostRequest>>("/posts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPosts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the collection of posts. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PostRequest&gt;</returns>
        public async System.Threading.Tasks.Task<List<PostRequest>> GetPostsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Charm.Forum.ForumServiceClient.Client.ApiResponse<List<PostRequest>> localVarResponse = await GetPostsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the collection of posts. Returns a collection sorted by creation date.
        /// </summary>
        /// <exception cref="Charm.Forum.ForumServiceClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PostRequest&gt;)</returns>
        public async System.Threading.Tasks.Task<Charm.Forum.ForumServiceClient.Client.ApiResponse<List<PostRequest>>> GetPostsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PostRequest>>("/posts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPosts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
