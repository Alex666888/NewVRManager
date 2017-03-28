using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class ProductStartCheckBody
    {
        #region ============== 产品启动记录接口 请 求 参 数 ==============
        private String productId;
        /// <summary>
        /// 产品ID
        /// </summary>
        public String ProductId
        {
            set { productId = value; }
            get { return productId; }
        }
        #endregion

        #region ================= 产品启动记录接口 响 应 参 数 ==========
        private int chargeMode;
        /// <summary>
        /// 计费模式(1. 次数 2. 时间)
        /// </summary>
        public int ChargeMode
        {
            set { chargeMode = value; }
            get { return chargeMode; }
        }

        private String chargeParam;
        /// <summary>
        /// 计费参数
        /// </summary>
        public String ChargeParam
        {
            set { chargeParam = value; }
            get { return chargeParam; }
        }
        private String dataParam;
        /// <summary>
        /// 断电续完参数
        /// </summary>
        public String DataParam
        {
            set { dataParam = value; }
            get { return dataParam; }
        }
        #endregion
    }
}
