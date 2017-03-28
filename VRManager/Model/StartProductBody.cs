using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class StartProductBody
    {
        private string productId;

        /// <summary>
        /// String 产品 ID
        /// </summary>
        public string ProductId
        {
            set { productId = value; }
            get { return productId; }
        }

        private int resCode;
        /// <summary>
        /// resCode int 是否成功
        /// 1. 成功启动
        /// 0. 启动失败
        /// </summary>
        public int ResCode
        {
            set { resCode = value; }
            get { return resCode; }
        }

    }
}
