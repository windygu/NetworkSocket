﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSocket.Fast
{
    /// <summary>
    /// 快速构建Tcp服务端接口
    /// </summary>
    public interface IFastTcpServer : ITcpServer<FastSession>
    {
        /// <summary>
        /// 获取或设置序列化工具       
        /// </summary>
        ISerializer Serializer { get; set; }

        /// <summary>
        /// 获取或设置Api行为特性过滤器提供者
        /// </summary>
        IFilterAttributeProvider FilterAttributeProvider { get; set; }
    }
}
