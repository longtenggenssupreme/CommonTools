using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComLibs
{
    /// <summary>
    /// 常用工具类
    /// </summary>
    public class CommonTool
    {
        #region Fields and Properties

        #endregion

        #region Methods
        /// <summary>
        /// 获取随机数
        /// </summary>
        /// <param name="min">最小值，包括边界</param>
        /// <param name="max">最大值，不包括边界</param>
        /// <returns>取随机数</returns>
        public int GetRandomNumber(int min, int max)
        {
            int x = 1;
            Random random = new Random();
            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int GetRandomNumberDelay(int min, int max)
        {
            int x = 1;
            Thread.Sleep(GetRandomNumber(min, max));
            GetRandomNumber(min, max);
            return x;
        } 
        #endregion
    }
}
