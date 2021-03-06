﻿using System.IO;
using System.Reflection;
using Facility.Definition;
using Facility.Definition.Fsd;
using NUnit.Framework;

namespace Facility.CodeGen.CSharp.UnitTests
{
	public sealed class CSharpGeneratorTests
	{
		[Test]
		public void GenerateExampleApiSuccess()
		{
			ServiceInfo service;
			const string fileName = "Facility.CodeGen.CSharp.UnitTests.ExampleApi.fsd";
			var parser = new FsdParser();
			using (var reader = new StreamReader(GetType().GetTypeInfo().Assembly.GetManifestResourceStream(fileName)))
				service = parser.ParseDefinition(new NamedText(Path.GetFileName(fileName), reader.ReadToEnd()));

			var generator = new CSharpGenerator
			{
				GeneratorName = "CSharpGeneratorTests",
			};
			generator.GenerateOutput(service);
		}
	}
}
