/*
 * Created by SharpDevelop.
 * User: Toryn
 * Date: 29.03.2017
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace parse
{
	/// <summary>
	/// Description of Configuration1.
	/// </summary>
	public class Configuration
    {
        private const string ConfigPath = "config.ini";

        private static Configuration _configuration;

        private Configuration()
        {
        }

        public DateTime Date_till_find { get; private set; }

        public string Path1 { get; private set; }
        public string Path2 { get; private set; }
        public string Path3 { get; private set; }

        public static Configuration Instance
        {
            get
            {
                _configuration = _configuration ?? Load();
                return _configuration;
            }
        }

        private static Configuration Load()
        {
            var lines = File.ReadAllLines(ConfigPath);
            int year = 2017,month = 3,day = 29,hour =1,minutes = 0,seconds = 0;
		 	
            string path1 = "statistics.txt";
            string path2 = "statistics.txt";
            string path3 = "statistics.txt";
            
            
            foreach (var line in lines)
            {
                var spl = line.Split('=');
                var name = spl[0].ToLowerInvariant();

                if (name == "year")
                {
                	year = Int32.Parse(spl[1]);
                }
                 if (name == "month")
                {
                 	month = Int32.Parse(spl[1]);
                }
                  if (name == "day")
                {
                	day = Int32.Parse(spl[1]);
                }
                   if (name == "hour")
                {
                	hour = Int32.Parse(spl[1]);
                }
                    if (name == "minutes")
                {
                	minutes = Int32.Parse(spl[1]);
                }
                     if (name == "seconds")
                {
                	seconds = Int32.Parse(spl[1]);
                }
                else if (name == "file_path1")
                {
                    path1 = spl[1];
                }
                else if (name == "file_path2")
                {
                    path2 = spl[1];
                }
                else if (name == "file_path3")
                {
                    path3 = spl[1];
                }
            }
            DateTime date_till_find = new DateTime(year,month,day,hour,minutes,seconds);

            return new Configuration
            {
                Date_till_find = date_till_find,
                
                Path1 = path1,
                
                Path2 = path2,
                
                Path3 = path3,
            };
        }
    }
}
