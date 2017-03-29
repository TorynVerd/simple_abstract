/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 21.03.2017
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HtmlAgilityPack; 
using System.Collections.Generic;

namespace parse 
{
	class parce {
	public static void Main()
	{
		var config = Configuration.Instance;
		 string path_to_file1 = config.Path1;
		 string path_to_file2 = config.Path2;
		 string path_to_file3 = config.Path3;
		 DateTime date_till_find = config.Date_till_find;
		
		List<string> autor_name = new List<string>();
		List<string> date = new List<string>();
		List<string> name = new List<string>();
		List<string> number_users = new List<string>();
		List<string> link = new List<string>();
		      
        Habr habr = new Habr();
        PrepareToWrite wr = new PrepareToWrite();
        Leninka len = new Leninka();
        
      // habr.GetValue("//*/li[4]/a","class","post-author__link");
       
      //date = habr.GetValue("//*/div[1]/span","post__time_published");
        Console.WriteLine("*****************************************************");
         
      //name =  habr.GetValue("//*/div[1]/h2/a[2]","post__title_link");
        Console.WriteLine("*****************************************************");
        
     //  number_users = habr.GetValue("//*/li[2]/div","views-count_post");
        Console.WriteLine("*****************************************************");
        
    //   link = habr.GetLink("//*/div[1]/h2/a[2]","post__title_link");
        Console.WriteLine("*****************************************************");
        
    //    wr.HabrToFile(date,name,number_users,link,path_to_file1,date_till_find);
    //    wr.HabrToFile(date,name,number_users,link,path_to_file2,date_till_find);
    //     wr.HabrToFile(date,name,number_users,link,path_to_file3,date_till_find);
    
    
    link = len.GetLeninLink("//*/div/div/span/a");
    Console.WriteLine(link.Count);
    foreach (var el in link) 
		 {
    	Console.WriteLine(el);
    	string ss = el;
    	autor_name = len.GetLeninValue("//*/div[3]/div[2]/div[2]/div[1]/ul[1]/li[1]/span",ss);
    	Console.WriteLine("*****************************************************");
    	Console.WriteLine(autor_name.);
    	date = len.GetLeninValue("//*/div[3]/div[2]/div[2]/div[2]/div[2]/span[2]/span",ss);
    	Console.WriteLine("*****************************************************");
    	Console.WriteLine(date);
    	Console.WriteLine("*****************************************************");
    	name = len.GetLeninValue("//*/h1/span[1]",ss);
    	
    	Console.WriteLine(name);
    	}
    Console.WriteLine(autor_name.Count);
    Console.WriteLine(date.Count);
    Console.WriteLine(name.Count);
    
    //wr.LeninToFile(date,autor_name,name,link,path_to_file2);
		         
        Console.ReadLine();
        
	}
 }
}