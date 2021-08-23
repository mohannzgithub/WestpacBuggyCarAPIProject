using System;
using System.Configuration;
using System.IO;

namespace config
{
	public static class ReadConfigHelper
	{
		public static string readEndPointUrl()
		{
			var URL="https://k51qryqov3.execute-api.ap-southeast-2.amazonaws.com/prod/";
			return URL; 
		}
		
	}

}