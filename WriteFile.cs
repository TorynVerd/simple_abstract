
/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 29.03.2017
 * Time: 8:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace parse
{
	/// <summary>
	/// Description of WriteFile.
	/// </summary>
	public class WriteFile
	{
		public void WriteHabrIn( int count, List<int> numbers, string path_to_file,List<string> da,List<string> name,List<string> number_users,List<string> link)
		{
			for (int i = 0; i < count; i++)
   				{
   					FileStream file = new FileStream(path_to_file, FileMode.Append);
   					StreamWriter writer = new StreamWriter(file);
   					writer.WriteLine(da[numbers[i]]+" " + name[numbers[i]]+ " " + number_users[numbers[i]] + " " + link[numbers[i]]);
   					writer.Close();
   				}
		}
		public void WriteLeninIn( string path_to_file,List<string> da,List<string> autor_name,List<string> name,List<string> link)
		{
			int count = link.Count;
			Console.WriteLine(count);
			for (int i = 0; i < count; i++)
   				{
   					FileStream file = new FileStream(path_to_file, FileMode.Append);
   					StreamWriter writer = new StreamWriter(file);
   					writer.WriteLine(da[i]+" " + autor_name[i] + " " + name[i]+ " " + link[i]);
   					writer.Close();
   				}
		}
	}
}
