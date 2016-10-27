// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// Request for GetWidgetBatch.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GetWidgetBatchRequestDto : ServiceDto<GetWidgetBatchRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetWidgetBatchRequestDto()
		{
		}

		/// <summary>
		/// The IDs of the widgets to return.
		/// </summary>
		public IReadOnlyList<string> Ids { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetBatchRequestDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentArrays(Ids, other.Ids);
		}
	}
}
