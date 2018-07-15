using System;
using System.Collections.Generic;
using DracoProtos.Core.Extensions;
using DracoProtos.Core.Objects;

namespace DracoProtos.Core.Base
{
	public class ClientEventService
	{
		public Async<object> ClientLogRecords(List<FClientLogRecord> logRecords)
		{
			return new Async<object>("ClientEventService", "clientLogRecords", new object[]
			{
				logRecords
			});
		}

		public Async<object> OnEventWithCounter(string name, string userId, FClientInfo clientInfo, int counter, string param1, string param2, string param3, string param4, string param5)
		{
			return new Async<object>("ClientEventService", "onEventWithCounter", new object[]
			{
				name,
				userId,
				clientInfo,
				counter,
				param1,
				param2,
				param3,
				param4,
				param5
			});
		}

		public Async<object> OptionChanged(string option, string newValue, string defValue)
		{
			return new Async<object>("ClientEventService", "optionChanged", new object[]
			{
				option,
				newValue,
				defValue
			});
		}
	}
}
