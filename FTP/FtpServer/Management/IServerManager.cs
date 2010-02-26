﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace GiantSoft.FtpService.Management
{
	[ServiceContract]
	public interface IServerManager
	{
		[OperationContract]
		void Start();

		[OperationContract]
		void Stop();

		[OperationContract]
		void Restart();
	}
}
