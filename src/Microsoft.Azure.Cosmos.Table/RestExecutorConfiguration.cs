using System;
using System.Net.Http;

namespace Microsoft.Azure.Cosmos.Table
{
	public class RestExecutorConfiguration
	{
		public DelegatingHandler DelegatingHandler
		{
			get;
			set;
		}

		public TimeSpan? HttpClientTimeout
		{
			get;
			set;
		}
	}
}
