using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class AdvertSynchroBody
    {
        #region =============视 频 广 告 播 放 同 步 接 口===========
        private string advertID;
        /// <summary>
        ///  advertId String 广告 ID
        /// </summary>
        public string AdvertID
        {
            set { advertID = value; }
            get { return advertID; }
        }

        private string playTime;
        /// <summary>
        /// Playtime String 播放时间
        /// </summary>
        public string PlayTime
        {
            set { playTime = value; }
            get { return playTime; }
        }
        #endregion
    }
}
