<<<<<<< HEAD
﻿using ComLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System;
using System.Diagnostics;
using System.Reflection;
>>>>>>> 5fa1eb16526b3127117df455a3a8b6ca78e7c547

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            CommonTool tool = new CommonTool();
            var ss = tool.GetHttpPost();
            Console.WriteLine($"{ss}");
            //var ss = tool.GetHttp();
            //Console.WriteLine($"{ss}");
            Console.ReadLine();
=======
            if (RunningInstance() == null)
            {
                Console.WriteLine("启动。。。");
            }
            else
            {
                Console.WriteLine("已经运行了一个实例了。");
            }
            Console.Read();
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Console.WriteLine($"当前进程名称：{current.ProcessName},  current.MainModule.FileName：{current.MainModule.FileName}");
            
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes) //查找相同名称的进程 
            {
                if (process.Id != current.Id) //忽略当前进程
                { //确认相同进程的程序运行位置是否一样. 
                    var local = Assembly.GetExecutingAssembly().Location;
                    Console.WriteLine($"Assembly.GetExecutingAssembly().Location：{local}");
                    if (local.Replace("/", @"\") == current.MainModule.FileName)
                    { //Return the other process instance. 
                        return process;
                    }
                }
            } //No other instance was found, return null. 
            return null;
>>>>>>> 5fa1eb16526b3127117df455a3a8b6ca78e7c547
        }
    }
}
