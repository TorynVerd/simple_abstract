/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 29.03.2017
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HtmlAgilityPack; 
using System.Collections.Generic;

namespace parse
{
	/// <summary>
	/// Description of Leninka.
	/// </summary>
	public class Leninka
	{
		static HtmlWeb web1 = new HtmlWeb();  
		static HtmlDocument document1 = web1.Load("http://cyberleninka.ru/article/c/kibernetika");
		
		public List<string> GetLeninLink( string searchPath)
		{
			List<string> list = new List<string>();
			 
			 HtmlNodeCollection value = document1.DocumentNode.SelectNodes(searchPath);
             foreach (var tag in value) 
              {
        	   if(tag.Attributes["href"].Value !="")
        	    {
        		 list.Add(tag.Attributes["href"].Value);
        	    }
              }
         list.RemoveRange(0,3);
		 return list;
		}
		
		public string GetLeninValue( string searchPath,string el)
		{
			//List<string> list = new List<string>();
			string list = "";
		 	HtmlDocument document2 = web1.Load("http://cyberleninka.ru"+ el);
			HtmlNodeCollection value1 = document2.DocumentNode.SelectNodes(searchPath);
             foreach (var ili in value1) 
              {
        	   list = ili.InnerText;
        	   
        	  }
		 return list;
		}
		
		
	
		
	}
}
