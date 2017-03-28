using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class MessageHead :AbstractMessageHead
    {
        private string sysVersion;

        /// <summary>
        /// 系统版本号
        /// </summary>
        public override string SysVersion
        {
            get
            {
                return sysVersion;
            }
            set
            {
                sysVersion = value;
            }
        }

        private string timeStamp;
        /// <summary>
        /// 时间戳，格式： yyyyMMddHHmmss
        /// </summary>
        public override string TimeStamp
        {
            get
            {
                return timeStamp;
            }
            set
            {
                timeStamp = value;
            }
        }

        private string deviceId;
        /// <summary>
        /// 设备号
        /// </summary>
        public override string DeviceId
        {
            get
            {
                return deviceId;
            }
            set
            {
                deviceId = value;
            }
        }

        private string serialNo;
        /// <summary>
        /// 报文序号
        /// </summary>
        public override string SerialNo
        {
            get
            {
                return serialNo;
            }
            set
            {
                serialNo = value;
            }
        }

        private string encryID;
        /// <summary>
        /// 加密验证串\加密验证方式： MD5\（ deviceID+SerialID+Password+Timestamp）
        /// </summary>
        public override string EncryID
        {
            get
            {
                return encryID;
            }
        }
    }
}
