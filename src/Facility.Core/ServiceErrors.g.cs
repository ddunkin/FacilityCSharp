// DO NOT EDIT: generated by fsdgencsharp
namespace Facility.Core
{
	/// <summary>
	/// Common service errors.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public static partial class ServiceErrors
	{
		/// <summary>
		/// The request was invalid.
		/// </summary>
		public const string InvalidRequest = "InvalidRequest";

		/// <summary>
		/// The service experienced an unexpected internal error.
		/// </summary>
		public const string InternalError = "InternalError";

		/// <summary>
		/// The service returned an unexpected response.
		/// </summary>
		public const string InvalidResponse = "InvalidResponse";

		/// <summary>
		/// The service is unavailable.
		/// </summary>
		public const string ServiceUnavailable = "ServiceUnavailable";

		/// <summary>
		/// The service timed out.
		/// </summary>
		public const string Timeout = "Timeout";

		/// <summary>
		/// The client must be authenticated.
		/// </summary>
		public const string NotAuthenticated = "NotAuthenticated";

		/// <summary>
		/// The authenticated client does not have the required authorization.
		/// </summary>
		public const string NotAuthorized = "NotAuthorized";

		/// <summary>
		/// The specified item was not found.
		/// </summary>
		public const string NotFound = "NotFound";

		/// <summary>
		/// The specified item was not modified.
		/// </summary>
		public const string NotModified = "NotModified";

		/// <summary>
		/// A conflict occurred.
		/// </summary>
		public const string Conflict = "Conflict";

		/// <summary>
		/// The client has made too many requests.
		/// </summary>
		public const string TooManyRequests = "TooManyRequests";

		/// <summary>
		/// The request is too large.
		/// </summary>
		public const string RequestTooLarge = "RequestTooLarge";

		/// <summary>
		/// The request was invalid.
		/// </summary>
		public static ServiceErrorDto CreateInvalidRequest(string message = null)
		{
			return new ServiceErrorDto(InvalidRequest, message ?? "The request was invalid.");
		}

		/// <summary>
		/// The service experienced an unexpected internal error.
		/// </summary>
		public static ServiceErrorDto CreateInternalError(string message = null)
		{
			return new ServiceErrorDto(InternalError, message ?? "The service experienced an unexpected internal error.");
		}

		/// <summary>
		/// The service returned an unexpected response.
		/// </summary>
		public static ServiceErrorDto CreateInvalidResponse(string message = null)
		{
			return new ServiceErrorDto(InvalidResponse, message ?? "The service returned an unexpected response.");
		}

		/// <summary>
		/// The service is unavailable.
		/// </summary>
		public static ServiceErrorDto CreateServiceUnavailable(string message = null)
		{
			return new ServiceErrorDto(ServiceUnavailable, message ?? "The service is unavailable.");
		}

		/// <summary>
		/// The service timed out.
		/// </summary>
		public static ServiceErrorDto CreateTimeout(string message = null)
		{
			return new ServiceErrorDto(Timeout, message ?? "The service timed out.");
		}

		/// <summary>
		/// The client must be authenticated.
		/// </summary>
		public static ServiceErrorDto CreateNotAuthenticated(string message = null)
		{
			return new ServiceErrorDto(NotAuthenticated, message ?? "The client must be authenticated.");
		}

		/// <summary>
		/// The authenticated client does not have the required authorization.
		/// </summary>
		public static ServiceErrorDto CreateNotAuthorized(string message = null)
		{
			return new ServiceErrorDto(NotAuthorized, message ?? "The authenticated client does not have the required authorization.");
		}

		/// <summary>
		/// The specified item was not found.
		/// </summary>
		public static ServiceErrorDto CreateNotFound(string message = null)
		{
			return new ServiceErrorDto(NotFound, message ?? "The specified item was not found.");
		}

		/// <summary>
		/// The specified item was not modified.
		/// </summary>
		public static ServiceErrorDto CreateNotModified(string message = null)
		{
			return new ServiceErrorDto(NotModified, message ?? "The specified item was not modified.");
		}

		/// <summary>
		/// A conflict occurred.
		/// </summary>
		public static ServiceErrorDto CreateConflict(string message = null)
		{
			return new ServiceErrorDto(Conflict, message ?? "A conflict occurred.");
		}

		/// <summary>
		/// The client has made too many requests.
		/// </summary>
		public static ServiceErrorDto CreateTooManyRequests(string message = null)
		{
			return new ServiceErrorDto(TooManyRequests, message ?? "The client has made too many requests.");
		}

		/// <summary>
		/// The request is too large.
		/// </summary>
		public static ServiceErrorDto CreateRequestTooLarge(string message = null)
		{
			return new ServiceErrorDto(RequestTooLarge, message ?? "The request is too large.");
		}
	}
}
