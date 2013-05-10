using System;
using System.Collections.Generic;
using System.Net;

public class MyClass
{
	public static void RunSnippet()
	{
		var minLimit = 11;
		var maxLimit = 51;
		var url = "http://graph.facebook.com/southridgecommunitychurch/albums/?fields=name,cover_photo,description,count,likes&limit={0}";
		var local = @"C:\Users\Krause\Documents\GitHub\dragthor.github.com\southridge\albums-{0}.json";
		
		WebClient web  = new WebClient();

		web.DownloadFile(string.Format(url, minLimit), string.Format(local, minLimit));
		web.DownloadFile(string.Format(url, maxLimit), string.Format(local, maxLimit));	
	}
	
	#region Helper methods
	
	public static void Main()
	{
		try
		{
			RunSnippet();
		}
		catch (Exception e)
		{
			string error = string.Format("---\nThe following error occurred while executing the snippet:\n{0}\n---", e.ToString());
			Console.WriteLine(error);
		}
		finally
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}

	private static void WL(object text, params object[] args)
	{
		Console.WriteLine(text.ToString(), args);	
	}
	
	private static void RL()
	{
		Console.ReadLine();	
	}
	
	private static void Break() 
	{
		System.Diagnostics.Debugger.Break();
	}

	#endregion
}