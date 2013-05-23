using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class MyClass
{
	public static void RunSnippet()
	{
		try
        {	
			var passage = "Luke 1:37";
			var file = @"C:\Users\Krause\Documents\GitHub\dragthor.github.com\southridge\eNews.txt";
			var outFile = @"C:\Users\Krause\Documents\GitHub\dragthor.github.com\southridge\eNews.json";
			var result = new StringBuilder();
			
			result.Append("[{\"Date\":\"" + DateTime.Today.ToLongDateString() + "\",\"Author\":\"Nathan Tuckey\",\"Passage\":\"" + passage + "\",\"Message\":\"");
			
			// Default encoding, which uses the current system's ANSI codepage.
            using (StreamReader sr = new StreamReader(file, Encoding.Default, true))
            {
				var line = "";
				
				while((line = sr.ReadLine()) != null) {
					line = line.Replace("’", "'");
					line = line.Replace("“", "\"");
					line = line.Replace("”", "\"");
					line = line.Replace("\"", "\\\"");
					line = line.Replace("–", "-");
					
					if (line.IndexOf("’") > -1) throw new Exception();
					
					result.AppendFormat("<p>{0}</p>", line.Trim());
				}
				
				Console.WriteLine("Done and done.");
				sr.Close();
            }
			
			result.Append("\"}]");
			
            using (StreamWriter sw = File.CreateText(outFile)) 
            {
                sw.Write(result.ToString().Replace("<p></p>", ""));
				sw.Close();
            }	
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
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