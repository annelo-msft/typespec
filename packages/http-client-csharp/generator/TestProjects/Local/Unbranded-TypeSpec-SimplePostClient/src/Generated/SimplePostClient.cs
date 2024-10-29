// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;

namespace SimplePost
{
    /// <summary></summary>
    public partial class SimplePostClient
    {
        private readonly Uri _endpoint;
        private SimplePostClient _cachedSimplePostClient;

        /// <summary> Initializes a new instance of SimplePostClient for mocking. </summary>
        protected SimplePostClient()
        {
        }

        internal SimplePostClient(ClientPipeline pipeline, Uri endpoint)
        {
            _endpoint = endpoint;
            Pipeline = pipeline;
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public ClientPipeline Pipeline { get; }

        /// <summary>
        /// [Protocol Method] IncrementCount
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addend"></param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult IncrementCount(int addend, RequestOptions options)
        {
            using PipelineMessage message = CreateIncrementCountRequest(addend, options);
            return ClientResult.FromResponse(Pipeline.ProcessMessage(message, options));
        }

        /// <summary>
        /// [Protocol Method] IncrementCount
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="addend"></param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> IncrementCountAsync(int addend, RequestOptions options)
        {
            using PipelineMessage message = CreateIncrementCountRequest(addend, options);
            return ClientResult.FromResponse(await Pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary> IncrementCount. </summary>
        /// <param name="addend"></param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        public virtual ClientResult<int> IncrementCount(int addend)
        {
            ClientResult result = IncrementCount(addend, null);
            return ClientResult.FromValue(result.GetRawResponse().Content.ToObjectFromJson<int>(), result.GetRawResponse());
        }

        /// <summary> IncrementCount. </summary>
        /// <param name="addend"></param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        public virtual async Task<ClientResult<int>> IncrementCountAsync(int addend)
        {
            ClientResult result = await IncrementCountAsync(addend, null).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content.ToObjectFromJson<int>(), result.GetRawResponse());
        }

        /// <summary> Initializes a new instance of SimplePostClient. </summary>
        public virtual SimplePostClient GetSimplePostClient()
        {
            return Volatile.Read(ref _cachedSimplePostClient) ?? Interlocked.CompareExchange(ref _cachedSimplePostClient, new SimplePostClient(Pipeline, _endpoint), null) ?? _cachedSimplePostClient;
        }
    }
}
