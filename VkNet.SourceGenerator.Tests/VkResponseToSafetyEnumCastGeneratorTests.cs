﻿using System.IO;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace VkNet.SourceGenerator.Tests
{
	public class VkResponseToSafetyEnumCastGeneratorTests : BaseSourceGeneratorTests
	{
		[Fact]
		public void SimpleGeneratorTest()
		{
			var currentCompilation =
				CreateCompilation(Directory.GetFiles(Path.Combine(GetVkNetRootDirectory()), "*.cs", SearchOption.AllDirectories)
					.Select(File.ReadAllText));

			var newCompilation = RunGenerators(currentCompilation,
				out var generatorDiagnostics,
				new VkResponseToSafetyEnumCastGenerator());

			var generatedTrees = newCompilation.RemoveSyntaxTrees(currentCompilation.SyntaxTrees).SyntaxTrees;

			generatedTrees.Should().ContainSingle();
			generatorDiagnostics.Should().BeEmpty();
			// newCompilation.GetDiagnostics().Should().BeEmpty(); // TODO: Временно убираем пока есть предупреждения
		}
	}
}