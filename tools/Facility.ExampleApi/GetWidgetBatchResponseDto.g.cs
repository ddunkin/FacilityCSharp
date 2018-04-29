// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// Response for GetWidgetBatch.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GetWidgetBatchResponseDto : ServiceDto<GetWidgetBatchResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetWidgetBatchResponseDto()
		{
		}

		/// <summary>
		/// The widget results.
		/// </summary>
		public IReadOnlyList<ServiceResult<WidgetDto>> Results { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetWidgetBatchResponseDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentFieldValues(Results, other.Results);
		}
	}
}