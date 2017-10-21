namespace DracoProtos.Command
{
    public class FUpdateNicknameResult : FUpdateNicknameResultBase
	{
		public FUpdateNicknameResult()
		{
		}

		public FUpdateNicknameResult(FUserInfo userInfo)
		{
			this.userInfo = userInfo;
		}

		public override void Handle()
		{
			if (this.userInfo != null)
			{
				this.userInfo.Handle();
			}
		}
	}
}
