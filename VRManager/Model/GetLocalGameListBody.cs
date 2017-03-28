using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class GetLocalGameListBody
    {
        private string gameIds;
 
        /// <summary>
        /// 游戏 ID，用逗号分隔
        /// </summary>
        public string GameIds
        {
            set { gameIds = value; }
            get { return gameIds; }
        }
    }
}
