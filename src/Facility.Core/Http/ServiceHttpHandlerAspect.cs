﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Facility.Core.Http
{
	/// <summary>
	/// Used to provide common functionality to every HTTP service handler.
	/// </summary>
	public abstract class ServiceHttpHandlerAspect
	{
		/// <summary>
		/// Called when the request is received.
		/// </summary>
		/// <remarks>If a non-null response message is returned, it is used instead of the normal service behavior.</remarks>
		public Task<HttpResponseMessage> RequestReceivedAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
		{
			return RequestReceivedAsyncCore(httpRequest, cancellationToken);
		}

		/// <summary>
		/// Called right before the response is sent.
		/// </summary>
		public Task ResponseReadyAsync(HttpResponseMessage httpResponse, ServiceResult<ServiceDto> result, CancellationToken cancellationToken)
		{
			return ResponseReadyAsyncCore(httpResponse, result, cancellationToken);
		}

		/// <summary>
		/// Creates an aspect.
		/// </summary>
		protected ServiceHttpHandlerAspect()
		{
		}

		/// <summary>
		/// Called right before the request is sent.
		/// </summary>
		protected virtual Task<HttpResponseMessage> RequestReceivedAsyncCore(HttpRequestMessage httpRequest, CancellationToken cancellationToken)
		{
			return Task.FromResult<HttpResponseMessage>(null);
		}

		/// <summary>
		/// Called right after the response is received.
		/// </summary>
		protected virtual Task ResponseReadyAsyncCore(HttpResponseMessage httpResponse, ServiceResult<ServiceDto> result, CancellationToken cancellationToken)
		{
			return Task.FromResult<object>(null);
		}
	}
}
