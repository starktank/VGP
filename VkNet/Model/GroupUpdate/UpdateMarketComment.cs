using System;
using VkNet.Model.Attachments;
using VkNet.Utils;

namespace VkNet.Model.GroupUpdate
{
	/// <summary>
	/// Добавление/редактирование/восстановление комментария к товару
	/// (<c>MarketCommentNew</c>, <c>MarketCommentEdit</c>, <c>MarketCommentRestore</c>)
	/// (<c>Comment</c> с дополнительными полями)
	/// </summary>
	[Serializable]
	public class UpdateMarketComment : Comment
	{
		/// <summary>
		/// Идентификатор товара
		/// </summary>
		public ulong? ItemId { get; set; }

		/// <summary>
		/// Идентификатор владельца товара
		/// </summary>
		public long? MarketOwnerId { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		public new static UpdateMarketComment FromJson(VkResponse response)
		{
			return new()
			{
				Id = response[key: "id"],
				FromId = response[key: "from_id"],
				Date = response[key: "date"],
				Text = response[key: "text"],
				ReplyToUser = response[key: "reply_to_user"],
				ReplyToComment = response[key: "reply_to_comment"],
				Attachments = response[key: "attachments"].ToReadOnlyCollectionOf<Attachment>(selector: x => x),
				Likes = response[key: "likes"],
				ItemId = response["item_id"],
				MarketOwnerId = response["market_owner_id"]
			};
		}
	}
}