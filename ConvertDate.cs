/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 27.03.2017
 * Time: 13:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HtmlAgilityPack;
using System.Collections.Generic;


namespace parse
{
	/// <summary>
	/// Description of GetVoid.
	/// </summary>
	class ConvertDate
	{
		DateTime dtime = DateTime.Today;
		
		public List<string> ConvertD( List<string> date)
		{ List<string> Ss = new List<string>();
		
			foreach (var d in date)
        	 {
        		string ss = d;
        		Console.WriteLine(d.Trim());
        	
        		 if (ss.Contains("сегодня"))
        	       {
        	        ss = d.Replace("сегодня", dtime.ToString("D"));
        	        
        	       }
        	    else if (ss.Contains("вчера"))
        	       {
        	    	dtime = dtime.AddDays(-1);
        	        ss = d.Replace("вчера", dtime.ToString("D"));
        	        dtime = dtime.AddDays(+1);
        	        
        	       }
        	    ss = ss.Replace(" в "," ");
            Ss.Add(ss.Trim());
            }
		return Ss;
		}
      }
}
