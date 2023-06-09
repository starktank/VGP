using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.NewsFeed;
using VkNet.Tests.Infrastructure;

namespace VkNet.Tests.Categories.NewsFeed
{
	[TestFixture]
	[SuppressMessage("ReSharper", "PublicMemgitbersMustHaveComments")]

	public class NewsFeedCategoryTest : CategoryBaseTest
	{
		/// <inheritdoc />
		protected override string Folder { get; } = "NewsFeed";

		[Test]
		public void Get()
		{
			Url = "https://api.vk.com/method/newsfeed.get";

			ReadCategoryJsonPath(nameof(Get));

			var result = Api.NewsFeed.Get(new NewsFeedGetParams
			{
				SourceIds = new []{"1234"}
			});

			Assert.IsNotEmpty(result.Items);
		}

		[Test]
		public void GetRecommended()
		{
			Url = "https://api.vk.com/method/newsfeed.getRecommended";

			ReadCategoryJsonPath(nameof(GetRecommended));

			var result = Api.NewsFeed.GetRecommended(new NewsFeedGetRecommendedParams
			{
				Count = 1
			});

			Assert.IsNotEmpty(result.Items);
		}
	}
}