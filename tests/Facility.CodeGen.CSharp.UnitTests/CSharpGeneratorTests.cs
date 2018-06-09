using System;
using System.IO;
using Facility.Definition;
using Facility.Definition.Fsd;
using FluentAssertions;
using NUnit.Framework;

namespace Facility.CodeGen.CSharp.UnitTests
{
	public sealed class CSharpGeneratorTests
	{
		[Test]
		public void DuplicateType()
		{
			ThrowsServiceDefinitionException(
				"service TestApi { method do {}: {} data doRequest {} }",
				"TestApi.fsd(1,36): Element generates duplicate C# type 'DoRequestDto'.");
		}

		[Test]
		public void DuplicateServiceAttribute()
		{
			ThrowsServiceDefinitionException(
				"[csharp] [csharp] service TestApi { method do {}: {} }",
				"TestApi.fsd(1,11): 'csharp' attribute is duplicated.");
		}

		[Test]
		public void UnknownServiceAttributeParameter()
		{
			ThrowsServiceDefinitionException(
				"[csharp(name: hmm)] service TestApi { method do {}: {} }",
				"TestApi.fsd(1,9): Unexpected 'csharp' parameter 'name'.");
		}

		[Test]
		public void UnknownMethodAttribute()
		{
			ThrowsServiceDefinitionException(
				"service TestApi { [csharp] method do {}: {} }",
				"TestApi.fsd(1,20): Unexpected 'csharp' attribute.");
		}

		[Test]
		public void UnknownFieldAttributeParameter()
		{
			ThrowsServiceDefinitionException(
				"service TestApi { method do { [csharp(namespace: hmm)] something: string; }: {} }",
				"TestApi.fsd(1,39): Unexpected 'csharp' parameter 'namespace'.");
		}

		[Test]
		public void GenerateEdgeCases()
		{
			string fileName = Path.Combine(TestUtility.GetSolutionDirectory(), "tools", "EdgeCases.fsd");
			var parser = new FsdParser();
			var service = parser.ParseDefinition(
				new ServiceDefinitionText(Path.GetFileName(fileName), File.ReadAllText(fileName)));

			var generator = new CSharpGenerator { GeneratorName = nameof(CSharpGeneratorTests) };
			generator.GenerateOutput(service);
		}

		private void ThrowsServiceDefinitionException(string definition, string message)
		{
			var parser = new FsdParser();
			var service = parser.ParseDefinition(new ServiceDefinitionText("TestApi.fsd", definition));
			var generator = new CSharpGenerator { GeneratorName = "CodeGenTests" };
			Action action = () => generator.GenerateOutput(service);
			action.Should().Throw<ServiceDefinitionException>().WithMessage(message);
		}
	}
}
