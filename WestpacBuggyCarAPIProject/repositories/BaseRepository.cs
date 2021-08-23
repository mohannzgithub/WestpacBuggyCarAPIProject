using System;
using System.Collections;
using System.Collections.Generic;
using HeaderConstants = constants.HeaderConstants;
using RestSharp;
using Newtonsoft.Json;

namespace repositories
{
	public class BaseRepository
	{
		
		public T POST<T>(string url, Hashtable headers, string requestBody)
		{
			return CallAPI<T>(url, Method.POST, requestBody);
		}

		public T GET<T>(string url)
		{
			return CallAPI<T>(url, Method.GET);
		}

		private T CallAPI<T>(string url,Method method,Object body=null){
			var client = new RestClient(url);
			client.Timeout = -1;
			var request = new RestRequest(method);
			request.AddHeader("Content-Type", "application/json");
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
			return JsonConvert.DeserializeObject<T>(response.Content);
		}
	}

}