using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class ProductEndCheckBody
    {
        private String productId;
        /// <summary>
        /// 产品 ID
        /// </summary>
        public string ProductId
        {
            set { productId = value; }
            get { return productId; }
        }


        private string overTime;
        //游戏结束时间
        public string OverTime
        {
            set { overTime = value; }
            get { return overTime; }
        }
    }
}
