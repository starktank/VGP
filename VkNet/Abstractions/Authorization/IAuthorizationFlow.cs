﻿using System.Threading;
using System.Threading.Tasks;
using VkNet.Model.RequestParams.Auth;
using VkNet.Model.Results.Auth;

namespace VkNet.Abstractions.Authorization
{
	/// <summary>
	/// Поток авторизации
	/// </summary>
	public interface IAuthorizationFlow
	{
		/// <summary>
		/// Авторизация
		/// </summary>
		/// <param name="token"></param>
		/// <returns> Access token. </returns>
		Task<AuthorizationResult> AuthorizeAsync(CancellationToken token = default);

		/// <summary>
		/// Задать параметры авторизации
		/// </summary>
		/// <param name="authorizationParams">Параметры авторизации</param>
		void SetAuthorizationParams(IApiAuthParams authorizationParams);
	}
}