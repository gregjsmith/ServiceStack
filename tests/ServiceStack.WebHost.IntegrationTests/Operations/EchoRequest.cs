using System;
using System.Runtime.Serialization;

namespace ServiceStack.WebHost.IntegrationTests.Operations
{
	[DataContract]
	public class EchoRequest
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string String { get; set; }

		[DataMember]
		public long Long { get; set; }

		[DataMember]
		public Guid Guid { get; set; }

		[DataMember]
		public bool Bool { get; set; }

		[DataMember]
		public DateTime DateTime { get; set; }

		[DataMember]
		public double Double { get; set; }
	}

	[DataContract]
	public class EchoRequestResponse
	{
		[DataMember]
		public string Result { get; set; }
	}
}