using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyBean.Core.Helper
{
    /// <summary>
    ///  文件名的处理类
    /// </summary>
    public static class PathHelper
    {
        /// <summary>
        /// 计算绝对路径
        /// </summary>
        /// <param name="absoluteDir">绝对目录</param>
        /// <param name="relativeFile">相对文件</param>
        /// <returns></returns>
        /// <example>
        /// @"D:\Windows\regedit.exe" = GetAbsolutePath(@"D:\Windows\Web\Wallpaper\", @"..\..\regedit.exe" );
        /// @"D:\Windows\system32" = GetAbsolutePath(@"D:\Windows\Web\Wallpaper\", @"..\..\system32" );
        /// 
        /// </example>
        public static string GetAbsolutePath(string absoluteDir, string relativeFile)
        {
            bool isNotOver = true;
            int intStart = 0;

            if (relativeFile.IndexOf(":") !=-1)
            {  // 绝对路径
                return relativeFile;
            }

            while (isNotOver)
            {
                if (relativeFile.StartsWith(@"..\"))
                {
                    relativeFile = relativeFile.Remove(0, 3);
                    intStart++;
                }else if (relativeFile.StartsWith(@".\"))
                {
                    relativeFile = relativeFile.Remove(0, 2);
                    isNotOver = false;
                }
                else
                {
                    isNotOver = false;
                }
            }

            if (intStart > 0)
            {
                if (absoluteDir.EndsWith("\\"))
                {
                    absoluteDir = absoluteDir.Remove(absoluteDir.Length - 1);
                }

                for (int i = 0; i < intStart; i++)
                {
                    absoluteDir = absoluteDir.Remove(absoluteDir.LastIndexOf("\\"));
                }
            }
            return Path.Combine(absoluteDir, relativeFile);
        }


    }
}
