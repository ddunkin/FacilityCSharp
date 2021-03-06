// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using System.Net;

namespace Facility.Core.Http
{
	/// <summary>
	/// Common service errors.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public static partial class HttpServiceErrors
	{
		/// <summary>
		/// Gets the HTTP status code that corresponds to the specified error code.
		/// </summary>
		public static HttpStatusCode? TryGetHttpStatusCode(string errorCode)
		{
			int statusCode;
			return s_errorToStatus.TryGetValue(errorCode, out statusCode) ? (HttpStatusCode?) statusCode : null;
		}

		/// <summary>
		/// Gets the error code that corresponds to the specified HTTP status code.
		/// </summary>
		public static string TryGetErrorCode(HttpStatusCode statusCode)
		{
			switch ((int) statusCode)
			{
				case 304: return "NotModified";
				case 400: return "InvalidRequest";
				case 401: return "NotAuthenticated";
				case 403: return "NotAuthorized";
				case 404: return "NotFound";
				case 409: return "Conflict";
				case 413: return "RequestTooLarge";
				case 429: return "TooManyRequests";
				case 500: return "InternalError";
				case 503: return "ServiceUnavailable";
				default: return null;
			}
		}

		static readonly IReadOnlyDictionary<string, int> s_errorToStatus = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
		{
			["InvalidRequest"] = 400,
			["InternalError"] = 500,
			["InvalidResponse"] = 500,
			["ServiceUnavailable"] = 503,
			["Timeout"] = 500,
			["NotAuthenticated"] = 401,
			["NotAuthorized"] = 403,
			["NotFound"] = 404,
			["NotModified"] = 304,
			["Conflict"] = 409,
			["TooManyRequests"] = 429,
			["RequestTooLarge"] = 413,
		};
	}
}
