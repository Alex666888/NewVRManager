using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class AdvertListBody
    {
        private List<Advert> advertList;
        /// <summary>
        /// 广告信息列表
        /// </summary>
        public List<Advert> AdverList
        {
            set { advertList = value; }
            get { return advertList; }
        }

        private string advertQueue;
        /// <summary>
        /// 广告播放顺序， 以逗号分隔 Id
        /// </summary>
        public string AdvertQueue
        {
            set { advertQueue = value; }
            get { return advertQueue; }
        }
    }

    /// <summary>
    /// 待 机 广 告 视 频 结 构
    /// </summary>
    public struct Advert
    {
        private string advertId;
        /// <summary>
        /// advertId String 广告 ID
        /// </summary>
        public string AdvertId
        {
            set { advertId = value; }
            get { return advertId; }
        }

        private string advertName;
        /// <summary>
        /// advertName String 广告名称
        /// </summary>
        public string AdvertName
        {
            set { advertName = value; }
            get { return advertName; }
        }

        private String type;
        /// <summary>
        /// type String 广告类型(保留)
        /// </summary>
        public String Type
        {
            set { type = value; }
            get { return type; }
        }

        private String url;
        /// <summary>
        /// url String 广告资源链接
        /// </summary>
        public String URL
        {
            set { url = value; }
            get { return url; }
        }
    }
}
