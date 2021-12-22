using System;
using System.Threading;

namespace BuildDllTool
{
    class Program
    {
        static string ReplaseStr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("要转换的字符为空");
                return null;
            }
            return str.Replace("--", " ");
        }

        static void Main(string[] args)
        {
            if (args.Length == 5)
            {
                Console.WriteLine("Unity Asset 路径：" + args[0]);
                Console.WriteLine("dll 输出路径：" + args[1]);
                Console.WriteLine("Unity 系统的 dll 文件路径：" + args[2]);
                Console.WriteLine("编译配置路径：" + args[3]);
                Console.WriteLine("编译选项：" + args[4]);

                var result = ScriptBiuldToDll.Build(ReplaseStr(args[0]), ReplaseStr(args[1]), ReplaseStr(args[2]), ReplaseStr(args[3]), ReplaseStr(args[4]));

                Console.WriteLine("退出");
            }
            else
            {
                Console.WriteLine("参数不匹配！");
                Console.WriteLine("退出！");
            }
            Thread.Sleep(500);
            System.Diagnostics.Process.GetCurrentProcess().Close();
        }
    }
}
