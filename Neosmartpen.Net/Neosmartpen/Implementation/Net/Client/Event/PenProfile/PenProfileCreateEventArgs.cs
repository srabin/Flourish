﻿namespace Neosmartpen.Net
{
	public sealed class PenProfileCreateEventArgs : PenProfileReceivedEventArgs
	{
		internal PenProfileCreateEventArgs()
		{
			Type = PenProfileType.Create;
			Result = ResultType.Successs;
		}
		internal PenProfileCreateEventArgs(string profileName, int status) : this()
		{
			ProfileName = profileName;
			Status = status;
		}
	}
}
