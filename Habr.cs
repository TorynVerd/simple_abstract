/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 24.03.2017
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HtmlAgilityPack; 
using System.Collections.Generic;

namespace parse
{
	/// <summary>
	/// Description of Habr.
	/// </summary>
	 class Habr
	{
		static HtmlWeb web1 = new HtmlWeb();  
		static HtmlDocument document1 = web1.Load("https://habrahabr.ru");
		
		public List<string> GetValue( string searchPath, string searchValue)
		{
			List<string> list = new List<string>();
			 
			 HtmlNodeCollection value = document1.DocumentNode.SelectNodes(searchPath);
             foreach (var tag in value) 
              {
        	   if(tag.Attributes["class"].Value == searchValue)
        	    {
        		 //Console.WriteLine(tag.InnerText);
        		 list.Add(tag.InnerText);
        	    }
              }
		 return list;
		}
		
		public List<string> GetLink (string searchPath, string searchValue)
		{
		   List<string> list = new List<string>();
		  HtmlNodeCollection link = document1.DocumentNode.SelectNodes(searchPath);
          foreach (var tag in link) 
           {
        	if(tag.Attributes["class"].Value == searchValue)
        	{
        		//Console.WriteLine(tag.Attributes["href"].Value);
        		list.Add(tag.Attributes["href"].Value);
        	}
		   }
		  return list;
		}
		
	}
}
