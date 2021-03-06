// DO NOT EDIT: generated by fsdgencsharp
using System;
using Facility.Core;
using Newtonsoft.Json;

#pragma warning disable 612, 618 // member is obsolete

namespace Facility.ExampleApi
{
	/// <summary>
	/// Identifies a widget field.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[JsonConverter(typeof(WidgetFieldJsonConverter))]
	public partial struct WidgetField : IEquatable<WidgetField>
	{
		/// <summary>
		/// The 'id' field.
		/// </summary>
		public static readonly WidgetField Id = new WidgetField("id");

		/// <summary>
		/// The 'name' field.
		/// </summary>
		public static readonly WidgetField Name = new WidgetField("name");

		/// <summary>
		/// The 'weight' field.
		/// </summary>
		[Obsolete]
		public static readonly WidgetField Weight = new WidgetField("weight");

		/// <summary>
		/// Creates an instance.
		/// </summary>
		public WidgetField(string value)
		{
			m_value = value;
		}

		/// <summary>
		/// Converts the instance to a string.
		/// </summary>
		public override string ToString()
		{
			return m_value ?? "";
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public bool Equals(WidgetField other)
		{
			return StringComparer.OrdinalIgnoreCase.Equals(ToString(), other.ToString());
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is WidgetField && Equals((WidgetField) obj);
		}

		/// <summary>
		/// Gets the hash code.
		/// </summary>
		public override int GetHashCode()
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(ToString());
		}

		/// <summary>
		/// Checks for equality.
		/// </summary>
		public static bool operator ==(WidgetField left, WidgetField right)
		{
			return left.Equals(right);
		}

		/// <summary>
		/// Checks for inequality.
		/// </summary>
		public static bool operator !=(WidgetField left, WidgetField right)
		{
			return !left.Equals(right);
		}

		/// <summary>
		/// Returns true if the instance is equal to one of the defined values.
		/// </summary>
		public bool IsDefined()
		{
			return Equals(Id) ||
				Equals(Name) ||
				Equals(Weight);
		}

		/// <summary>
		/// Used for JSON serialization.
		/// </summary>
		public sealed class WidgetFieldJsonConverter : ServiceEnumJsonConverter<WidgetField>
		{
			/// <summary>
			/// Creates the value from a string.
			/// </summary>
			protected override WidgetField CreateCore(string value)
			{
				return new WidgetField(value);
			}
		}

		readonly string m_value;
	}
}
