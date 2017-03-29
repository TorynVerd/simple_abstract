/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 28.03.2017
 * Time: 14:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace parse
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class PrepareToWrite
	{
		
		WriteFile writefile = new WriteFile();
		int count =0;
		int number = 0;
		List<int> numbers = new List<int>();
		ConvertDate convert = new ConvertDate();
		List<string> da = new List<string>();
		
		
			
		public void HabrToFile (List<string> date,List<string> name,List<string> number_users,List<string> link, string path_to_file, DateTime date_till_find)
			{
		 		da = convert.ConvertD(date);
		 
        
        		foreach (var el in da)
        			{
        				
        				string z = el;	
        				DateTime dateValue1;
        				DateTime.TryParse(z, out dateValue1);
        				
        				if (date_till_find.CompareTo(dateValue1) < 0 )
        					{
        					    numbers.Add(number);
        						count ++;
        						
        						
        					}
        				number ++;
        	
        			}
        		Console.WriteLine(count);
        		    
        		writefile.WriteHabrIn(count,numbers,path_to_file,da,name,number_users,link);
        		 count =0;
		         number = 0;
   
       
		}
	public void LeninToFile (List<string> date,List<string> name,List<string> autor_name,List<string> link, string path_to_file)
	{
		writefile.WriteLeninIn(path_to_file,date,autor_name,name,link);
	}
	}
}
