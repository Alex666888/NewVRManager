using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public abstract class AbstractMessageHead
    {
        /// <summary>
        /// 系统版本号
        /// </summary>
        public abstract string SysVersion{get;set;}

        /// <summary>
        /// 时间戳，格式： yyyyMMddHHmmss
        /// </summary>
        public abstract string TimeStamp { get;set;}

        /// <summary>
        /// 设备号
        /// </summary>
        public abstract string DeviceId { get; set; }

        /// <summary>
        /// 报文序号
        /// </summary>
        public abstract string SerialNo { get; set; }

        /// <summary>
        /// 加密验证串 加密验证方式： MD5 (deviceID+SerialID+Password+Timestamp)
        /// </summary>
        public abstract string EncryID { get; }

    }
}
