// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.TestServerApi
{
	/// <summary>
	/// Request for CreateWidget.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class CreateWidgetRequestDto : ServiceDto<CreateWidgetRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public CreateWidgetRequestDto()
		{
		}

		/// <summary>
		/// The widget to create.
		/// </summary>
		public WidgetDto Widget { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(CreateWidgetRequestDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentDtos(Widget, other.Widget);
		}
	}
}
