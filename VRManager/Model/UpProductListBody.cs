using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class UpProductListBody
    {
        private Object upProductListReq;
        /// <summary>
        /// 上传产品请求列表实体
        /// </summary>
        public Object UpProductListReq
        {
            set { upProductListReq = value; }
            get { return upProductListReq; }
        }
    }

    public struct upProductListReq
    {
        #region  ========== 上传产品列表接口 请求实体参数 ===========

        private String productId;
        /// <summary>
        /// productId String 产品唯一标识， 本地新安装产品为空
        /// </summary>
        public String ProductID
        {
            set { productId = value; }
            get { return productId; }
        }

        private String productName;
        /// <summary>
        /// productName String 产品名称
        /// </summary>
        public String ProductName
        {
            set { productName = value; }
            get { return productName; }
        }

        private string productVer;
        /// <summary>
        /// productVer String 产品当前版本
        /// </summary>
        public String ProductVer
        {
            set { productVer = value; }
            get { return productVer; }
        }

        #endregion


        #region ========== 上传产品列表接口响 应实体参数 ===========
        private int productUp;
        /// <summary>
        /// productUp int 产品升级标志 0: 不升级 1: 升级
        /// </summary>
        public int ProductUp
        {
            set { productUp = value; }
            get { return productUp; }
        }
        
        private String productUpVer;
        /// <summary>
        /// productUpVer String 产品升级版本
        /// </summary>
        public String ProductUpVer
        {
            set { productUpVer = value; }
            get { return productUpVer; }
        }
        #endregion
    }
}
