using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
    public class AuthService
	{
		public Async<FUserInfo> AcceptLicence(int licenseVersion)
		{
			return new Async<FUserInfo>("AuthService", "acceptLicence", new object[]
			{
				licenseVersion
			});
		}

		public Async<FAuthData> DevSingIn(string login, bool validateNickname, bool asDevice)
		{
			return new Async<FAuthData>("AuthService", "devSingIn", new object[]
			{
				login,
				validateNickname,
				asDevice
			});
		}

		public Async<FConfig> GetConfig(string language)
		{
			return new Async<FConfig>("AuthService", "getConfig", new object[]
			{
				language
			});
		}

		public Async<FNewsArticle> GetNews(string locale, string seenNews)
		{
			return new Async<FNewsArticle>("AuthService", "getNews", new object[]
			{
				locale,
				seenNews
			});
		}

		public Async<FNewsArticle> GetOffers(string locale, string seenNews)
		{
			return new Async<FNewsArticle>("AuthService", "getOffers", new object[]
			{
				locale,
				seenNews
			});
		}

		public Async<FTips> GetTips(string locale)
		{
			return new Async<FTips>("AuthService", "getTips", new object[]
			{
				locale
			});
		}

		public Async<FAuthData> LinkTo(AuthData authData, FClientInfo clientInfo, FRegistrationInfo regInfo, bool force)
		{
			return new Async<FAuthData>("AuthService", "linkTo", new object[]
			{
				authData,
				clientInfo,
				regInfo,
				force
			});
		}

		public Async<FTips> MarkTip(string locale, bool value)
		{
			return new Async<FTips>("AuthService", "markTip", new object[]
			{
				locale,
				value
			});
		}

		public Async<FAuthData> Register(AuthData authData, string nickname, FClientInfo clientInfo, FRegistrationInfo regInfo)
		{
			return new Async<FAuthData>("AuthService", "register", new object[]
			{
				authData,
				nickname,
				clientInfo,
				regInfo
			});
		}

		public Async<FAuthData> TrySingIn(AuthData authData, FClientInfo clientInfo, FRegistrationInfo regInfo)
		{
			return new Async<FAuthData>("AuthService", "trySingIn", new object[]
			{
				authData,
				clientInfo,
				regInfo
			});
		}

		public Async<FNicknameValidationResult> ValidateNickname(string nickname)
		{
			return new Async<FNicknameValidationResult>("AuthService", "validateNickname", new object[]
			{
				nickname
			});
		}
	}
}
