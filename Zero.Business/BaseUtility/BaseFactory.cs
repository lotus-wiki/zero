﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zero.Business
{
    /// <summary>
    /// 定义通用的功能工厂
    /// </summary>
    public class BaseFactory
    {
        /// <summary>
        /// 对象用于锁
        /// </summary>
        private static readonly Object locker = new Object();
        private static BaseManager basemanager = null;
        /// <summary>
        /// 通用操作
        /// </summary>
        /// <returns></returns>
        public static IBaseManager BaseHelper()
        {
            if (basemanager == null)
            {
                return new BaseManager();
            }
            else
            {
                lock (locker)
                {
                    return basemanager;
                }
            }
        }
    }
}
