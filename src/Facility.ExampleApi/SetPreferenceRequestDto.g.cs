// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// Request for SetPreference.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class SetPreferenceRequestDto : ServiceDto<SetPreferenceRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public SetPreferenceRequestDto()
		{
		}

		/// <summary>
		/// The preference key.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// The preference value.
		/// </summary>
		public PreferenceDto Value { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(SetPreferenceRequestDto other)
		{
			return other != null &&
				Key == other.Key &&
				ServiceDataUtility.AreEquivalentDtos(Value, other.Value);
		}
	}
}
