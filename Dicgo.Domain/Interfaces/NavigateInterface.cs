﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicgo.Domain.Interfaces
{
    /// <summary>
    /// author:TT
    /// time:2021/5/10 16:56:27
    /// desc:INavigation
    /// </summary>
    public interface INavigateIn<T>
    {
        /// <summary>
        /// 进入
        /// </summary>
        void NavigateIn(T param);


    }

    /// <summary>
    /// 无参数导航接口
    /// </summary>
    public interface INavigateIn
    {
        /// <summary>
        /// 进入
        /// </summary>
        void NavigateIn();


    }
    public interface INavigateOut
    {
        /// <summary>
        /// 离开
        /// </summary>
        void NavigateOut();
    }
}
